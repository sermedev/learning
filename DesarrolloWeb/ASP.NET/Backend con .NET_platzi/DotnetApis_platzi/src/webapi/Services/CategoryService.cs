using webapi.Models;

namespace webapi.Services
{
    public class CategoryService: ICategoryService
    {
        TasksContext _context;

        public CategoryService(TasksContext context)
        {
            _context = context;
        }

        public IEnumerable<Category> Get()
        {
            return _context.Categories;
        }

        public async System.Threading.Tasks.Task Save(Category category)
        {
            _context.Add(category);

            await _context.SaveChangesAsync();
        }

        public async System.Threading.Tasks.Task Update(Guid id, Category category)
        {
            Category currentCategory = _context.Categories.Find(id);

            if(currentCategory != null)
            {
                currentCategory.Name = category.Name;
                currentCategory.Description = category.Description;
                currentCategory.Priotity = category.Priotity;

                await _context.SaveChangesAsync();
            }
        }

        public async System.Threading.Tasks.Task Delete(Guid id)
        {
            Category currentCategory = _context.Categories.Find(id);

            if (currentCategory != null)
            {
               _context.Remove(currentCategory);
                await _context.SaveChangesAsync();
            }
        }
    }

    public interface ICategoryService
    {
        IEnumerable<Category> Get();
        System.Threading.Tasks.Task Save(Category category);
        System.Threading.Tasks.Task Update(Guid id, Category category);
        System.Threading.Tasks.Task Delete(Guid id);
    }
}

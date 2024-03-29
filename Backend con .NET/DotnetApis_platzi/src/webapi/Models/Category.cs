using System.Text.Json.Serialization;

namespace webapi.Models;

public class Category
{
    public Guid CategoryId {get; set;}
    public string Name {get; set;}     
    public string Description {get; set;}    
    public int Priotity { get; set; }
    [JsonIgnore]
    public virtual ICollection<webapi.Models.Task> Tasks {get; set;}     
}
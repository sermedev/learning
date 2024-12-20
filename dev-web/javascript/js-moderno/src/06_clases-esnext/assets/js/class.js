class Person
{
    static _counter = 0;
    static get counter()
    {
        return Person._counter + ' instancias'
    }

    static message()
    {
        console.log( this.nombre);
        console.log( 'Hola a todos, soy un método estático');
    }

    name     = '';
    code     = '';
    sentence = '';
    food   = '';

    constructor(name = 'No name', code = 'No code', sentence = 'No sentence') {
        this.name = name;
        this.code = code;
        this.sentence = sentence;

        Person._counter += 1;
    }

    set setFavouriteFood(food) 
    {
        this.food = food.toUpperCase();
    }
    get getFavouriteFood()
    {
        return `La comida favorita de ${this.nombre} es ${this.food}`;
    }

    whoAmI()
    {
        console.log(`Soy ${this.name} y mi identidad es ${this.code}`);
    }

    whatIsMyIdentity()
    {
        console.log(this.sentence);
    }
}


const spiderman = new Person('Peter Paker', 'Spiderman', 'Soy tu amigable vecnio');
const ironman = new Person('Tony Stark', 'Ironman', 'Yo soy Ironman');

console.log(spiderman);
console.log(ironman);

spiderman.whoAmI();
ironman.whoAmI();

ironman.whatIsMyIdentity();

spiderman.setFavouriteFood = 'El pie de cereza de la tía May';
console.log(spiderman);
console.log(spiderman.getFavouriteFood);

console.log(Person.counter);
Person.message();


Person.propertyExternal = 'Hola mundo';
console.log(Person.propertyExternal);
console.log(Person);
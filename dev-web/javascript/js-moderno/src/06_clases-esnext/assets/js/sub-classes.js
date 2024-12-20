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

class Heroe extends Person
{
    clan = 'Sin clan';

    constructor(name, code, sentence)
    {
        super(name, code, sentence);
        this.clan = 'Los Avengers';
    }

    whoAmI()
    {
        console.log(`Soy yo ${ this.name}`);
        super.whoAmI();
    }
}



const spiderman = new Heroe('Peter Paker', 'Spiderman', 'Soy tu amigable vecnio');

console.log(spiderman);
spiderman.whoAmI();
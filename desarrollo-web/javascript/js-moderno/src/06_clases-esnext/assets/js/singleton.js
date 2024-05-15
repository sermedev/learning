class Singleton{

    static instance;
    name = '';

    constructor(name = '') {
        
        // const a = undefined;
        // console.log(a);
        // console.log(!a);
        // console.log(!!a);

        if (!!Singleton.instance) {
            return Singleton.instance;
        }

        Singleton.instance = this;
        this.name = name;

       // return this;
    }

}

const instance1 = new Singleton('Mickey');
const instance2 = new Singleton('Lucas');
const instance3 = new Singleton('Donald');

console.log(`Nombre en la instancia1 es: ${instance1.name}`);
console.log(`Nombre en la instancia1 es: ${instance2.name}`);
console.log(`Nombre en la instancia1 es: ${instance3.name}`);
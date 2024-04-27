// INTRODUCCIÓN A JAVASCRIPT Y LA CONSOLA

// alert('Hola desde app');
// console.log('Hola mundo');

let a = 10,
    b = 20,
    c = 'Hola ',
    d = 'Spiderman';
    x = a + b;

const saludo = c + d;

// console.log('%c Mis variables', 'color:green; font-weight: bold');
// console.log({a});
// console.log({b});
// console.log({c});
// console.log({d});
// console.table({a , b , c, d, x})
// console.log(saludo);

c = 'Hola de nuevo'


const outerHeight = 600;
let outerWidth = 1000000;




// TIPS:
// - Usar const si vamos a declarar una variable que no vamos a modificar, será más eficiente en memoria
// - No user var, no se elimina por retrocompatibilidad. Usar Let en su lugar. Var sobreescribe las variables de windows y además 
//   puede enmascarás errores en ejecución en cuanto a utilización de variables sin definir previamente
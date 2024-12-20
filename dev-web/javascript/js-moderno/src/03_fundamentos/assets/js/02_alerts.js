// alert('Hola mundo');

// const yourName = prompt('¿Cuál es tu nombre?', 'Sin nombre');

// alert('Hola ' + nombre)
// console.log( yourName );
// console.log( '***' + yourName + '***' );

// const option = confirm( '¿Está seguro de borrar esto?' );
// console.log(option);

console.log(global);










// TIPS:
// Tenemos que ser conscientes de donde se ejecutará nuestro código js ya algunas librería u objetos pueden
//  no estar disponibles inicialmente. Por ejemplo:
// - en console.log(global);, global estará disponible en node.js pero no en nuestro navegador
// - confirm(), alert() o prompt no estarán disponibles en node.js porque están en el objeto window

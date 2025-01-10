
const readline = require('readline');
const https = require('https');

const rl = readline.createInterface({
    input: process.stdin,
    output: process.stdout
});

if (process.stdin.isTTY) {
    process.stdin.setRawMode(true);
}

//Capturamos eventos del teclado
process.stdin.on('data', (key) => {
    console.log(`Tecla presionada: ${key} en el segundo ${cnt * interval}`);
});

var cnt = 0;
var interval = 1000;

var printTimeElapsed = () => console.log(`Tiempo desde que inició el intervalo: ${++cnt * interval} segundos`);
setInterval(printTimeElapsed, interval);

var printMessage = () => console.log("Esta función se ejecuta a los 5 segundos de iniciar el código");
setTimeout(printMessage, 5000);

https.get('https://www.sino-shipping.com', (res) => {
    console.log(`Status Code Pagina China: ${res.statusCode}`);
});

https.get('https://www.upb.edu.co', (res) => {
    console.log(`Status Code UPB: ${res.statusCode}`);
});

https.get('https://www.hinkpie.com', (res) => {
    console.log(`Status Code Hinkpie: ${res.statusCode}`);
});

console.log("Recordemos que el código siempre se ejecuta de arriba para abajo\n\
    Esta es la última instrucción en ser leida");
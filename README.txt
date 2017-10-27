Este es el software de la prueba Backend .NET para postular a la empresa Kunder:

-Al iniciar la aplicacion, automaticamente abrira una pagina de inicio muy simple con dos string llamados "Pagina" e "Inicio", despues puede acceder a las funciones
requeridas tipeando en el navegador las direcciones que se indicaron.

-La primera funcion se abre al tipear la direccion localhost:{port}/word. Ya que se requeria que las funciones fueran en el metodo POST, solo se puede acceder
a la funcionalidad usando una herramienta como POSTMAN para generar consultas JSON. El body de la consulta JSON(debe especificarse en la herramienta que es una
consulta JSON) de be ser de la forma "nada", un string de 4 letras entre comillas. Si ingresa algo del estilo {"data": "nada"}, la función no lo reconocera. Si
ingresa un string de mas o menos de 4 letras, el programa le indicara que es una entrada no valida. Si ingresa un string de 4 letras con solo numeros, el 
programa le indicara que es una entrada no valida.

-La segunda funcion se abre al tipear la direccion localhost:{port}/time?value={hh:mm}. Al estar en el metodo GET, esta funciona en el propio navegador. Tras ingresar
una direccion valida tal como http://localhost:63714/time?value=14:33, el navegador le devolvera la hora en formato UTC ISO 8601. En este caso seria: 
"2017-10-27T14:33:00Z". 


Eduardo Vera, 2017
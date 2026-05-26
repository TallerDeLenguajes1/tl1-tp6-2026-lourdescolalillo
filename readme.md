¿String es una tipo por valor o un tipo por referencia? 
Es un tipo de referencia

¿Qué secuencias de escape tiene el tipo string?
No hay ningun caracter que finalice en NULL al final de una cadena de C#; por lo tanto, la cadena de C# puede contener cualquier numero de caracteres nulos insertados ("\0").


¿Qué sucede cuando utiliza el carácter @ y $ antes de una cadena de texto? 
El signo $ permite la interpolacion de de cadenas. Es la forma mas moderna y legible de unir textos y variables. Al colocarlo antes de las comillas, se puede introducir variables o expresiones directamente adentro del texto entre llaves.

En C# anteponer @ sirve para que el compilador lea la cadena de texto exactamente de forma literal, ignorando las secuencias de escape habituales como \n o \t permitiendo escribir textos en multiples lineas directamente en el codigo.
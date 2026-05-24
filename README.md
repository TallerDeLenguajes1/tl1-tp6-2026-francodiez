### 1
El tipo String es un tipo por referencia. Una cadena es un objeto de tipo String cuyo valor es texto. Internamente, el texto se almacena
como una colección secuencial de solo lectura de objetos Char. Una variable no contiene la instancia directamente, sino una
referencia a la ubicación en memoria donde se encuentra la instancia del tipo.
### 2
Se utilizan secuencias de escape que comienzan con una barra invertida. Algunas de estas son: \' - \" - \\ - \0 - \a
### 3
Al anteponer el símbolo @, el compilador ignora todas las secuencias de escape. La única excepción es para las comillas dobles.
Anteponiendo $.Permiten evaluar variables directamente dentro de la cadena y también admiten todas las secuencias de escape estándar.

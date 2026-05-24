string texto;
string texto2;
string concatenacion;
int longitud;
float n1;
float n2;
int opcion;
bool existe;
string[] sepcadena;
char[] operadores = { '+', '-', '*', '/' };
char operador;
int indiceOperador;
string primerSegmento;
string segundoSegmento;

Console.WriteLine("Ingrese una cadena de texto");
texto=Console.ReadLine();
longitud=texto.Length;
Console.WriteLine("La longitud de la cadena es "+longitud);
Console.WriteLine("Ingrese una segunda cadena de texto para concatenar");
texto2=Console.ReadLine();
concatenacion=$"{texto}{texto2}";
Console.WriteLine(concatenacion);
Console.WriteLine("Ingrese 2 numeros para realizar una operacion sencilla");
float.TryParse(Console.ReadLine(),out n1);
float.TryParse(Console.ReadLine(), out n2);
Console.WriteLine("Ingrese la operacion a realizar:\n1-Suma\n2-Resta\n3-Multiplicacion\n4-Division");
do
{
    int.TryParse(Console.ReadLine(), out opcion);    
} while (opcion<1 || opcion>4);
if (opcion==4 && n2 == 0)
{
    Console.WriteLine("No se puede realizar division por cero");
} else
{
    Calculadora(n1,n2,opcion);
}
Console.WriteLine("Cada elemento del texto original: ");
foreach(char a in texto)
{
    Console.WriteLine(a);
} 
Console.WriteLine("Busque una palabra en la cadena y se indicara si se encuentra o no");
existe=texto.Contains(Console.ReadLine());
if (existe)
{
    Console.WriteLine("Si se encuentra la palabra en la cadena");
}
else
{
    Console.WriteLine("No se encuentra la palabra en la cadena");
} 
Console.WriteLine($"Cadena en mayusculas: {texto.ToUpper()}");
Console.WriteLine($"Cadena en minusculas: {texto.ToLower()}"); 
//voy a separar como caracter separador la coma ,
Console.WriteLine("Ingrese una cadena con palabras separadas con la coma");
texto=Console.ReadLine();
sepcadena=texto.Split(',');
foreach(string elemento in sepcadena)
{
    Console.WriteLine($"Elemento: {elemento}");
} 
Console.WriteLine("Ingrese una ecuacion simple como cadena de caracteres (suma,resta,multiplicacion o division)");
texto=Console.ReadLine();
indiceOperador=texto.IndexOfAny(operadores);
if (indiceOperador != -1)
{
    operador = texto[indiceOperador];
    // Desde el inicio (0) hasta antes del operador
    primerSegmento = texto.Substring(0, indiceOperador);
    // Desde después del operador hasta el final
    segundoSegmento = texto.Substring(indiceOperador + 1);
    n1=float.Parse(primerSegmento);
    n2=float.Parse(segundoSegmento);
    switch (operador)
    {
        case '+':
        Calculadora(n1,n2,1);
        break;
        case '-':
        Calculadora(n1,n2,2);
        break;
        case '*':
        Calculadora(n1,n2,3);
        break;
        case '/':
        Calculadora(n1,n2,4);
        break;
    }
}


void Calculadora(float n1, float n2, int opcion)
{
    float resultado=0;
    switch (opcion)
    {
        case 1:
        resultado=n1+n2;
        Console.WriteLine($"La suma de {n1.ToString()} y de {n2.ToString()} es igual a:{resultado.ToString()}"); //ToString() convierte dato a tipo string
        break;
        case 2:
        resultado=n1-n2;
        Console.WriteLine($"La resta de {n1.ToString()} y de {n2.ToString()} es igual a:{resultado.ToString()}");
        break;
        case 3:
        resultado=n1*n2;
        Console.WriteLine($"La multiplicacion de {n1.ToString()} y de {n2.ToString()} es igual a:{resultado.ToString()}");
        break;
        case 4:
        resultado=n1/n2;
        Console.WriteLine($"La division de {n1.ToString()} y de {n2.ToString()} es igual a:{resultado.ToString()}");
        break;
    }
}
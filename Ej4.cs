string texto;
string texto2;
string concatenacion;
int longitud;
float n1;
float n2;
float resultado;
int opcion;

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
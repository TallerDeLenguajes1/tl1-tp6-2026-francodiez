bool opera=true;
int opcion=0;
float a;
float b;
float resultado;
double resultadotrig;
int resultadoint;
do
{
    Console.WriteLine("Ingresa una operacion a realizar:\n1-Valor absoluto\n2-Cuadrado\n3-Raiz Cuadrada\n4-Seno\n5-Coseno\n6-Parte entera\n7-Maximo\n8-Minimo");
    do
    {
        opcion=int.Parse(Console.ReadLine());    
    } while (opcion<1 || opcion>8);
    
    switch (opcion)
    {
        case 1:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultado=absoluto(a);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 2:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultado=cuadrado(a);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 3:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultado=raiz(a);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 4:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultadotrig=seno(a);
        Console.WriteLine("Resultado:"+resultadotrig);
        break;
        case 5:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultadotrig=coseno(a);
        Console.WriteLine("Resultado:"+resultadotrig);
        break;
        case 6:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultadoint=entero(a);
        Console.WriteLine("Resultado:"+resultadoint);
        break;
        case 7:
        Console.WriteLine("Ingrese dos numeros diferentes");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        resultado=maximo(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 8:
        Console.WriteLine("Ingrese dos numeros diferentes");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        resultado=minimo(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
    }
    Console.WriteLine("Si quiere realizar otro calculo presione cualquier numero distinto de cero");
    opcion=int.Parse(Console.ReadLine());
    if (opcion == 0)
    {
        opera=false;
    }
} while (opera);

float absoluto(float a)
{
    float resultado=Math.Abs(a);
    return resultado;
}

float cuadrado(float a)
{
    float resultado=a * a;
    return resultado;
}

float raiz(float a)
{
    float resultado=(int)Math.Sqrt(a);
    return resultado;
}

double seno(float a) //asumo que le estoy pasando grados
{
    double radianes = a * Math.PI / 180.0;
    double resultado = Math.Sin(radianes);
    return resultado;
}

double coseno(float a)
{
    double radianes = a * Math.PI / 180.0;
    double resultado = Math.Cos(radianes);
    return resultado;
}

int entero(float a)
{
    int resultado=(int)a;
    return resultado;
}

float maximo (float a, float b)
{
    float resultado;
    if (a > b)
    {
        resultado=a;
    } else
    {
        resultado=b;
    }
    return resultado;
}

float minimo (float a, float b)
{
    float resultado;
    if (a < b)
    {
        resultado=a;
    } else
    {
        resultado=b;
    }
    return resultado;
}
/*bool opera=true;
bool NoPermitido=true;
int opcion=0;
float a;
float b;
float resultado;
double resultadotrig;
int resultadoint;
do
{
    Console.WriteLine("Ingresa una operacion a realizar:\n1-Suma\n2-Resta\n3-Multiplicar\n4-Dividir\n5-Valor absoluto\n6-Cuadrado\n7-Raiz Cuadrada\n8-Seno\n9-Coseno\n10-Parte entera\n11-Maximo\n12-Minimo");
    do
    {
        opcion=int.Parse(Console.ReadLine());    
    } while (opcion<1 || opcion>12);
    
    switch (opcion)
    {
        case 1:
        Console.WriteLine("Ingrese 2 numeros");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        resultado=Suma(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 2:
        Console.WriteLine("Ingrese 2 numeros");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        resultado=Resta(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 3:
        Console.WriteLine("Ingrese 2 numeros");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        resultado=Multiplicar(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 4:
        Console.WriteLine("Ingrese 2 numeros, el segundo distinto de cero");
        a=float.Parse(Console.ReadLine());
        do
        {
            b=float.Parse(Console.ReadLine());
            if (b != 0)
            {
                NoPermitido=false;
            }
        } while (NoPermitido);
        NoPermitido=true;
        resultado=Dividir(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 5:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultado=absoluto(a);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 6:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultado=cuadrado(a);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 7:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultado=raiz(a);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 8:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultadotrig=seno(a);
        Console.WriteLine("Resultado:"+resultadotrig);
        break;
        case 9:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultadotrig=coseno(a);
        Console.WriteLine("Resultado:"+resultadotrig);
        break;
        case 10:
        Console.WriteLine("Ingrese un numero");
        a=float.Parse(Console.ReadLine());
        resultadoint=entero(a);
        Console.WriteLine("Resultado:"+resultadoint);
        break;
        case 11:
        Console.WriteLine("Ingrese dos numeros diferentes");
        a=float.Parse(Console.ReadLine());
        b=float.Parse(Console.ReadLine());
        resultado=maximo(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 12:
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
    float resultado=(float)Math.Sqrt(a);
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

float Suma(float a, float b)
{
    float suma=a+b;
    return suma;
}
float Resta(float a,float b)
{
    float resta=a-b;
    return resta;
}
float Multiplicar(float a,float b)
{
    float producto=a*b;
    return producto;
}
float Dividir(float a,float b)
{
    float division=a/b;
    return division;
} */
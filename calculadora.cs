bool opera=true;
bool NoPermitido=true;
int opcion=0;
int a=0;
int b=0;
int resultado;
do
{
    Console.WriteLine("Ingresa una operacion a realizar:\n1-Suma\n2-Resta\n3-Multiplicar\n4-Dividir\n");
    do
    {
        opcion=int.Parse(Console.ReadLine());    
    } while (opcion<1 || opcion>4);
    
    switch (opcion)
    {
        case 1:
        Console.WriteLine("Ingrese 2 numeros");
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        resultado=Suma(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 2:
        Console.WriteLine("Ingrese 2 numeros");
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        resultado=Resta(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 3:
        Console.WriteLine("Ingrese 2 numeros");
        a=int.Parse(Console.ReadLine());
        b=int.Parse(Console.ReadLine());
        resultado=Multiplicar(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
        case 4:
        Console.WriteLine("Ingrese 2 numeros, el segundo distinto de cero");
        a=int.Parse(Console.ReadLine());
        do
        {
            b=int.Parse(Console.ReadLine());
            if (b != 0)
            {
                NoPermitido=false;
            }
        } while (NoPermitido);
        resultado=Dividir(a,b);
        Console.WriteLine("Resultado:"+resultado);
        break;
    }
    NoPermitido=true;
    Console.WriteLine("Si quiere realizar otro calculo presione cualquier numero distinto de cero");
    opcion=int.Parse(Console.ReadLine());
    if (opcion == 0)
    {
        opera=false;
    }
} while (opera);


int Suma(int a, int b)
{
    int suma=a+b;
    return suma;
}
int Resta(int a,int b)
{
    int resta=a-b;
    return resta;
}
int Multiplicar(int a,int b)
{
    int producto=a*b;
    return producto;
}
int Dividir(int a,int b)
{
    int division=a/b;
    return division;
}
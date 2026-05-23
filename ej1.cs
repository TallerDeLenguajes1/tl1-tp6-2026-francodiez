//Ejercicio 1, para usar pongo en comentarios cualquier otro .cs
int a=0; //le doy valor inicial porque para el segundo while el programa no se asegura si llega un valor
string c;
int invertido=0;
int digito;
bool NoInvertible=true;

while (NoInvertible)
{
    Console.WriteLine("Ingrese valor para invertir: ");
    c=Console.ReadLine();
    if (int.TryParse(c, out a) && a>0) { //pues a es entero, si cumple se guarda en a
        Console.WriteLine("Valor convertido "+a);
        NoInvertible=false;
    } else{
        Console.WriteLine("Entrada no valida"); //si no cumple no se guarda
    }  
}

while (a>=1)
{
    digito=a%10;
    a=a/10;
    invertido=invertido*10 + digito;
}
Console.WriteLine("Valor invertido:"+invertido);




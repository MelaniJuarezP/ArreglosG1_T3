using Arreglos.Logica;

//Console.WriteLine("Operaciones de pila");
MiArreglo oMiArreglo= new MiArreglo(50000);
try
{
    Console.WriteLine("Arreglo");
    var tiempo1 = DateTime.Now;
    oMiArreglo.Llenar(1,999999);
    Console.WriteLine(oMiArreglo);
    var tiempo2 = DateTime.Now;
    var restaTiempo=tiempo2- tiempo1;
    Console.WriteLine($"\nTiempo transcurrido: {restaTiempo.Minutes} minutos, {restaTiempo.Seconds} segundos, {restaTiempo.Milliseconds} milisegundos, {restaTiempo.Nanoseconds} nanosegundos.");
    Console.ReadKey();


    /*Console.WriteLine("\nPares");
    var verPares = oMiArreglo.ObtenerPares();
    Console.WriteLine(verPares);
    Console.ReadKey();


    Console.WriteLine("\nPares ordenados");
    verPares.Ordenar(false); //false descendene true ascendente
    Console.WriteLine(verPares);
    Console.ReadKey();*/

    Console.WriteLine("\nPrimos");
    var tiempo3 = DateTime.Now;
    var verPrimos = oMiArreglo.ObtenerPrimos();
    Console.WriteLine(verPrimos);
    var tiempo4 = DateTime.Now;
    var restaTiempo2 = tiempo4 - tiempo3;
    Console.WriteLine($"\nTiempo transcurrido al obtener primos: {restaTiempo2.Minutes} minutos, {restaTiempo2.Seconds} segundos, {restaTiempo2.Milliseconds} milisegundos, {restaTiempo2.Nanoseconds} nanosegundos.");
    Console.ReadKey();


    Console.WriteLine("\nPrimos ordenados");
    var tiempo5 = DateTime.Now;
    verPrimos.Ordenar(true); //false descendene true ascendente
    Console.WriteLine(verPrimos);
    var tiempo6 = DateTime.Now;
    var restaTiempo3 = tiempo6 - tiempo5;
    Console.WriteLine($"\nTiempo transcurrido al ordenar los primos de forma ascendente: {restaTiempo3.Minutes} minutos, {restaTiempo3.Seconds} segundos, {restaTiempo3.Milliseconds} milisegundos, {restaTiempo3.Nanoseconds} nanosegundos.");
    Console.ReadKey();



}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}
/*try
{
    oMiArreglo.Agregar(7);
    oMiArreglo.Agregar(-2);
    oMiArreglo.Agregar(8);
    Console.WriteLine(oMiArreglo);

    Console.ReadKey();
    oMiArreglo.Insertar(500, 1);
    Console.WriteLine(oMiArreglo);

    Console.WriteLine("Eliminar 500 en posición 1");
    Console.ReadKey();
    oMiArreglo.Eliminar(1);
    Console.WriteLine(oMiArreglo);


}
catch (Exception ex)
{
    Console.WriteLine(ex.Message);
	
}
/*
oMiArreglo.LLenar(1, 20);

Console.WriteLine("Arreglo desordenado");
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado ascendente");
oMiArreglo.Ordenar(true);
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado descendente");
oMiArreglo.Ordenar(false);
Console.WriteLine(oMiArreglo);

Console.WriteLine("Arreglo ordenado");//sin parametro
oMiArreglo.Ordenar();
Console.WriteLine(oMiArreglo);*/



Console.ReadKey();

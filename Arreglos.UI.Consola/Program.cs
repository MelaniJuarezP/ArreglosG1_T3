using Arreglos.Logica;

Console.WriteLine("Operaciones de pila");
Console.WriteLine("Arreglo");
MiArreglo oMiArreglo= new MiArreglo(10);
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
Console.WriteLine(oMiArreglo);



Console.ReadKey();

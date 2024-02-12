// See https://aka.ms/new-console-template for more information
Console.WriteLine("4 notas");

Console.WriteLine();

{
    Console.WriteLine("Ingrese la primera nota:");
    double nota1 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese la segunda nota:");
    double nota2 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese la tercera nota:");
    double nota3 = Convert.ToDouble(Console.ReadLine());

    Console.WriteLine("Ingrese la cuarta nota:");
    double nota4 = Convert.ToDouble(Console.ReadLine());

    
    double promedio = (nota1 + nota2 + nota3 + nota4) / 4;

   
    if (promedio >= 70)
    {
        Console.WriteLine("El estudiante aprobó con un promedio de " + promedio);
    }
    else
    {
        Console.WriteLine("El estudiante reprobó con un promedio de " + promedio);
    }
}

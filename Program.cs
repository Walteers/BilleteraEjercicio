using BilleteraEjercicio.Moldes;

Billetera Billetera1 = new Billetera(100, 5, 2, 1, 5, 2, 1); // Declaramos una instancia de Billetera y le asiganmos valores a las propiedades con un constructor

Console.WriteLine($"Total billetera1: {Billetera1.Total().GetType()}"); // Verificamos el tipo de variable retornada por la funcion 'Total'
Console.WriteLine($"Total billetera1: {Billetera1.Total()}"); // La suma de las propiedades(cantidad de efectivo)


Billetera Billetera2 = new Billetera(200, 10, 4, 2, 10, 4, 2);
Console.WriteLine($"Total billetera2: {Billetera2.Total()}");


Billetera Billetera3 = new Billetera();

Billetera3 = Billetera1.Combinar(Billetera2);

Console.WriteLine($"Total billetera1: {Billetera1.Total()}");
Console.WriteLine($"Total billetera2: {Billetera2.Total()}");
Console.WriteLine($"Total billetera3: {Billetera3.Total()}");
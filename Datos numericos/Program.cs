Console.WriteLine("Ingrese la base del triángulo:");
double baseTriangulo = double.Parse(Console.ReadLine());

Console.WriteLine("Ingrese la altura del triángulo:");
double alturaTriangulo = double.Parse(Console.ReadLine());

double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;

Console.WriteLine($"El área del triángulo es: {areaTriangulo}");

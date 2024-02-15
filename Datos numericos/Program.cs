Console.WriteLine("Ingrese la base del triángulo:");
double baseTriangulo = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese la altura del triángulo:");
double alturaTriangulo = double.Parse(Console.ReadLine());
double areaTriangulo = 0.5 * baseTriangulo * alturaTriangulo;
Console.WriteLine("El área del triángulo es: " + areaTriangulo);

Console.WriteLine("Ingrese el radio de la esfera:");
double radio = double.Parse(Console.ReadLine());
double volumen = 4.0 / 3.0 * Math.PI * Math.Pow(radio, 3);
Console.WriteLine("El volumen de la esfera es: {volumen}");

Console.WriteLine("Ingrese las coordenadas del primer punto (x1 y1):");
double x1 = double.Parse(Console.ReadLine());
double y1 = double.Parse(Console.ReadLine());
Console.WriteLine("Ingrese las coordenadas del segundo punto (x2 y2):");
double x2 = double.Parse(Console.ReadLine());
double y2 = double.Parse(Console.ReadLine());
double distancia = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
Console.WriteLine("La distancia entre los puntos es: " + distancia);

Console.WriteLine("Ingrese la temperatura en grados Celsius:");
double celsius = double.Parse(Console.ReadLine());
double fahrenheit = celsius * 9 / 5 + 32;
Console.WriteLine("La temperatura en grados Fahrenheit es: " + fahrenheit);

Console.WriteLine("Ingrese la temperatura en grados Fahrenheit:");
double fahrenheit2 = double.Parse(Console.ReadLine());
double celsius2 = (fahrenheit - 32) * 5 / 9;
Console.WriteLine("La temperatura en grados Celsius es: "  + celsius2);

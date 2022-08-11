
Console.Write("Введите координату Х точки А ");
int Ax = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки А ");
int Ay = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Х точки B ");
int Bx = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координату Y точки B ");
int By = Convert.ToInt32(Console.ReadLine());

double result = Math.Sqrt(Math.Pow(Ax-Ay,2) + (Math.Pow(Bx-By,2)));
Console.WriteLine($"Расстояние: {Math.Round(result,3)}");

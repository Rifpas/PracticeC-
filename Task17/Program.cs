


Console.WriteLine("Введите координаты точки");
Console.Write("X: ");
int xCoordinate = Convert.ToInt32(Console.ReadLine());
Console.Write("Y: ");
int yCoordinate = Convert.ToInt32(Console.ReadLine());


int quarter = Quarter(xCoordinate,yCoordinate);
string result = quarter > 0 
                            ? $"Указанные координаты соответствуют четверти - {quarter}"
                            : "введены некоректные данные";
Console.WriteLine(result);

int Quarter(int x, int y)
{
    if(x > 0 && y > 0) return 1;
    if(x < 0 && y > 0) return 2;
    if(x < 0 && y < 0) return 3;
    if(x > 0 && y < 0) return 4;
    return 0;
}

/// a (3, 6); b (2,1) ->5,09
/// a (7, -5); b (1,-1) -> 7,21



// Console.WriteLine("Введите координаты точки 1");
// Console.Write("X1: ");
// int x1Coordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y1: ");
// int y1Coordinate = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Введите координаты точки 2");
// Console.Write("X2: ");
// int x2Coordinate = Convert.ToInt32(Console.ReadLine());
// Console.Write("Y2: ");
// int y2Coordinate = Convert.ToInt32(Console.ReadLine());

// double distance = Distance(x1Coordinate, y1Coordinate, x2Coordinate, y2Coordinate);
// Console.WriteLine(distance);

// double Distance(int x1, int y1, int x2, int y2)
// {
//     return Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
// }
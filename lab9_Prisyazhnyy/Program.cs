//сборник задач/тема 9/ средний уровень/вариант 24
try
{
    Console.WriteLine("Введите три вещественных числа:");
    Console.Write("x: ");
    double x = double.Parse(Console.ReadLine()!);
    Console.Write("y: ");
    double y = double.Parse(Console.ReadLine()!);
    Console.Write("z: ");
    double z = double.Parse(Console.ReadLine()!);
    Numbers num = new Numbers(x,y,z);
    Console.Write("Средние геометрическое чисел: ");
    num.GeometricMean();
    Console.Write($"Количество цифр суммы заданных чисел: ");
    num.SumLength();
    Console.Write("Информация об объекте: ");
    num.Print();
}
catch(Exception ex)
{
    Console.WriteLine(ex.Message);
}
class Numbers
{
    private double x;
    private double y;
    private double z;

    public Numbers()
    {
    }
    public Numbers(double x, double y, double z)
    {
        this.x = x;
        this.y = y;
        this.z = z;
    }
    public double X
    {
        get { return x; }
        set { x = value; }
    }
    public double Y
    {
        get { return y; }
        set { x = value; }
    }
    public double Z
    {
        get { return z; }
        set { z = value; }
    }
    public void GeometricMean()
    {
        Console.WriteLine(Math.Pow(x * y * z, 1.0/3.0));
    }
    public void SumLength()
    {
        Console.WriteLine((x + y + z).ToString().Length);
    }
    public void Print()
    {
        Console.WriteLine($"x: {x}, y: {y}, z: {z}");
    }
}
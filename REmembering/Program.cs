double Artem(double a, double b)
{
    double k = 0;
    switch (b)
    {
        case < 0:
            if (a > 0)
            {
                for (int i = 0; i < a; i++)
                {
                    k += b;
                }
                break;
            }
            else
            {
                for (int i = 0; i < -b; i++)
                {
                    k += -a;
                }
                break;
            }
        case > 0:
            {
                for (int i = 0; i < b; i++)
                {
                    k += a;
                }
                break;
            }
    }
    return k;
}
Console.WriteLine(Artem(-5, -6));
Console.WriteLine(Artem(7, -8));
Console.WriteLine(Artem(-9, 9));
Console.WriteLine(Artem(556, 326));
Console.WriteLine(Artem(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine())));
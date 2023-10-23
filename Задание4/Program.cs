int a;
int b;
double c;
int max = -20000;

while (true)
{
    a = Convert.ToInt32(Console.ReadLine());
    b = Convert.ToInt32(Console.ReadLine());
    if (a < b && Math.Abs(a) < 20000 && Math.Abs(b) < 20000)
    {

       for (int i = a; i <= b; i++)
        {
            c = i % 77;
            if (c == 0 && c>max)
            { 
                max = i;
            }
        }

       if (max != -20000)
        {
            Console.WriteLine(max);
        }
        else { Console.WriteLine("no"); }

    }
}



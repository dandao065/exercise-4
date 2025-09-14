using System.Diagnostics;
using System.Diagnostics.Metrics;

internal class Exercise_04
{
    static void Main()
    {
        Console.WriteLine("Bai 1. Tim so lon nhat.");
        Console.Write("Dien so thu nhat: ");
        int a=Convert.ToInt32(Console.ReadLine());
        Console.Write("Dien so thu hai: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.Write("Dien so thu ba: ");
        int c = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"So lon nhat la: {largest_num(a, b, c)}.");

        Console.WriteLine("\nBai 2. Tinh giai thua.");
        Console.Write("Nhap 1 so: ");
        int gt_num=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Giai thua cua {gt_num} bang {giai_thua(gt_num)}.");

        Console.WriteLine("\nBai 3. Kiem tra so nguyen to.");
        Console.Write("Moi ban nhap 1 so de kiem tra: ");
        int so = Convert.ToInt32(Console.ReadLine());
        if (is_prime(so))
        {
            Console.WriteLine($"{so} la so nguyen to.");
        }
        else
        {
            Console.WriteLine($"{so} khong phai so nguyen to.");
        }

        Console.WriteLine("\nBai 4.1. Hien so nguyen to nho hon so ban nhap.");
        Console.Write("Nhap 1 so: ");
        int num_4_1 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"Cac so nguyen to nho hon {num_4_1} la: ");
        prime_less_than(num_4_1);

        Console.WriteLine("\nBai 4.2. Hien n so nguyen to dau tien.");
        Console.Write("Nhap 1 so n: ");
        int num_4_2 = Convert.ToInt32(Console.ReadLine());
        Console.Write($"{num_4_2} so nguyen to dau la: ");
        first_N_prime(num_4_2);
        Console.WriteLine();

        Console.WriteLine("\nBai 5.1. Kiem tra so hoan hao.");
        Console.Write("Nhap 1 so de kiem tra: ");
        int num_5_1 = Convert.ToInt32(Console.ReadLine());
        if (is_perfect(num_5_1))
        {
            Console.WriteLine($"{num_5_1} la so hoan hao.");
        }
        else
        {
            Console.WriteLine($"{num_5_1} khong phai la so hoan hao.");
        }

        Console.Write("\nBai 5.2. Cac so hoan hao duoi 1000 la:");
        perfect_num(1000);
        Console.WriteLine();

        Console.WriteLine("\nBai 6. Kiem tra pangram.");
        Console.Write("Moi ban nhap mot chuoi ki tu: ");
        string pangram= Console.ReadLine();
        if (is_pangram(pangram))
        {
            Console.WriteLine("Chuoi cua ban la pangram.");
        }
        else
        { Console.WriteLine("Chuoi cua ban khong phai la pangram"); }
    }
    //1. Write a C# function to find the largest num in three numbers.- Improve the next version that accept at least 1 parameter
    static int largest_num(int a, int b, int c)
    {
        if (a > b && a > c)
            return a;
        else if (c > a && c > b)
            return c;
        else return b;
    }

    //2. Write a C# function to calculate the factorial of a number (a non-negative integer). The function accepts the number as an argument.
    static int giai_thua(int num)
    {
        int giai_thua = 1;
        for (int i = 1; i <= num; i++)
        {
            giai_thua*= i;

        }
        return giai_thua;
    }

    //3. Write a C# function that takes a number as a parameter and checks whether the number is prime or not.
    static bool is_prime(long num)
    {
        if (num < 2) return false;
        for (int i = 2; i <= Math.Sqrt(num); i++)
        {
            if (num % i == 0)
                return false;
        }
        return true;
    }

    //4.1. Write a C# function to print all prime numbers that less than a number(enter prompt keyboard).
    static void prime_less_than(long num)
    {
        for (int i = 2; i < num; i++)
        {
            if (is_prime(i))
                Console.Write(i + ",");
        }
        Console.WriteLine();
    }

    //4.2. Write a C# function to print the first N prime numbers. 
    static void first_N_prime (int num)
    {
        int dem = 0;
        int so = 2;
        while (dem<num)
        {
            if (is_prime(so))
            {
                Console.Write(so+", ");
                dem++;
            }
            so++;
        }
    }
    //5. Write a C# function to check whether a number is "Perfect" or not. Then print all perfect number that less than 1000.
    static bool is_perfect (int num)
    {
        int sum = 0;
        for (int i = 1;i<num;i++)
        {
            if (num%i == 0)
                sum += i;
        }
        if (sum == num)
        { return true; }
        else return false;
    }

    static void perfect_num (int pf_num)
    {
        for (int i = 2; i < pf_num; i++)
        {
            if (is_perfect(i))
                Console.Write(i +", ");
        }
    }

    //6. Write a C# function to check whether a string is a pangram or not.
    static bool is_pangram(string pg)
    {
        string alp = " abcdefghijklmnopqrstuvwxyz";
        pg=pg.ToLower();
        foreach (char c in alp)
            if (!pg.Contains(c))
                return false;
        return true;
    }
}


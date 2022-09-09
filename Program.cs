Console.WriteLine("Введите число M: ");
int m = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("Введите число N: ");
int n = Convert.ToInt16(Console.ReadLine());

int sum = 0;
RecursionTotal(n, m, sum);

void RecursionTotal(int n, int m, int sum){

    if(m > n){

        n = n + 1;

        if(m == n){

            Console.Write("Сумма: " + sum);
            return;

        }

        sum = sum + n;
        RecursionTotal(n, m, sum);

    }
    else if(n > m){

        m = m + 1;

        if(m == n){

            Console.Write("Сумма: " + sum);
            return;
            
        }

        sum = sum + m;
        RecursionTotal(n, m, sum);


    }
    else if(m == n){

        Console.Write("Сумма: " + sum);
        return;

    }

}

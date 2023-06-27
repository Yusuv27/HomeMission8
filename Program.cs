void Number1()
{
    int [,] Array = new int [3,4];
    for(int i = 0; i < Array.GetLength(0);i++)
    {
        for(int j=0;j<Array.GetLength(1);j++)
        {
            Array[i,j]=new Random().Next(1,10);
            Console.Write(Array[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();

    for(int i = 0; i < Array.GetLength(0);i++)
    {
        int x=Array[i,0];
        void Next()
        {
        for(int j=0;j<Array.GetLength(1);j++)
        {
            if(j!=Array.GetLength(1)-1)
            {
                if(Array[i,j]<Array[i,j+1])
                {
                    x=Array[i,j];
                    Array[i,j]=Array[i,j+1];
                    Array[i,j+1]=x;
                }
            }
            else if(Array[i,j]>Array[i,j-1])
            {
                x=Array[i,j];
                Array[i,j]=Array[i,j-1];
                Array[i,j-1]=x;
            }
        }
        }
        for(int j=0;j<Array.GetLength(1);j++)
        {
            Next();
        }
    }
    for(int i = 0; i < Array.GetLength(0);i++)
    {
        int x=Array[i,0];

        for(int j=0;j<Array.GetLength(1);j++)
        {
            Console.Write(Array[i,j]+" ");
        }
        Console.WriteLine();
    }
}

void Number2()
{
    int [,] Array= new int [4,4];
    int min=0;
    int x=0;
    for(int i=0;i<Array.GetLength(0);i++)
    {
        int sum=0;
        for(int j=0;j<Array.GetLength(1);j++)
        {
            Array[i,j]=new Random().Next(1,10);
            Console.Write(Array[i,j]+" ");
            sum=sum+Array[i,j];
        }
        x=i;
        min=sum;
        Console.WriteLine();
    }
    for(int i=0;i<Array.GetLength(0);i++)
    {
        int sum=0;
        for(int j=0;j<Array.GetLength(1);j++)
        {
            sum=sum+Array[i,j];
        }
        if(sum<min)
        {
            min=sum;
            x=i;
        }
    }
    Console.WriteLine($"Номер строки: {x}. Сумма: {min}");
}

void Number3()
{
    int [,] Array1=new int [2,2];
    for(int i = 0;i<Array1.GetLength(0);i++)
    {
        for(int j = 0; j<Array1.GetLength(1);j++)
        {
            Array1[i,j]=new Random().Next(1,10);
            Console.Write(Array1[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    int [,] Array2=new int [2,2];
    for(int i = 0;i<Array2.GetLength(0);i++)
    {
        for(int j = 0; j<Array2.GetLength(1);j++)
        {
            Array2[i,j]=new Random().Next(1,10);
            Console.Write(Array2[i,j]+" ");
        }
        Console.WriteLine();
    }
    Console.WriteLine();
    Console.WriteLine("Произведение матриц равна: ");
    int [,] Array=new int [2,2];
    Array[0,0]=Array1[0,0]*Array2[0,0]+Array1[0,1]*Array2[1,0];
    Array[0,1]=Array1[0,0]*Array2[0,1]+Array1[0,1]*Array2[1,1];
    Array[1,0]=Array1[1,0]*Array2[0,0]+Array1[1,1]*Array2[1,0];
    Array[1,1]=Array1[1,0]*Array2[0,1]+Array1[1,1]*Array2[1,1];
    for(int i = 0;i<Array.GetLength(0);i++)
    {
        for(int j = 0; j<Array.GetLength(1);j++)
        {
            Console.Write(Array[i,j]+" ");
        }
        Console.WriteLine();
    }
}
void Number5()
{
    int [,] Array=new int [4,4];
    for(int i = 0;i<Array.GetLength(0);i++)
    {
        int x=1;
        int x1=12;
        int x2=16;
        int x3=10;
        for(int j = 0; j<Array.GetLength(1);j++)
        {
            if(i==0)
            {
                Array[i,j]=x;
                x++;
            Console.Write("0"+Array[i,j]+" ");
            }
            else if(i==1)
            {
                if(j!=Array.GetLength(1)-1)
                {
                    Array[i,j]=x1;
                    x1++;
                    Console.Write(Array[i,j]+" ");
                }
                else
                {
                    Array[i,j]=5;
                    Console.Write("0"+Array[i,j]+" ");
                }
            }
            else if(i==2)
            {
                if((j==1)||(j==2))
                {
                    Array[i,j]=x2;
                    x2=x2-1;
                Console.Write(Array[i,j]+" ");
                }
                else if(j==0)
                {
                    Array[i,j]=11;
                    Console.Write(Array[i,j]+" ");
                }
                else if(j==3)
                {
                    Array[i,j]=6;
                    Console.Write("0"+Array[i,j]+" ");
                }
            }
            else if(i==3)
            {
                Array[i,j]=x3;
                x3=x3-1;
                if(x3==9)
                {
                    Console.Write(Array[i,j]+" ");
                }
                else
                {
                    Console.Write("0"+Array[i,j]+" ");
                }
            }
        }
        Console.WriteLine();
    }
}
Console.WriteLine("Задание 54");
Number1();
Console.WriteLine();
Console.WriteLine("Задание 56");
Number2();
Console.WriteLine();
Console.WriteLine("Задание 58");
Number3();
Console.WriteLine();
Console.WriteLine("Задание 62");
Number5();
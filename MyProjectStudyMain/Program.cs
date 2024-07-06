/*using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {
        //Математические операции
        *//*//Console.ReadKey();
        Console.Write( "Hello World!\n\n" );
        Console.WriteLine( "Hello World!1" );
        Console.WriteLine( "Hello World!2" );
        Console.ReadLine();

        Console.Write( "Enter number with point: " );
        //var user_input = Convert.ToDouble(Console.ReadLine());
        float user_input = float.Parse( Console.ReadLine() );

        float result = user_input + 10f;

        Console.Write( "Введите радиус круга: " );
        double radius = Convert.ToInt16( Console.ReadLine() );
        double area = Math.PI * Math.Pow( radius, 2 );
        Console.WriteLine( "Площадь круга с радиусом {0} равна {1}", radius, area );*//*



        //Циклы
        *//*for ( int i = 0; i <= 10; i++ )
        {
            Console.WriteLine( i );
        }

        int j = 20;
        while ( j > 10 )
        {
            Console.WriteLine( j );
            j--;
        }*//*



        //Циклы с условием
        *//*Console.Write( "Enter your password: " );
        bool HasCar = true;
        while ( HasCar )
        {
            string end = Console.ReadLine();
            if ( end == "end" )
            {
                Console.WriteLine( "Correct" );
                break;
            }
            else
            {
                Console.Write( "Wrong passowrd. Please, enter again: " );
            }
        }*//*


        //Массивы
        *//*short[] numbers = new short[ 10 ];
        Random random = new Random();
        short sum = 0;

        for ( byte i = 0; i < numbers.Length; i++ )
        {
            numbers[ i ] = Convert.ToInt16( random.Next( -15, 15 ) );
            Console.WriteLine( "El: " + numbers[ i ] );
            sum += numbers[ i ];
        }
        Console.WriteLine( sum );

        char[,] symbols = new char[ 2, 3 ];
        symbols[ 0, 0 ] = 'H';
        Console.WriteLine( symbols[ 0, 0 ] );

        int[,] nums = new int[,]
        {
            { 4, 6, 7 },
            { 5, 7, 3 },
            { 3, 3, 2 }
        };

        nums[ 1, 2 ] = 56;*//*

        //Двумерный массив
        *//*short[,] nums = {
            { 5, 6, 6},
            { 55, 62, 61},
            { 50, 69, 64} };

        foreach ( short el in nums )
        {
            Console.WriteLine( el );
        }

        //Динамический массив
        List<int> numbers = new List<int>() { 4, 6, 7 };
        numbers.Add( 40 );
        numbers.Add( 100 );
        numbers.Add( 5 );
        numbers.Remove( 5 );

        foreach ( int el in numbers )
        {
            Console.WriteLine( el );
        }*//*


        //Функкции начало
        *//*Print( "Hello" );
        string words = "Hello world";
        Print( words );

        Summa( 5, 6 );
        int a = 5, b = 6;
        Summa( a, b );

        Print( Convert.ToString( Summa2( 3, 4 ) ) );
        int res1 = Summa2( 5, 6 );
        Print( res1.ToString() );
    }
    //Функции
    public static void Print( string word )
    {
        Console.WriteLine( word );

    }
    public static void Summa( int x, int y )
    {
        int res = x + y;
        Print( $"Result = {res}" );
    }
    public static int Summa2( int a, int b )
    {
        return a + b; *//*
    }
}*/

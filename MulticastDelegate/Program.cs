namespace MulticastDelegate
{
    public delegate void Sampledelegate();
    class Program
    {
        public static void Main(string[] args)
        {
            //instance of delegate
            //Sampledelegate DelObj = new Sampledelegate(SampleMethod1);
            //DelObj();

            //Cretae Multiple Instance Of delgates
            Sampledelegate Del1,Del2,Del3,Del4;
            Del1 = new Sampledelegate(SampleMethod1);  // pointing to methods
            Del2 = new Sampledelegate(SampleMethod2);
            Del3 = new Sampledelegate(SampleMethod3);

            Del4 = Del1 + Del2 + Del3;      // adding all three delgates togethers
            Del4();
            Console.WriteLine("\n");

            // ANother Example
            Sampledelegate Del = new Sampledelegate(SampleMethod1);
            Del += SampleMethod2;
            Del += SampleMethod3;
            Del();

            Console.ReadLine();
        }
        public static void SampleMethod1()
        {
            Console.WriteLine("SampleMethod1 Invoked");
        }
        public static void SampleMethod2()
        {
            Console.WriteLine("SampleMethod2 Invoked");

        }
        public static void SampleMethod3()
        {
            Console.WriteLine("SampleMethod3 Invoked");
        }


    }
}
namespace MulticastDelegate
{
    public delegate int Sampledelegate();
    public delegate void SampleDelegate2(out int integer);
    class Program
    {
        public static void Main(string[] args)
        {
            //instance of delegate
            Sampledelegate Del = new Sampledelegate(SampleMethod1);
            Del += SampleMethod2;
            int DelgateReturnValue = Del();
            Console.WriteLine(DelgateReturnValue);
            Console.WriteLine("\n");

            // another Example
            SampleDelegate2 Del2 = new SampleDelegate2(SampleMethod3);
            Del2 += SampleMethod4;

            int DelegateReturnValuewithOutparameter = -1;
            Console.WriteLine("DelegateReturnValuewithOutparameter = {0}", DelegateReturnValuewithOutparameter);
            Console.ReadLine();
        }
        public static int SampleMethod1()
        {
            return 1;
        }
        public static int SampleMethod2()
        {
            return 2;
        }

        //By using Out parameters
        public static void SampleMethod3(out int Number)
        {
            Number = -1;
        }
        public static void SampleMethod4(out int Number)
        {
            Number = -2;
        }


    }
}
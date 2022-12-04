namespace ConsoleApp6
{
    internal class Program
    {        
        static void Main(string[] args)
        {
            //Dátumkezelés alapfok
            DateTime dateTime = DateTime.Now;

            int day = dateTime.Day;
            //Hibakezelés
            try
            {
                if (day > 21)
                {
                    Console.WriteLine("Nagyobb");
                }
                else
                {
                    throw new Exception();
                }
            }
            catch (Exception)
            {
                Console.WriteLine("Kisebb");
            }

            Console.WriteLine(dateTime.ToString());
            Console.WriteLine(day.ToString());

            //Sok if helyett ez inkább :)
            switch (day)
            {
                case 20:
                    Console.WriteLine("20");
                    break;
                case 26:
                    Console.WriteLine("26!");
                    break;
                default:
                    break;
            }
            int a = 10;
            int b = 20;
            Console.WriteLine(Tutorial.Fizetendo(a, b));

            string laci = " Laci ";
            string be = Console.ReadLine();

            if (laci.Trim().ToLower() == be.Trim().ToLower())
            {
                Console.WriteLine("Fasza");
            }
            else
            {
                Console.WriteLine("nem fasza");
            }
        }
    }

    public class Tutorial
    {
        public static double Fizetendo(double adosav, double alap)
        {
            double visszateresi = adosav * alap;
            return visszateresi;
        }
    }
}
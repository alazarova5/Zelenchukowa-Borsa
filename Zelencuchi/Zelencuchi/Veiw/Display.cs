using System;
using System.Collections.Generic;
using System.Text;

namespace Zelencuchi.Veiw
{
   public class Display
    {
        public Display()
        {
            this.N = 0.0;
            this.M = 0.0;
            this.KgN = 0;
            this.KgM = 0;
            this.TotalPrice = 0.0;
            this.GetValues();
        }
        public double N { get; set; }
        public double M { get; set; }
        public int KgN { get; set; }
        public int KgM { get; set; }
        public double TotalPrice { get; set; }

        public void GetValues()
        {
            Console.WriteLine("Cena na kg za zelencichi:");
            N = double.Parse(Console.ReadLine());
            Console.WriteLine("Cena na kg za plodowe:");
            M = double.Parse(Console.ReadLine());
            Console.WriteLine("Obshta cena na kg za zelencichi:");
            KgN = int.Parse(Console.ReadLine());
            Console.WriteLine("Obshta cena na kg za plodowe:");
            KgM = int.Parse(Console.ReadLine());
        }
       
    }
}

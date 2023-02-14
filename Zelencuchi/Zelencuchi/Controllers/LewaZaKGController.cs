using System;
using System.Collections.Generic;
using System.Text;
using Zelencuchi.Model;
using Zelencuchi.Veiw;

namespace Zelencuchi.Controllers
{
    public class LewaZaKGController
    {
        private LewaZaKG lewaZaKG;
        private Display display;

        public LewaZaKGController()
        {
            display = new Display();
            lewaZaKG = new LewaZaKG(display.N, display.M, display.KgN, display.KgM);
            Console.WriteLine(display.TotalPrice = lewaZaKG.TurningEuro());

        }
    }
}

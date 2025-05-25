using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    public class Kişi
    {
        public string Ad { get; set; }
        public string SoyAdı { get; set; }

        public void Tanıtma()
        {
            Console.WriteLine("Merhaba Ben " + Ad + " " + SoyAdı);
        }

    }
}

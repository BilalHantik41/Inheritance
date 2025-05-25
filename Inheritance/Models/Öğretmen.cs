using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Öğretmen : Kişi
    {
        public int Maaş { get; set; }

        public void ÖğretmenİşSözleşmesi()
        {
            Console.WriteLine("********** Öğretmen İş Sözleşmesi Bilgileri **********");
            Console.WriteLine("Öğretmen Adı: " + Ad);
            Console.WriteLine("Öğretmen Soyadı: " + SoyAdı);
            Console.WriteLine("Öğretmen Maaş: " + Maaş);
        }
    }
}

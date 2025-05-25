using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance.Models
{
    internal class Öğrenci : Kişi
    {
        public string ÖğrenciNumarası { get; set; }

        public void ÖğrenciKartı()
        {
            Console.WriteLine("********** Öğrenci Kartı Bilgileri **********");
            Console.WriteLine("Ad: " + Ad);
            Console.WriteLine("Soyadı: " + SoyAdı);
            Console.WriteLine("Öğrenci Numarası: " + ÖğrenciNumarası);
        }
    }
}

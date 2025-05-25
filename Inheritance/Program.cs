using System.ComponentModel;
using Inheritance.Models;

Öğrenci yeniÖğrenci = new Öğrenci()
{   
    Ad = "ALİ",
    SoyAdı = "VELİ",
    ÖğrenciNumarası = "14"


};


Öğretmen yeniÖğretmen = new Öğretmen()
{
    Ad = "Ayşe",
    SoyAdı = "Fatma",
    Maaş = 311411
};


Console.WriteLine("************************************************");
yeniÖğrenci.Tanıtma();
Console.WriteLine("************************************************");
yeniÖğrenci.ÖğrenciKartı();
Console.WriteLine("************************************************");
yeniÖğretmen.ÖğretmenİşSözleşmesi();
Console.WriteLine("************************************************");

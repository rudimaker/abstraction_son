using abstraction_son;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abstraction_son
{
    public interface IGorev
    {
        public void Gorev();

        public void Info();
    }



    public class Company
    {

        public string Name { get; set; }
        public string Surname { get; set; }

        public string Departman { get; set; }



    }
}


public class Software : Company, IGorev
{

    public Software(string name, string surname, string departman)
    {
        Departman = departman;
        Name = name;
        Surname = surname;
    }

    

    public void Info()
    {
        Console.WriteLine("Adım "+Name+"Soyadım" +" "+Surname+"  "+"Departmanım"+Departman);
    }

    public void Gorev()
    {
        Console.WriteLine("Ben yazılımcıyım");
    }
}

public class Manager : Company, IGorev
{

    public Manager(string name, string surname, string departman)
    {
        Departman = departman;
        Name = name;
        Surname = surname;
    }



    public void Info()
    {
        Console.WriteLine("Adım " + Name + "Soyadım" + " " + Surname + "  " + "Departmanım" + Departman);
    }

    public void Gorev()
    {
        Console.WriteLine("Ben yöneticiyim");
    }
}



//Düşünün ki bir şirketin çalışanlarını temsil eden bir program yazıyorsunuz.

//Her çalışan için ad, soyad, departman gibi ortak özellikler bulunmaktadır

//Ancak her çalışanın görevi (pozisyonu) farklı olabilir (Örneğin, Yazılım Geliştirici, Proje Yöneticisi, Satış Temsilcisi).

//Gorev metodunu çağırdığımızda her çalışan kendi yaptığı işi konsol ekranında söyleyecek.

//Örneğin

//Hasan Çıldırmış şirketin Proje yönetcisi, kendisi üzerinden Gorev() abstract metodu çağırıldığında konsol ekranında

//" Proje yöneticisi olarak çalışıyorum. " yazdırılmasını istiyoruz.
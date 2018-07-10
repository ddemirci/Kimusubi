using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace Kimusubi
{
    class Ogrenci
    {
        public string Name;
        public string Surname;
        public DateTime DogumTarihi;
        public string Cinsiyet;
        public string KanGrubu;
        public string Email;
        public string Adres;
        public Kusaklar Kusak;
        public Image PersonalImage;
        
        public Ogrenci(string name, string surname, DateTime dogumTarihi,string cinsiyet, string kanGrubu,string email, string adres )
        {
            this.Name = name;
            this.Surname = surname;
            this.DogumTarihi = dogumTarihi;
            this.Cinsiyet = cinsiyet;
            this.KanGrubu = kanGrubu;
            this.Email = email;
            this.Adres = adres;
            this.Kusak = Kusaklar.Kyu7;

        }

    }
}

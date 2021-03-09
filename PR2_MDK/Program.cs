using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR2_MDK
{
    struct Employee
    {
        public string name;
        public int age;
        public string dolzhnost;
        public void GetEmployee()
        {
            Console.WriteLine($"{dolzhnost}: {name}, возраст: {age}");
        }
    }
    struct Skidka
    {
        public string tip;
        public int procent;
        public string period;
        public void GetSkidka()
        {
            Console.WriteLine($" Скидка {tip} {procent} {period}");
        }
    }
    enum RazmerZala
    {
        Большой,
        Средний,
        Маленький
    }
    enum Kinoteatrs
    {
        ЧасКино,
        Наутилус,
        МегаФильм,
        ЦентральныйКинотеатр
    }
    class Kinoteatr
    {
        public string naimenovanie;
        public string adres;
        public int kol_zalov;
        public long telefon;
        public Kinoteatr() { naimenovanie = "Пусто"; adres = "Пусто"; kol_zalov = 0; telefon = 0; }
        public Kinoteatr(string n, string a, int k, long t) { naimenovanie = n; adres = a; kol_zalov = k; telefon = t; }
        public void GetKinoteatr()
        {
            Console.WriteLine($"Кинтеатр {naimenovanie}, адрес: {adres}, количество залов: {kol_zalov}, телефон {telefon}");
        }

    }
    class Kinozal
    {
        public string naimenovanie;
        public string razmer;
        public int kol_mest;
        public Kinozal() { naimenovanie = "Пусто"; razmer = "Пусто"; kol_mest = 0; }
        public Kinozal(string n, string r, int k) { naimenovanie = n; razmer = r; kol_mest = k; }
        public void GetKinozal()
        {
            Console.WriteLine($"Зал: {naimenovanie}, размер: {razmer}, количество мест: {kol_mest}");
        }
    }
    class Film
    {
        public string naimenovanie;
        public string zhanr;
        public string rezhyser;
        public int dlitelnost;
        public Film() { naimenovanie = "Пусто"; zhanr = "Пусто"; rezhyser = "Пусто"; dlitelnost = 0; }
        public Film(string n, string z, string r, int d) { nazvanie = n; zhanr = z; rezhyser = r; dlitelnost = d; }
        public void GetFilm()
        {
            Console.WriteLine($"Фильм: {nazvanie}, жанр: {zhanr}, режисёр: {rezhyser}, длительность: {dlitelnost}");
        }

    }
    class Seans
    {
        public string zal;
        public string film;
        public string date;
        public string vremya;
        public Seans() { zal = "Пусто"; film = "Пусто"; date = "00.00.00"; vremya = "00.00"; }
        public Seans(string z, string f, string d, string v) { zal = z; film = f; date = d; vremya = v; }
        public void GetSeans()
        {
            Console.WriteLine($"{film} в {zal} зале, {date} в {vremya}");
        }
    }
    class Bilet
    {
        public string seans;
        public int ryad;
        public int mesto;
        public int tsena;
        public Bilet() { seans = "Пусто"; ryad = 0; mesto = 0; tsena = 0; }
        public Bilet(string s, int r, int m, int t) { seans = s; ryad = r; mesto = m; tsena = t; }
        public void GetBilet()
        {
            Console.WriteLine($"Билет на {seans}, ряд: {ryad}, место: {mesto}, цена: {tsena}");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

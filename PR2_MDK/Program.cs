using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PZ_MDK
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
        public string director;
        public Kinoteatr() { naimenovanie = "Пусто"; adres = "Пусто"; kol_zalov = 0; telefon = 0; director = "Пусто"; }
        public Kinoteatr(string n, string a, int k, long t, string d) { naimenovanie = n; adres = a; kol_zalov = k; telefon = t; director = d; }

        public void GetKinoteatr()
        {
            Console.WriteLine($"Кинтеатр {naimenovanie}, директор: {director} адрес: {adres}, количество залов: {kol_zalov}, телефон: {telefon}, директор: {director}");
        }
        public void AddZal(int a)
        {
            kol_zalov += a;
            Console.WriteLine($"Теперь в кинотеатре {naimenovanie} {kol_zalov} зала(ов)");
        }
        public void DelZal(int a)
        {
            if (kol_zalov < a)
            {
                Console.WriteLine("Количество залов меньше введенного числа");
            }
            else
            {
                kol_zalov -= a;
                Console.WriteLine($"Теперь в кинотеатре {naimenovanie} {kol_zalov} зала(ов)");
            }
        }
    }
    class Kinozal
    {
        public string naimenovanie;
        public string razmer;
        public int kol_mest;
        public string proektor;
        public int kol_kolonok;
        public Kinozal() { naimenovanie = "Пусто"; razmer = "Пусто"; kol_mest = 0; proektor = "Пусто"; kol_kolonok = 0; }
        public Kinozal(string n, string r, int k, string p, int kol ) { naimenovanie = n; razmer = r; kol_mest = k; proektor = p; kol_kolonok = kol; }
        public void GetKinozal()
        {
            Console.WriteLine($"Зал: {naimenovanie}, размер: {razmer}, количество мест: {kol_mest}, проектор: {proektor}, количество звуковых установок {kol_kolonok}");
        }
        public void AddKolonoky(int a)
        {
            kol_kolonok += a;
            Console.WriteLine($"Теперь в кинонозале {naimenovanie} количество колонок равно {kol_kolonok}");
        }
        public void DelKoloky(int a)
        {
            if (kol_kolonok < a)
            {
                Console.WriteLine("Количество колонок меньше введенного числа");
            }
            else
            {
                kol_kolonok -= a;
                Console.WriteLine($"Теперь в кинонозале {naimenovanie} количество колонок равно {kol_kolonok}");
            }
        }
    }
    class Film
    {
        public string naimenovanie;
        public string zhanr;
        public string rezhyser;
        public int dlitelnost;
        public int vozrast;
        public Film() { naimenovanie = "Пусто"; zhanr = "Пусто"; rezhyser = "Пусто"; dlitelnost = 0; vozrast = 0; }
        public Film(string n, string z, string r, int d, int v) { naimenovanie = n; zhanr = z; rezhyser = r; dlitelnost = d; vozrast = v; }
        public void GetFilm()
        {
            Console.WriteLine($"Фильм: {naimenovanie}, жанр: {zhanr}, режисёр: {rezhyser}, длительность: {dlitelnost}, возростное ограничение {vozrast}");
        }

    }
    class Seans
    {
        public string zal;
        public string film;
        public string date;
        public string vremya;
        public int koefitsient;
        public Seans() { zal = "Пусто"; film = "Пусто"; date = "00.00.00"; vremya = "00.00"; koefitsient = 1; }
        public Seans(string z, string f, string d, string v, int k) { zal = z; film = f; date = d; vremya = v; koefitsient = k; }
        public void GetSeans()
        {
            Console.WriteLine($"{film} в {zal} зале, {date} в {vremya}, коэффициент к ценен: {koefitsient}");
        }
        public void AddKoef(int a)
        {
            koefitsient += a;
            Console.WriteLine($"Теперь коэффициент равен {koefitsient}");
        }
        public void DelKoef(int a)
        {
            if (koefitsient < a)
            {
                Console.WriteLine("Коеффициент меньше введенного числа");
            }
            else
            {
                koefitsient -= a;
                Console.WriteLine($"Теперь коэффициент равен {koefitsient}");
            }
        }
    }
    class Bilet
    {
        public int id;
        public string seans;
        public int ryad;
        public int mesto;
        public int tsena;
        public Bilet() { id = 0; seans = "Пусто"; ryad = 0; mesto = 0; tsena = 0; }
        public Bilet(int i, string s, int r, int m, int t) { id = 0; seans = s; ryad = r; mesto = m; tsena = t; }
        public void GetBilet()
        {
            Console.WriteLine($"Билет №{id} на {seans}, ряд: {ryad}, место: {mesto}, цена: {tsena}");
        }
        public void AddTsena(int a)
        {
            tsena += a;
            Console.WriteLine($"Теперь цена равна равен {tsena}");
        }
        public void DelTsena(int a)
        {
            if (tsena < a)
            {
                Console.WriteLine("Цена меньше введенного числа");
            }
            else
            {
                tsena -= a;
                Console.WriteLine($"Теперь цена равна {tsena}");
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}

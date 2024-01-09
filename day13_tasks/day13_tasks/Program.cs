using System.Diagnostics.Metrics;
using System.Drawing;
using System.Text;
using static System.Net.Mime.MediaTypeNames;

namespace day13_tasks;

class Program
{
    static void Main(string[] args)
    {
        //Verilmiş email dəyərinin domain hissəni qaytaran metod
        //  (elchin@code.edu.az email - i daxil edilsə code.edu.az hiss'sini qaytarmalıdır)
        string str = "elchin@code.edu.az";
        Console.WriteLine(domain(str));

        // Verilmiş yazının yalnız hərflərdən ibarət olub olmadığını tapan metod

        string text = "salam  menim 18 yasim var.";
        Console.WriteLine(check_letter(text));

        //Verilmiş yazının ilk hərfini böyük qalanlarını kiçik edib qaytaran metod
        // (Misaçün "saLAm nEceSen" yazısı daxil edilsə metoddan "Salam necesen" return olmalıdır)

        string text1 = "salaM MeNiM AdIm ELmARDIR";
        Console.WriteLine(change_first_bigger(text1));
        //Verilmiş fullnamelər siyahısından name-lər siyahısı düzəldən metod
        // (ad soyadlar siyahısındaki adları kəsib yeni bir arraye doldurub qaytarmalıdır)
        string[] fullName = new string[] { "elmar qarayev", "cavid quliyev", "ilham ibrahimov", "kenan tagiyev" };

        string[] temp = names(fullName);
        for (int i = 0; i < temp.Length; i++)
        {
            Console.WriteLine(temp[i]);
        }
        //Doğum tarixinizi daxil etdiyinizdə sizə yaşınızı qaytaran metod
        //void funksiya ile
        Birthday();
        // return type string  olan bir funksiya ile
        Console.WriteLine(Birthdayt("03 15  2005"));


        Console.ReadLine();
    }

    static string domain(string str)
    {
        return str.Substring(str.IndexOf('@')+1);

    }
    static bool check_letter(string str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            if (char.IsDigit(str[i])) return false;
        }
        return true;
    }
    static string change_first_bigger(string str)
    {
        if (string.IsNullOrWhiteSpace(str))
        {
            return str;
        }
       
        StringBuilder result = new StringBuilder(str);
        result[0] = char.ToUpper(result[0]);
        for (int i = 1; i < str.Length; i++)
        {
            if (char.IsUpper(str[i]))
            {
                result[i] = char.ToLower(str[i]);
            }
        }
        return result.ToString();
    }
    static string[] names(string[] str)
    {
        for (int i = 0; i < str.Length; i++)
        {
            str[i].Trim();
            str[i] = str[i].Substring(0, str[i].IndexOf(' '));
        }
        return str;

    }
    static void Birthday()
    {
        string birth;
        DateTime date;
        do
        {
            Console.WriteLine("dogum tarixinizi qeyd edin:");
            birth = Console.ReadLine();

        } while (!DateTime.TryParse(birth, out date));

        var diff =DateTime.Now.Year-date.Year;
        if (diff < 0)
        {
            Console.WriteLine("siz hele dogulmayibsiniz");
        }
        else
        {
            Console.WriteLine( $"sizin {diff} yasiniz var");
        }   
    }

    static string Birthdayt(string str)
    {
        
        DateTime date;
        if(DateTime.TryParse(str,out date))
        {
            int diff = DateTime.Now.Year - date.Year;
            if (diff < 0)
            {
                return "siz hele dogulmayibsiniz!";
            }
            else
                return $"sizin {diff.ToString()} yasiniz var";
        }
        else
        {
            return "yanlisidir zehmet olmasa duzgun daxil edin!";
        }

    }

}


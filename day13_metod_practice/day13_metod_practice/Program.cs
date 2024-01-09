namespace day13_metod_practice;

class Program
{
    static void Main(string[] args)
    {

        int[] arr = new int[] { 3, 6, 7 };
        int[] arr1 = new int[5];
        Array.Copy(arr, 0, arr1, 2, 2);

        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);

        }

        arr.CopyTo(arr1, 2);
        for (int i = 0; i < arr1.Length; i++)
        {
            Console.WriteLine(arr1[i]);

        }

        int[] array = new int[] { 56, 34, 8, 1, 67 };
        Array.Sort(array);
        Array.Reverse(array);
        Array.Resize(ref array, 2);
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);

        }

        int[] nums = new int[] { 2, 3, 4, 5, 6, 7, 5, 8 };

        Console.WriteLine(Array.IndexOf(nums, 12));
        Console.WriteLine(Array.IndexOf(nums, 3));
        Console.WriteLine(Array.LastIndexOf(nums, 5));



        string temp = " salam neterisiz ? PB302 ";

        Console.WriteLine(temp.LastIndexOf('a'));
        Console.WriteLine(temp.IndexOf('a'));
        Console.WriteLine(temp.ToLower());
        Console.WriteLine(temp.ToUpper());
        Console.WriteLine(temp.Replace(' ','q'));

        Console.WriteLine(temp.Contains("salam"));
        Console.WriteLine(temp.Contains(" sa"));
        Console.WriteLine(temp.EndsWith(' '));
        Console.WriteLine(temp.EndsWith('1'));
        Console.WriteLine(temp.StartsWith(' '));
        Console.WriteLine(temp.StartsWith('s'));
        Console.WriteLine(temp.Trim());



        var newtemp = temp.Substring(0);
        newtemp = temp.Substring(2, 6);
        newtemp = temp.Substring(temp.IndexOf('s'), 5);
        newtemp = temp.Substring(temp.IndexOf('r'));

        for (int i = 0; i < newtemp.Length; i++)
        {
            Console.Write(newtemp[i]);

        }

        var spl = temp.Split(' ');
        for (int i = 0; i < spl.Length; i++)
        {
            Console.WriteLine(spl[i]);

        }
        var jo = String.Join('0', spl);
        Console.WriteLine(jo);



        char let = 'A';

        Console.WriteLine(char.ToUpper(let));
        Console.WriteLine(char.ToLower(let));
        Console.WriteLine(char.IsDigit(let));
        Console.WriteLine(char.IsUpper(let));
        Console.WriteLine(char.IsLetter(let));
        Console.WriteLine(char.IsLetterOrDigit(let));
        Console.ReadLine();
    }
}


namespace TaskStringMEthod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string name = string.Empty;
            //string name2 = "";
            //Console.WriteLine(name == name2);


            //string name = "Murad Eliyev";
            //Console.WriteLine(name.StartsWith('M'));

            //string name = "Murad ALiyev";
            //Console.WriteLine(name.EndsWith('m'));


            //string name = "Murad aliyev";
            //Console.WriteLine(name.StartsWith("rad"));

            //string name = ("Murad Aliyev");
            //Console.WriteLine(name.Contains("Ali"));
            //Console.WriteLine(name);
            //Console.WriteLine(name.IndexOf('M'));
            //Console.WriteLine(name.Replace('a', 'h'));

            //Console.WriteLine(name.Trim());
            //Console.WriteLine(name);
            string myString = "Men proqramlasdirmani oyrenmek isteyirem.";
            //StartWith, Endwith:
            if (myString.StartsWith("Men"))
            {
                Console.WriteLine("true");
            }
            if (myString.EndsWith("irem"))
            {
                Console.WriteLine("true");
            }

            //Length:
            Console.WriteLine("myStringin uzunlugu: " + myString.Length);

            //IndexOf, LastIndexOf:
            int indexOfGun = myString.IndexOf("gun");
            Console.WriteLine("myStringde 'gun' sozu ilk defe " + indexOfGun + ". indeksde tapildi.");
            int lastIndexOfS = myString.LastIndexOf("s");
            Console.WriteLine("myStringde 's' herfi son defe " + lastIndexOfS + ". indeksde tapildi.");

            //Replace:
            string myNewString = myString.Replace("Men", "O");
            Console.WriteLine("myStringdə 'Men' sozu 'O' ilə deyishdirildi: " + myNewString);

            //Remove:
            string myNewString2 = myString.Remove(0, 3);
            Console.WriteLine("myStringin ilk 3 herfi silindi: " + myNewString2);

            //Substring:
            string mySubstring = myString.Substring(20, 7);
            Console.WriteLine("myStringin 20-ci indeksinden bashlayaraq 7 herfi: " + mySubstring);

            //Trim, Split, Join:
            string myStringTrimmed = myString.Trim();
            Console.WriteLine("myStringin bas ve sonundaki bosluqlar silindi: " + myStringTrimmed);
            string[] myStringArray = myString.Split(' ');
            Console.WriteLine("myString sozler arasinda boshluqdan ayirildi:");
            foreach (string word in myStringArray)//bu alinmadi
            {
                Console.WriteLine(word);
            }
            string myStringJoined = String.Join("-", myStringArray);
            Console.WriteLine("myStringdeki sozler '-' ilə birlashdirildi: " + myStringJoined);

            //Compare:
            string myString2 = "Men proqramlasdirmani oyrenmek isteyirem.";
            int result = String.Compare(myString, myString2);
            if (result == 0)
            {
                Console.WriteLine("myString ve myString2 eynidir.");
            }
            else if (result < 0)
            {
                Console.WriteLine("myString myString2-dən kicikdir.");
            }
            else
            {
                Console.WriteLine("myString myString2-dən boyukdur.");
            }

            //IsNullOrEmpty(), IsNUllOrWhiteSpace():
            if (String.IsNullOrEmpty(myString))
            {
                Console.WriteLine("myString null və ya bosdur.");
            }
            if (String.IsNullOrWhiteSpace(myString))
            {
                Console.WriteLine("myString null, bos və ya yalnizca bosluqlardan ibaretdir.");
            }

        }
    }
}



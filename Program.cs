using System;

class Program
{
    public static void Main()
    {
    string m1 = "\nType a four-digit number. " +
                "Type '`' anywhere in the text to quit:\n";
    char ch;
    ConsoleKeyInfo x;
    string number = "";
    string fourdigitnumber = "";
    int i = 0;

    Console.WriteLine(m1);
    do
        {
        x = Console.ReadKey();
        try
        {
            ch = x.KeyChar;
            number = number + ch;
            if (number.Length % 4 == 0 && i == 0) 
            {
                fourdigitnumber = number; 
                i++;
            }
            if (number.Length % 4 == 0 && i > 0) {
                if (fourdigitnumber != number) 
                { 
                    Console.WriteLine(" Wrong " + i + " " + fourdigitnumber + " " + number); 
                    number = "";
                }
                else 
                { 
                    Console.WriteLine(" Right " + i); 
                    fourdigitnumber = number; 
                    number = "";
                }
                i++;}
        }
        catch (OverflowException e)
        {
            Console.WriteLine(e.Message);
            ch = Char.MinValue;
        }
        } while (ch != '`');
    }
}
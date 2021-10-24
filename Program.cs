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
    int correctSeriesCounter = 0;

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
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(" Wrong " + i + ", " + fourdigitnumber + " != " + number); 
                    Console.ResetColor();
                    number = "";
                    correctSeriesCounter = 0;
                }
                else 
                { 
                    correctSeriesCounter++;
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(" Right " + i + ", " + correctSeriesCounter + " correct");
                    Console.ResetColor();
                    string incremented = (int.Parse(fourdigitnumber.Substring(0, 1).Replace("9","-1")) + 1).ToString() +
                                   (int.Parse(fourdigitnumber.Substring(1, 1).Replace("9","-1")) + 1).ToString() +
                                   (int.Parse(fourdigitnumber.Substring(2, 1).Replace("9","-1")) + 1).ToString() +
                                   (int.Parse(fourdigitnumber.Substring(3, 1).Replace("9","-1")) + 1).ToString();
                    fourdigitnumber = incremented;
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
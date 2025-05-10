using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {

    }
    public void DecimalConversion(int number)
    {
        char[] hexadecimalValue = new char[]
        {
            '0','1','2','3','4','5','6','7','8','9','A','B','C','D',
            'E','F','G','H','I','J','K','L','M','N','O','P','Q','R','S','T','U','V','W','X','Y','Z'
        };

        var binary = number;
        var binaryResult = new StringBuilder();


        var hexadecimal = number;
        var hexadecimalResult = new StringBuilder();

        var octal = number;
        var octalResult = new StringBuilder();
        while (binary > 0)
        {
            if (binary % 2 == 0)
                binaryResult.Insert(0, "0");
            else binaryResult.Insert(0, "1");
            binary /= 2;
        }
        while (octal > 0)
        {
            octalResult.Insert(0, (octal % 8).ToString());
            octal /= 8;
        }

        while (hexadecimal > 0)
        {
            hexadecimalResult.Insert(0, hexadecimalValue[hexadecimal % 16]);
            hexadecimal /= 16;
        }


        Console.WriteLine($"Hexadecimal: {hexadecimalResult}\nBinary: {binaryResult}\nOctal: {octalResult}");


    }
}
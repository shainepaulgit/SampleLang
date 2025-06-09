using System.Linq;
using System.Text;

internal class Program
{
    private static void Main(string[] args)
    {
        var booked = new List<string>();
        do
        {
            Console.Write("Book Seat#: ");
            var seatCode = Console.ReadLine();
            booked.Add(seatCode);
            BookSeat(booked);
        }
        while (true);
       
    }

    public static void BookSeat(List<string> booked)
    {
        var codeLetter = new[]
        {
            'A','B','C','D','E','F','G','H','I','J','K','L'
        };

      
        var listCodes = new string[12][];


        for(int r = 0; r < codeLetter.Count(); r++)
        {
            listCodes[r] = new string[10];
            for (int c = 0; c < 10; c++)
            {
                listCodes[r][c] = $"{codeLetter[r]}{(c+1).ToString("D2")}";
            }
        }

        for(int r = 0; r< codeLetter.Count(); r++)
        {
            for(int c = 0; c < 10; c++)
            {
                if (booked.Any(x => x == listCodes[r][c]))
                    Console.Write("/// ");
                else
                    Console.Write(listCodes[r][c] + " ");
            }
            Console.WriteLine();
        }
    }









    public static void PalindromeWord(string word)
    {
        var palindromeWords = new List<string>();
        for (int i = 0; i < word.Length; i++)
        {
            for (int t = i + 1; t < word.Length; t++)
            {
                if (word[i] == word[t])
                {
                    int start = i;
                    int end = t;
                    var isPalindrome = true;
                    var wordPalindrome = new StringBuilder();
                    while (start < end)
                    {
                        if (word[start] != word[end])
                        {
                            isPalindrome = false;
                        }

                        start++;
                        end--;
                    }
                    if (isPalindrome)
                    {
                        for (int s = i; s <= t; s++)
                        {
                            wordPalindrome.Append(word[s]);
                        }
                        palindromeWords.Add(wordPalindrome.ToString());
                    }


                }

            }
        }

    }

    public static void PalindromeWord2(string word)
    {
        var palindromeWords = new List<string>();
        string lowerWord = word.ToLower(); // convert once //racecarlevel

        for (int i = 0; i < lowerWord.Length; i++)
        {
            for (int j = i + 1; j < lowerWord.Length; j++)
            {
                int length = j - i + 1;
                string substring = lowerWord.Substring(i, length);
                if (IsPalindrome(substring))
                {
                    palindromeWords.Add(word.Substring(i, length)); // preserve original casing
                }
            }
        }

        // Optional: Print result
        foreach (var p in palindromeWords)
        {
            Console.WriteLine(p);
        }
    }

    private static bool IsPalindrome(string text)
    {
        int left = 0, right = text.Length - 1;
        while (left < right)
        {
            if (text[left] != text[right])
                return false;
            left++;
            right--;
        }
        return true;
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
using System;
using System.Linq;
using System.Text;

class BinaryToHex
{
    static void Main()
    {
        string number = "11110";
        Console.WriteLine("{0} to hexadecimal is {1}", number,ConvertBinToHex(number));
    }

    static string ConvertBinToHex(string number)
    {
        if (number.Length % 4 != 0)
        {
            number = number.PadLeft((4 - number.Length % 4 + number.Length), '0');
        }

        StringBuilder outputNumber = new StringBuilder();

        for (int startIndex = 0; startIndex < number.Length; startIndex += 4)
        {
            switch (number.Substring(startIndex, 4))
            {
                case "0000":
                    outputNumber.Append("0");
                    break;
                case "0001":
                    outputNumber.Append("1");
                    break;
                case "0010":
                    outputNumber.Append("2");
                    break;
                case "0011":
                    outputNumber.Append("3");
                    break;
                case "0100":
                    outputNumber.Append("4");
                    break;
                case "0101":
                    outputNumber.Append("5");
                    break;
                case "0110":
                    outputNumber.Append("6");
                    break;
                case "0111":
                    outputNumber.Append("7");
                    break;
                case "1000":
                    outputNumber.Append("8");
                    break;
                case "1001":
                    outputNumber.Append("9");
                    break;
                case "1010":
                    outputNumber.Append("A");
                    break;
                case "1011":
                    outputNumber.Append("B");
                    break;
                case "1100":
                    outputNumber.Append("C");
                    break;
                case "1101":
                    outputNumber.Append("D");
                    break;
                case "1110":
                    outputNumber.Append("E");
                    break;
                case "1111":
                    outputNumber.Append("F");
                    break;
            }
        }
        return outputNumber.ToString();
    }
}

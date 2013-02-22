using System;
using System.Linq;
using System.Text;

class HexToBinary
{
    static void Main()
    {
        string number = "F0";
        Console.WriteLine("{0} to binary is {1}", number, ConvertBinToHex(number));
    }

    static string ConvertBinToHex(string number)
    {
        number = number.ToUpper();

        StringBuilder outputNumber = new StringBuilder();

        for (int index = 0; index < number.Length; index++)
        {

            switch (number[index])
            {
                case '0': 
                    outputNumber.Append("0000"); 
                    break;
                case '1': 
                    outputNumber.Append("0001");
                    break;
                case '2':
                    outputNumber.Append("0010"); 
                    break;
                case '3': 
                    outputNumber.Append("0011"); 
                    break;
                case '4':
                    outputNumber.Append("0100");
                    break;
                case '5': 
                    outputNumber.Append("0101");
                    break;
                case '6':
                    outputNumber.Append("0110");
                    break;
                case '7':
                    outputNumber.Append("0111"); 
                    break;
                case '8':
                    outputNumber.Append("1000"); 
                    break;
                case '9':
                    outputNumber.Append("1001"); 
                    break;
                case 'A':
                    outputNumber.Append("1010"); 
                    break;
                case 'B':
                    outputNumber.Append("1011");
                    break;
                case 'C':
                    outputNumber.Append("1100");
                    break;
                case 'D':
                    outputNumber.Append("1101");
                    break;
                case 'E':
                    outputNumber.Append("1110"); 
                    break;
                case 'F':
                    outputNumber.Append("1111");
                    break;
            }
        }
        return outputNumber.ToString();
    }
}

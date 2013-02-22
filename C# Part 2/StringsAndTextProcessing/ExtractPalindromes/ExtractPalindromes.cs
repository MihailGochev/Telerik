using System;
using System.Collections;
using System.Linq;

class ExtractPalindromes
{
    static void Main(string[] args)
    {
        string input = @"ABBA lamal exe Lorem ipsum dolor sit amet, consectetur adipiscing elit. Quisque mauris nunc, laoreet nec ullamcorper ut, ornare eget felis. In a libero sit amet nisi suscipit malesuada. Donec eget commodo magna. Praesent laoreet nunc ac justo imperdiet lobortis. Duis tincidunt condimentum purus, quis tincidunt mi sagittis quis. Fusce felis dolor, convallis a venenatis non, dapibus vel neque. Pellentesque adipiscing, diam nec condimentum egestas, nisl turpis placerat tortor, eget pulvinar lorem turpis et enim. Ut nunc orci, suscipit et ullamcorper eget, dignissim vel urna. Suspendisse eu luctus lacus. Vivamus vitae quam ut augue ullamcorper viverra a ac velit. Pellentesque vestibulum venenatis nunc, sit amet elementum ipsum sodales vel. Duis ullamcorper sagittis lacus, convallis elementum felis tincidunt id. Sed nulla tortor, fringilla ultricies blandit non, ultricies et urna. Cras consectetur mi a quam venenatis lacinia. Maecenas sollicitudin laoreet ligula, vulputate euismod sapien ornare in.";
        string[] inputWords = input.Split(new char[] { ' ', '!', '?', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

        foreach (var word in inputWords)
        {
            if (IsPalindrome(word))
            {
                Console.WriteLine(word);
            }
        }

    }

    static bool IsPalindrome(string word)
    {
        int startIndex = 0;
        int endIndex = word.Length - 1;

        while (startIndex < endIndex)
        {
            if (word[startIndex++] != word[endIndex--])
            {
                return false;
            }
        }
        return true;
    }

}

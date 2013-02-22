using System;
using System.Linq;

class LinkInfo
{
    static void Main(string[] args)
    {
        Uri link = new Uri("http://www.devbg.org/forum/index.php");
        Console.WriteLine("[protocol] = \"{0}\"", link.Scheme);
        Console.WriteLine("[server] = \"{0}\"", link.Host);
        Console.WriteLine("[resourse] = \"{0}\"", link.AbsolutePath);
    }
}
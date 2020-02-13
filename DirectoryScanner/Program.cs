using System;
using System.IO;

namespace DirectoryScanner
{
    class Program
    {
        static void Main(string[] args)
        {
            var searchDir = "/";

            //style 
            Console.WriteLine(@"
<style>
    a{
        cursor: pointer;
        width: 100px;
        height: 120px;
        overflow: hidden;
    }
    a:hover{
        background-color: lightblue;
    }
</style>
            ");

            if (args.Length != 0)
            {
                searchDir = args[0];
            }

            if (File.Exists(searchDir))
            {
                Console.WriteLine(File.ReadAllText(searchDir));
            }
            else
            {
                Console.WriteLine("<h1> Files in " + searchDir + "</h1>");

                foreach (var x in Directory.GetDirectories(searchDir))
                {
                    Console.WriteLine($"<a style='display:inline-block' href='EosNav.php?path={x}' title='{x.Split('/')[x.Split('/').Length - 1]}'><img src='Folder.png' width='100px' height='100px'/><br/>" + x.Split('/')[x.Split('/').Length - 1] + "</a>");
                }

                foreach (var x in Directory.GetFiles(searchDir))
                {
                    Console.WriteLine($"<a style='display:inline-block' href='EosNav.php?path={x}' title='{x.Split('/')[x.Split('/').Length - 1]}'><img src='File.png' width='100px' height='100px'/><br/>" + x.Split('/')[x.Split('/').Length - 1] + "</a>");
                }
            }
        }
    }
}

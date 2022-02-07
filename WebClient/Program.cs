using System.Security.AccessControl;
using System.Net;
using System.IO;

WebClient client = new WebClient();
using (Stream stream = client.OpenRead("http://somesite.com/sometext.txt")) //запросили файл
{
    using (StreamReader reader = new StreamReader(stream))//
    {
        var line = "";
        while ((line = reader.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
        }
    }
    System.Console.WriteLine("файл загружен");
    System.Console.Read();
}

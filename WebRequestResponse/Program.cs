using System;
using System.Net;
using System.IO;
using System.Threading.Tasks;

WebRequest request = WebRequest.Create("http://somesite.com/myfile.txt");
WebResponse response = request.GetResponse();
using (Stream stream = response.GetResponseStream())
{
    using (StreamReader reader = new StreamReader(stream))
    {
        string line = "";
        while ((line = reader.ReadLine()) != null)
        {
            System.Console.WriteLine(line);
        }
    }
}
response.Close();
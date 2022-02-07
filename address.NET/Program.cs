using System.Net;
// System.Net.IPAddress ip = System.Net.IPAddress.Parse("127.0.0.1");
// System.Console.WriteLine(ip); выведет 127,0,0,1
IPHostEntry host1 = Dns.GetHostEntry("www.microsoft.com");//получаем ассоциированый массив 

System.Console.WriteLine(host1.HostName);

System.Console.WriteLine("сбор ipAddress с microsoft");
foreach (IPAddress ip in host1.AddressList)//наполняем лист 
{
    System.Console.WriteLine(ip.ToString());//выведем каждое значение
}

System.Console.WriteLine("-----------");
System.Console.WriteLine("\n");
System.Console.WriteLine("выплнение для гугла");

IPHostEntry host2 = Dns.GetHostEntry("google.com");
System.Console.WriteLine(host2.HostName);

foreach (IPAddress ip in host2.AddressList)
{
    System.Console.WriteLine(ip.ToString());
}

// See https://aka.ms/new-console-template for more information
using System.Collections;

Console.Write("Lutfen bir cumle giriniz: ");
    string? s = Console.ReadLine();
    s = s.ToLower();

    ArrayList list = new ArrayList();
    foreach(var item in s) 
    {
        if (item == 'a' || item == 'e' || item == 'ı' || item == 'i' || item == 'o' || item == 'ö'|| item == 'u' || item == 'ü')
        {
            list.Add(item);
        }
    }
        
    Console.WriteLine("Dizinin sesli elemanlari: ");
    foreach(var item in list)
        Console.Write(item + "-");

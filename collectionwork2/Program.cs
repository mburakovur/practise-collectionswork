// See https://aka.ms/new-console-template for more information

        int n = 20;
        int[] list = new int[n];
        for(int i=0; i<n; i++) 
        {   
            Console.Write((i+1) + ". sayiyi giriniz: ");
            list[i] = int.Parse(Console.ReadLine());
        }
        
        Array.Sort(list);
        int n1 = list[0];
        int n2 = list[1];
        int n3 = list[2];
        int m1 = list[list.Length-1];
        int m2 = list[list.Length-2];
        int m3 = list[list.Length-3];

        float minOrtalama = (float)((n1+n2+n3)/3);
        float maxOrtalama = (float)((m1+m2+m3)/3);

        Console.WriteLine("En kucuk 3 sayinin ortalamasi: " + minOrtalama);
        Console.WriteLine("En buyuk 3 sayinin ortalamasi: " + maxOrtalama);
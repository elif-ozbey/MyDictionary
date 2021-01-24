using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> sehirler = new MyDictionary<int, string>();
            sehirler.Add(34, "Istanbul");
            sehirler.Add(16, "Bursa");
            for (int i = 0; i < sehirler.Count; i++)
            {

                Console.WriteLine(sehirler.Items1[i] + sehirler.Items2[i]);
            }
        }

        class MyDictionary<Tkey, EValue>
        {
            Tkey[] keyarray; // anahtar (key) degerlerini tuttugum dizi
            EValue[] valuearray; // deger (value) degerlerini tuttugum dizi

            Tkey[] keytemparray; // anahtar (key) degerlerini tuttugum gecicic dizi
            EValue[] valuetemparray; // deger (value) degerlerini tuttugum gecici dizi

            public MyDictionary() // constracter tanimlayarak yeni olusturdugum listeyi adresledim. Yani bos bir dizi olusturarak heapte yer actim
            {
                keyarray = new Tkey[0];
                valuearray = new EValue[0];
            }
            public void Add(Tkey key, EValue value)
            {
                keytemparray = keyarray;
                valuetemparray = valuearray; //yeni elemanlar attigimda adresler degisecegi ve eski elemanlara ulasamayacagim icin eski 
                //elemeanlarimi gecici bir dizide tuttuyorum.

                keyarray = new Tkey[keyarray.Length + 1]; // Add islemi yapildiginda eleman sayisinin 1 artmasi saglandi. 
                valuearray = new EValue[valuearray.Length + 1];
                for (int i = 0; i < keytemparray.Length; i++) // yukarida new diyerek yeni bir adres olusturuldugundan eski adreste bulunan elemanlari yeni adrese tasidik
                {
                    keyarray[i] = keytemparray[i];
                    valuearray[i] = valuetemparray[i];
                }

                keyarray[keyarray.Length - 1] = key;
                valuearray[valuearray.Length - 1] = value;

            }

            public Tkey[] Items1
            {
                get { return keyarray; }
            }

            public EValue[] Items2
            {
                get { return valuearray; }
            }
            public int Count
            {
                get { return keyarray.Length; }
            }
        }
    }
}
    
    


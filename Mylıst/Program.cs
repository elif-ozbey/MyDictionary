using System;

namespace Mylıst
{
    class Program
    {
        static void Main(string[] args)
        {
           MyList<string> sehirler = new MyList<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            Console.WriteLine(sehirler.Count);

        }

        class MyList <T>
        {
            T[] _array;
            T[] _temparray;

                public MyList()
            {
                _array = new T[0];
            }


            public void Add(T item)
            {
                _temparray = _array;
                _array = new T[_array.Length + 1];
                for (int i = 0; i < _temparray.Length; i++)
                {
                    _array[i] = _temparray[i];
                }
                _array[_array.Length - 1] = item;
            }

                public int Count 
            { 
                get { return _array.Length; }
            }
        }

        }

    }



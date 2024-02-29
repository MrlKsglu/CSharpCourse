 




List<string> sehirler = new List<string>();
sehirler.Add("Meral1");
sehirler.Add("Meral2");
sehirler.Add("Meral3");
sehirler.Add("Meral4");
sehirler.Add("Meral5");
sehirler.Add("Meral6");

foreach (var item in sehirler)
{
    Console.WriteLine(item);
}
MyList<string> sehirler1= new MyList<string>();

sehirler1.Add("Meral");
sehirler1.Add("Meral1");
sehirler1.Add("Meral2");
//Console.WriteLine(sehirler1);



class MyList<T>
{
    T[] _array;
    T[] _tempArray;

    public MyList()
    {
        _array = new T[0];
    }
    public int _count { get { return _array.Length; } }
    public void Add(T t)
    {
        _tempArray = _array;
        _array = new T[_array.Length + 1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_count-1] = t;



    }

    
}
// 1 ВИД
void Method1()
{
    System.Console.WriteLine("Автор ...");
}

//Method1();

// 2 ВИД
void Method2(string msg)
{
    System.Console.WriteLine(msg);
}

//Method2("Hello");

void Method21(string msg, int count)
{
    int i = 0;
    while (i < count)
    {
        System.Console.WriteLine(msg);
        i++;
    }

}
// именованный вызов переменных
//Method21(msg: "Hello", count: 4);
//Method21(count: 4, msg: "World");

// 3 ВИД

int Method3()
{
    return DateTime.Now.Year;
}

int year = Method3();
//System.Console.WriteLine(year);

// 4 ВИД

string Method4(int count, string text)
{
    int i = 0;
    string result = String.Empty;

    while (i < count)
    {
        result = result + text;
        i++;
    }

    return result;
}

string res = Method4(10, "z");
System.Console.WriteLine(res);
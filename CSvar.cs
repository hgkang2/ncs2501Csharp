class CSVar
//field :전역변수
{
    int glovalVar;
    const int MAX = 1024;

    public void Method1()
    {
        int localVar;
        localVar = 100;

        Console.WriteLine(glovalVar);
        Console.WriteLine(localVar);
    }
}
internal class Program
{
    static private void Main(string[] args)
    {
        int a=2;
        double b=4.0f;
        cat cat1 = new cat();
        cat1.tang();
        cat.dai=2;
        cat1.chieucao=2;
        cat cat2 = new cat();
        cat cat3 = new cat();
        cat2.mausac="mau do";
        Console.WriteLine(cat1.mausac);
        Console.WriteLine(cat2.mausac);
        Console.WriteLine(cat1.chieucao);

        


    }
}

class ACountBank
{
    private int numberId;
    
    public int NumberId
    {
        get=>numberId;
        set=>numberId = value;

    }

    
}
class cat
{
    public int chieucao=1;
    public static int dai=1;
    public int Tang=1;
    public int age=1;
    public string mausac = "Mau vang";
    public string maumac = "Mau xanh";
    public string riamep = "co ria mep";
    void an()
    {

    }
    void nhay()
    {

    }
    public void tang()
    {

    }
}
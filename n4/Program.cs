class Transport
{
    public Transport() { }
    public Transport(string name) 
    {
        this.name = name;
    }
    public Transport(string name, int boost)
    {
        this.name = name;
        this.boost = boost;
    }

    private string scale = "км";
    public string name;
    public int boost = 1;

    public void moveAround(int x, int y, int z)
    {
        Console.WriteLine((x + y + z) * boost + scale + " " + name);
    }
    public void moveAround(int x, int y)
    {
        Console.WriteLine((x + y) * boost + scale + " " + name);
    }
}
class n4
{
    static void Main()
    {
        Transport transport = new Transport();
        Transport transport1 = new Transport(name : "boad");
        Transport transport2 = new Transport(name: "car", boost: 12);

        transport.moveAround(5, 5, 5);
        transport1.moveAround(4, 4);
        transport2.moveAround(5, 4, 5);

    }
}
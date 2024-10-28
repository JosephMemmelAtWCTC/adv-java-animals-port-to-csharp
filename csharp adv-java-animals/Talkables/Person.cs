namespace AdvJavaAnimals;

public abstract class Person
{
    public string name { get; }

    protected Person()
    {
    }
    
    protected Person(string name)
    {
        this.name = name;
    }
    
}
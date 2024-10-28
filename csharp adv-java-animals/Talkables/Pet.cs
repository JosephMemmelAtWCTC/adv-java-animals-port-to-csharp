namespace AdvJavaAnimals;

public abstract class Pet
{
    public string name { get; }

    protected Pet()
    {
    }
    
    protected Pet(string name)
    {
        this.name = name;
    }
    
}
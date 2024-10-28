namespace AdvJavaAnimals;

public class Dog : Pet, Talkable
{
    private bool friendly { get; }
    
    public Dog() : base(MenuHelper.GetString("What is your dog's name?", true, 1, 30))
    {
        string[] friendlyOptions = { "Yes", "No" };
        this.friendly = MenuHelper.SelectFromList(friendlyOptions, "Are they friendly?") == 0;;
    }
    
    public String Talk() {
        return "Bark";
    }
    
    public override string ToString()
    {
        return "Dog: " + "name=" + name + " friendly=" + friendly;
    }
    
}
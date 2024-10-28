namespace AdvJavaAnimals;

public class Cat : Pet, Talkable
{
    public int mousesKilled { get; set; }
    
    public Cat() : base(MenuHelper.GetString("What is your cat's name?", true, 1, 30))
    {
        this.mousesKilled = MenuHelper.GetWholeNumber("How many mice have they killed?", 0, 73000);//Limit to max of ~10 mice a day for 20 years
    }
    
    public String Talk() {
        return "Meow";
    }
    
    public void AddMouse() {
        this.mousesKilled++;
    }

    public override string ToString()
    {
        return "Cat: " + "name=" + name + " mousesKilled=" + mousesKilled;
    }
    
}
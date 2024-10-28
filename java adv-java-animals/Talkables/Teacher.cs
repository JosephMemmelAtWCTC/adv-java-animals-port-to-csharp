namespace AdvJavaAnimals;

public class Teacher : Person, Talkable
{
    public int age { get; set; }
    
    public Teacher() : base(MenuHelper.GetString("What is the Teacher's  name?", true, 1, 50))
    {
        this.age = MenuHelper.GetWholeNumber("How old are they?", 5, 200);
    }
    
    public String Talk() {
        return "Don't forget to do the assigned reading!";
    }

    public override string ToString()
    {
        return "Teacher: " + "name=" + name + " age=" + age;
    }
    
}
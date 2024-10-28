namespace AdvJavaAnimals;

public class UserInputFactory
{
    private Dictionary<string, Type> talkableTypes = new Dictionary<string, Type>();
    
    public Talkable CreateTalkable(string message)
    {
        return CreateTalkableType(talkableTypes.Keys.ToArray()[MenuHelper.SelectFromList(talkableTypes.Keys.ToArray(), message)]);
    }
    
    public Talkable CreateTalkableType(string key)
    {
        return (Talkable) Activator.CreateInstance(talkableTypes[key]);
    }
    
    public void AddTalkableFactoryOption(string key, Type talkableType)// Talkable talkableType)
    {
        talkableTypes.Add(key, talkableType); //talkableType.GetType());
    }
    
}
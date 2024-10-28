using System.Collections;
using System.Globalization;

namespace AdvJavaAnimals
{
    public class Program
    {
        
        private static readonly FileOutput outFile = new FileOutput("../../../animals.txt");
        private static readonly FileInput inFile = new FileInput("../../../animals.txt");
        
        public static void Main(string[] args)
        {
            UserInputFactory userInputFactory = new UserInputFactory();
            userInputFactory.AddTalkableFactoryOption("Dog", typeof(Dog));
            userInputFactory.AddTalkableFactoryOption("Cat", typeof(Cat));
            userInputFactory.AddTalkableFactoryOption("Teacher", typeof(Teacher));
            
            ArrayList zoo = new ArrayList();

            while (true)
            {
                zoo.Add(userInputFactory.CreateTalkable("Select a talkable to add to the zoo"));
                string[] options = { "Add another talkable", "Save and display zoo" };
                if (MenuHelper.SelectFromList(options, "Options") == 1)
                {
                    break;
                }
            }
            
            foreach (Talkable thing in zoo)
            {
                printOut(thing);
            }
            
            outFile.FileClose();
            inFile.FileRead();
            inFile.FileClose();
            
            FileInput indata = new FileInput("../../../animals.txt");
            String line;
            while ((line = indata.FileReadLine()) != null) {
                Console.WriteLine(line);
            }
        }

        public static void printOut(Talkable p) {
            Console.WriteLine(p.name + " says=" + p.Talk());
            outFile.FileWrite(p.name + " | " + p.Talk());
        }
        
    }
}
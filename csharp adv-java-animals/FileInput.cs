namespace AdvJavaAnimals;

public class FileInput
{
    private StreamReader inputFileReader;
    private String fileName;

    public FileInput(String fileName) {
        this.fileName = fileName;
        try
        {
            // Open the text file using a stream reader.
            inputFileReader = new(this.fileName);
        }
        catch (IOException e)
        {
            Console.WriteLine($"File Open Error: {e.Message}");
        }
    }

    public void FileRead() {
        try {
            string text = inputFileReader.ReadToEnd();
        } catch (Exception e) {
            Console.WriteLine("File Read Error: " + fileName + " " + e.Message);
        }
    }

    public string FileReadLine() {
        try {
            string text = inputFileReader.ReadLine();
            return text;
        } catch (Exception e) {
            Console.WriteLine("File ReadLine Error: " + fileName + " " + e.Message);
            return null;
        }
    }

    public void FileClose() {
        if (inputFileReader != null) {
            try {
                inputFileReader.Close();
            } catch (IOException e) {
                Console.WriteLine("File Close Error: " + fileName + " " + e.Message);
            }
        }
    
    }
}
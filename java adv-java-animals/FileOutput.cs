namespace AdvJavaAnimals;

using System.IO;

public class FileOutput
{
    private StreamWriter outputFileWriter;
    private String fileName;

    public FileOutput(String fileName) {
        this.fileName = fileName;
        this.outputFileWriter = new StreamWriter(this.fileName, true);
    }

    public void FileWrite(String line) {
        try {
            this.outputFileWriter.WriteLine(line);
        } catch (Exception e) {
            Console.WriteLine("File Write Error: " + fileName + " " + e);
        }
    }
    
    public void FileClose() {
        if (this.outputFileWriter != null) {
            try {
                outputFileWriter.Close();
            } catch (IOException e) {
                Console.WriteLine($"File Output Error: {e.Message}");
            }
        }
    
    }
}
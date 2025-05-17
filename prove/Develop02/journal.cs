using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

class Journal
{
    private List<Entry> entries = new List<Entry>();

    public void SaveToFile(string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in entries)
            {
                outputFile.WriteLine(entry.logformat());
            }
        }
    }
    public void Display()
    {
        foreach (Entry entery in entries)
        {
            Console.WriteLine(entery.Display());
        }
    }
    public void ReadFromFile(string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split("#");

            string date = parts[0];
            string question = parts[1];
            string entryText = parts[2];

            Entry entry = new Entry();
            entry.CreateEntryWithData(date, question, entryText);
            this.AddEntry(entry);
        }
    }
    public void AddEntry(Entry entry)
    {
        entries.Add(entry);
    }
}
namespace Prayer;

public class ScriptureReference
{
    public string Book { get; set; } = "";
    public int Chapter { get; set; }
    public int StartVerse { get; set; }
    public int EndVerse { get; set; }

    public override string ToString()
    {
        //Matthew 4:12
        if (StartVerse == EndVerse)
        {
            return $"{Book} {Chapter}:{StartVerse}";
        }

        //Matthew 4:12-17
        return $"{Book} {Chapter}:{StartVerse}-{EndVerse}";
    }
}
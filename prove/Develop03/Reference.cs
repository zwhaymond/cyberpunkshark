public class Reference
{
    // Method to handle difficulty selection and return the verse
    public string GetVerse(int level)
    {
        string verse = "";

        switch (level)
        {
            case 1:
                verse = "Adam fell that men might be; and men are, that they might have joy.";
                break;
            case 2:
                verse = "Angels speak by the power of the Holy Ghost; wherefore, they speak the words of Christ. Wherefore, I said unto you, feast upon the words of Christ; for behold, the words of Christ will tell you all things what ye should do.";
                break;
            case 3:
                verse = "Wherefore, men are free according to the flesh; and all things are given them which are expedient unto man. And they are free to choose liberty and eternal life, through the great Mediator of all men, or to choose captivity and death, according to the captivity and power of the devil; for he seeketh that all men might be miserable like unto himself.";
                break;
            default:
                Console.WriteLine("Invalid selection.");
                break;
        }

        return verse;
    }
}

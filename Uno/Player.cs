namespace Uno;

public class Player
{
    public string Name { get; set; }

    public List<Card> Hand { get; set; } = new List<Card>();


    public bool HasPlayableCard(Card card)
    {
       foreach (var i in Hand)
        {
            if (Card.PlaysOn(i, card))
                return true;
        }
        return false;
    }

    public Card GetFirstPlayableCard(Card card)
    {
        foreach (var i in Hand)
        {
            if (Card.PlaysOn(i, card))
                return i;
        }
        return null;
    }


    public Color MostCommonColor()
    {
        var order = new[] { Color.Red, Color.Yellow, Color.Blue, Color.Green, Color.Wild };

        var counts = new Dictionary<Color, int>
        {
            { Color.Red, 0 },
            { Color.Yellow, 0 },
            { Color.Blue, 0 },
            { Color.Green, 0 },
            { Color.Wild, 0 }
        };

        foreach (var i in Hand)
        {
            counts[i.Color]++;
        }

        Color best = order[0];
        int bestCount = counts[best];

        foreach (var col in order)
        {
            if (counts[col] > bestCount)
            {
                best = col;
                bestCount = counts[col];
            }
        }

        return best;
    }

}
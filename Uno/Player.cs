namespace Uno;

public class Player
{
    public string Name { get; set; } = string.Empty;
    public List<Card> Hand { get; set; } = new List<Card>();

    public bool HasPlayableCard(Card other)
    {
        foreach (var card in Hand)
        {
            if (Card.PlaysOn(card, other))
                return true;
        }
        return false;
    }

    public Card? GetFirstPlayableCard(Card other)
    {
        foreach (var card in Hand)
        {
            if (Card.PlaysOn(card, other))
                return card;
        }
        return null;
    }

    public Color MostCommonColor()
    {
        var colorCounts = new Dictionary<Color, int>();

        foreach (var card in Hand)
        {
            if (card.Color == Color.Wild) continue;
            if (!colorCounts.ContainsKey(card.Color))
                colorCounts[card.Color] = 0;
            colorCounts[card.Color]++;
        }

        if (colorCounts.Count == 0)
            return Color.Red;

        return colorCounts
            .OrderByDescending(c => c.Value)
            .ThenBy(c => c.Key.ToString())
            .First().Key;
    }
}

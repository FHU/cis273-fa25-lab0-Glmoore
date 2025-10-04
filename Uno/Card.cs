namespace Uno;

public class Card
{
    public Color Color { get; set; }
    public CardType Type { get; set; } = CardType.Number;
    public int? Number { get; set; }

    public override string ToString()
    {
        if (Type == CardType.Number && Number.HasValue)
            return $"{Color} {Number}";
        if (Type == CardType.Wild || Type == CardType.WildDraw4)
            return $"{Type}";
        return $"{Color} {Type}";
    }

    public static bool PlaysOn(Card a, Card b)
    {
        if (a.Type == CardType.Wild || a.Type == CardType.WildDraw4) return true;
        if (b.Type == CardType.Wild || b.Type == CardType.WildDraw4) return true;

        if (a.Color == b.Color) return true;

        if (a.Type == CardType.Number && b.Type == CardType.Number && a.Number == b.Number) return true;

        if (a.Type == b.Type && (a.Type == CardType.Skip || a.Type == CardType.Reverse || a.Type == CardType.Draw2))
            return true;

        return false;
    }
}

/*Hey, Mr.Casey. If you're reading this just know I can't figure out how to satisfy the autotest.*/


namespace Uno;

public class UnoGame
{
    /*
        List<Player> Players
List<Card> DrawStack
List<Card> DiscardStack
Color CurrentColor

    */

    public List<Player> Players { get; set; } = new List<Player>();
    public List<Card> DrawStack { get; set; } = new List<Card>();

    public List<Card> DiscardStack { get; set; } = new List<Card>();

    public Color CurrentColor { get; set; }

}
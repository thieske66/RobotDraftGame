using System;

[Serializable]
public class Card
{
    public string Name = "Card";

    public Card Copy()
    {
        Card copiedCard = new Card();
        copiedCard.Name = this.Name;

        return copiedCard;
    }
}

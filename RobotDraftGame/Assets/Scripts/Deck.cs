using System;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class Deck 
{
    public List<Card> Cards = new List<Card>();

    public void Shuffle()
    {
        List<Card> currentCards = new List<Card>(Cards);
        List<Card> shuffledCards = new List<Card>();

        int numberOfCards = currentCards.Count;
        for (int i = 0; i < numberOfCards; i++)
        {
            int randomIndex = UnityEngine.Random.Range(0, currentCards.Count);
            Card randomCard = currentCards[randomIndex];
            shuffledCards.Add(randomCard);
            currentCards.Remove(randomCard);
        }
        Cards = shuffledCards;
    }

    public Card Take()
    {
        if (Cards.Count == 0)
        {
            Debug.LogWarning("Unable to draw from empty deck");
            return null;
        }

        Card card = Cards[0];
        Cards.RemoveAt(0);
        return card;
    }

    public void AddTop(Card card)
    {
        Cards.Insert(0, card);
    }

    public void AddTop(List<Card> cards)
    {
        for (int i = cards.Count; i >= 0; i--)
        {
            AddTop(cards[i]);
        }
    }

    public void AddBottom(Card card)
    {
        Cards.Insert(Cards.Count, card);
    }

    public void AddBottom(List<Card> cards)
    {
        for (int i = 0; i < cards.Count; i++)
        {
            AddBottom(cards[i]);
        }
    }
}

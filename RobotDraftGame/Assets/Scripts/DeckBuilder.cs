using CustomAttributes;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeckBuilder : MonoBehaviour
{
    public List<DeckEntry> DeckConfig = new List<DeckEntry>();

    [Button("DebugGenerateDeck")]
    public bool doGenerate = false;

    public Deck DebugDeck = new Deck();

    public void DebugGenerateDeck()
    {
        DebugDeck = GenerateDeck();
    }

    /// <summary>
    /// Returns a shuffled deck generated from the DeckConfig
    /// </summary>
    /// <returns></returns>
    public Deck GenerateDeck()
    {
        Deck generatedDeck = new Deck();
        foreach(DeckEntry entry in DeckConfig)
        {
            for (int i = 0; i < entry.Amount; i++)
            {
                generatedDeck.AddBottom(entry.Card.Copy());
            }
        }
        generatedDeck.Shuffle();
        return generatedDeck;
    }
}

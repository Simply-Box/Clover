using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum CardType {
    Clover, Diamond, Heart, Spade
}

public class Card {
    public CardType Type;
    public int Value;

    public Card(CardType type, int value) {
        Type = type;
        Value = value;
    }
}

public class Deck : MonoBehaviour
{
    public List<Card> Cards = new List<Card>();

    void Awake()
    {
        for (int type = 0; type < 4; type++) {
            for (int value = 1; value <= 13; value++) {
            Cards.Add(new Card((CardType)type, value));
            }
        }
    }
}
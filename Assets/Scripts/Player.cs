using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public List<Card> Hand = new List<Card>();

    void Start()
    {
        Deck deck = FindObjectOfType<Deck>();
        int handSize = 3;

        for (int i = 0; i < handSize; i++) {
            int randomCardIndex = Random.Range(0, deck.Cards.Count);
            
            Hand.Add(deck.Cards[randomCardIndex]);
            deck.Cards.RemoveAt(randomCardIndex);
        }

        foreach (Card card in Hand) {
            Debug.Log($"{card.Type} {card.Value}");
        }
    }

    void Update()
    {
    }
}

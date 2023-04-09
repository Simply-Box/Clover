using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

public enum CardType {
    Clover, Diamond, Heart, Spade
}

public class Card {
    public readonly CardType Type;
    public readonly int Value;
    public readonly Sprite Sprite;

    public Card(CardType type, int value) {
        Type = type;
        Value = value;

        Texture2D texture = AssetDatabase.LoadAssetAtPath<Texture2D>($"Assets/Sprites/Cards/{Value}_{Type.ToString().ToLower()}.png");
        Sprite = Sprite.Create(texture, new Rect(0, 0, texture.width, texture.height), new Vector2(0.5f, 0.5f));
    }

    public static void Move(List<Card> from, List<Card> to, int index) {
        to.Add(from[index]);
        from.RemoveAt(index);
    }

    public static void MoveRandom(List<Card> from, List<Card> to) {
        Move(from, to, Random.Range(0, from.Count));
    }

    public static void MoveTop(List<Card> from, List<Card> to) {
        Move(from, to, from.Count - 1);
    }

    public static void Shuffle(List<Card> cards) {
        for (int i0 = 0; i0 < 52; i0++) {
            int i1 = Random.Range(0, 52);
            Card x = cards[i0];
            cards[i0] = cards[i1];
            cards[i1] = x;
        }
    } 
}

public class PlayArea : MonoBehaviour {
    public List<Card> PlayPile = new List<Card>();
    public List<Card> Deck = new List<Card>();
    private SpriteRenderer spriteRenderer;

    // public int Turn;

    void Start() {
        spriteRenderer = GetComponent<SpriteRenderer>();

        for (int type = 0; type < 4; type++) {
            for (int value = 1; value <= 13; value++) {
                Deck.Add(new Card((CardType)type, value));
            }
        }

        Card.Shuffle(Deck);

        PlayTop();
    }

    public void PlayTop() {
        Card.MoveTop(Deck, PlayPile);
        spriteRenderer.sprite = PlayPile[PlayPile.Count - 1].Sprite;
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour {
    public PlayArea PlayArea;
    public List<Card> Hand = new List<Card>();
    private SpriteRenderer spriteRenderer;

    
    void CreateHand() {
        spriteRenderer = GetComponent<SpriteRenderer>();
        int handSize = 3;
        for (int i = 0; i < handSize; i++) {
            Card.MoveTop(PlayArea.Deck, Hand);
            spriteRenderer.sprite = Hand[Hand.Count - 1].Sprite;
        }
    }

    /*
    public void RedrawCards() {
        SpriteRenderer spriteRenderer;
        Sprite newSprite;
        void ChangeSprite() {
            spriteRenderer.sprite = newSprite;
        }
    }
    */

}

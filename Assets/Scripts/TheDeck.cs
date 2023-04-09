using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TheDeck : MonoBehaviour {
    public PlayArea playArea;

    void OnMouseDown() {
        playArea.PlayTop();
        Debug.Log(playArea.PlayPile);
	}
}
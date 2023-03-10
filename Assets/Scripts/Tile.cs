using UnityEngine;
using System.Collections;

public class Tile : MonoBehaviour {

	public Sprite originalSprite;
	public Sprite hiddenSprite;

	// Initialization
	void Start () {
	
	}
		
	// Once per frame
	void Update () {
	
	}

	public void OnMouseDown()
	{
		print ("You pressed on tile");
	}

	public void newCard()
	{
		// set the forst card position to 0, 0, 0
		// then add 1 to x position so that next card is created to the right
		//GetComponent<SpriteRenderer> ().sprite = originalSprite;
	}

	public void removeCard()
	{
		// remove the first card somehow
		//GetComponent<SpriteRenderer> ().sprite = hiddenSprite;
		// Then take all card positions and take their x position - 1
	}
}

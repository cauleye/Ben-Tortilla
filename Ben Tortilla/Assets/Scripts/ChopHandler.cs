using UnityEngine;
using System.Collections;

public class ChopHandler : MonoBehaviour {

	public bool touchingKnife;

	public SpriteRenderer spriteRenderer;
	public Sprite wholeFood;
	public Sprite halfFood;
	public Sprite manyFood;

	public AudioSource audioSource;
	public AudioClip chopSound; //This is the sound for chopping
	public AudioClip noChop; //This is for when the player has chopped all the way through

	// Use this for initialization
	void Start () {
		touchingKnife = false; 
		spriteRenderer.sprite = wholeFood;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyUp("space")){
			if (touchingKnife) {
				if (spriteRenderer.sprite == wholeFood) {
					audioSource.PlayOneShot (chopSound);
					spriteRenderer.sprite = halfFood;
				} else if (spriteRenderer.sprite == halfFood) {
					spriteRenderer.sprite = manyFood;
					audioSource.PlayOneShot (chopSound);
				} else { 
					audioSource.PlayOneShot (noChop);
				}
			}
		}
	}

	//These check to see if the object is touching the knife or not
	void OnTriggerEnter2D(Collider2D other){
		if (other.transform.name == "Knife") {
			touchingKnife = true; 
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.transform.name == "Knife") {
			touchingKnife = false; 
		}
	}
}

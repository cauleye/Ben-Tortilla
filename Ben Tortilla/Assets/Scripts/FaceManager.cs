using UnityEngine;
using System.Collections;

public class FaceManager : MonoBehaviour {

	public GameObject chewButton;
	public GameObject continueButton;

	public GameObject tortilla;

	public Animator animator;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter2D(Collider2D other){
		if (other.name == "Tortilla") {
			chewButton.SetActive (true);
		}
	}


	void OnTriggerExit2D(Collider2D other){
		if (other.name == "Tortilla") {
			chewButton.SetActive (false);
		}

	}


	public void Chew(){
		chewButton.SetActive (false);
		tortilla.SetActive (false);
		animator.Play ("FaceChewing");
		continueButton.SetActive (true);

	}

}

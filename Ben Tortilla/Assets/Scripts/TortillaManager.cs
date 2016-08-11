using UnityEngine;
using System.Collections;

public class TortillaManager : MonoBehaviour {

	public int tomatoOnTortilla;
	public int chorizoOnTortilla;


	public GameObject managerObject;
	public IngredientsManager ingredientsManager;

	public GameObject foldButton;

	// Use this for initialization
	void Start () {
		managerObject = GameObject.Find("Ingredient Manager");
		ingredientsManager = managerObject.GetComponent<IngredientsManager> ();

		foldButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (tomatoOnTortilla == ingredientsManager.tomatoCount && chorizoOnTortilla == ingredientsManager.chorizoCount) {
			foldButton.SetActive (true);
		} else {
			foldButton.SetActive (false);
		}
	}


	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "Tomato") {
			tomatoOnTortilla++;
		}
		if (other.tag == "Chorizo") {
			chorizoOnTortilla++;
		}

	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Tomato") {
			tomatoOnTortilla--;
		}
		if (other.tag == "Chorizo"){
			chorizoOnTortilla--;
		}
	}
}

using UnityEngine;
using System.Collections;

public class TortillaManager : MonoBehaviour {

	public int tomatoOnTortilla;
	public int chorizoOnTortilla;
	public int onionOnTortilla;
	public int cheeseOnTortilla;
	public int pepperOnTortilla;


	public GameObject managerObject;
	public IngredientsManager ingredientsManager;

	public GameObject foldButton;
	public GameObject continueButton;

	public Animator animator;

	// Use this for initialization
	void Start () {
		managerObject = GameObject.Find("Ingredient Manager");
		ingredientsManager = managerObject.GetComponent<IngredientsManager> ();

		foldButton.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		if (tomatoOnTortilla == ingredientsManager.tomatoCount && chorizoOnTortilla == ingredientsManager.chorizoCount && onionOnTortilla == ingredientsManager.onionCount && pepperOnTortilla == ingredientsManager.pepperCount && cheeseOnTortilla == ingredientsManager.cheeseCount) {
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
		if (other.tag == "Onion") {
			onionOnTortilla++;
		}
		if (other.tag == "Pepper") {
			pepperOnTortilla++;
		}
		if (other.tag == "Cheese") {
			cheeseOnTortilla++;
		}
	}

	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "Tomato") {
			tomatoOnTortilla--;
		}
		if (other.tag == "Chorizo"){
			chorizoOnTortilla--;
		}
		if (other.tag == "Onion") {
			onionOnTortilla--;
		} 
		if (other.tag == "Pepepr") {
			pepperOnTortilla--;
		}
		if (other.tag == "Cheese") {
			cheeseOnTortilla--;
		}
	}


	public void FoldTortilla(){
		DestroyFood ();
		Destroy (foldButton);
		animator.Play ("FoldTortilla");
		continueButton.SetActive (true);
	}

	void DestroyFood(){
		GameObject[] tomatos = GameObject.FindGameObjectsWithTag ("Tomato");
		for (int i = 0; i < tomatos.Length; i++) {
			Destroy (tomatos [i]);
		}

		GameObject[] chorizos = GameObject.FindGameObjectsWithTag ("Chorizo");
		for (int i = 0; i < chorizos.Length; i++) {
			Destroy (chorizos [i]);
		}

		GameObject[] onions = GameObject.FindGameObjectsWithTag ("Onion");
		for (int i = 0; i < onions.Length; i++) {
			Destroy (onions [i]);
		}

		GameObject[] cheeses = GameObject.FindGameObjectsWithTag ("Cheese");
		for (int i = 0; i < cheeses.Length; i++) {
			Destroy (cheeses [i]);
		}

		GameObject[] peppers = GameObject.FindGameObjectsWithTag ("Pepper");
		for (int i = 0; i < peppers.Length; i++) {
			Destroy (peppers [i]);
		}
	}

}

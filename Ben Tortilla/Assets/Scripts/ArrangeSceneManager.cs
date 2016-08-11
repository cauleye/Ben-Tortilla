using UnityEngine;
using System.Collections;

public class ArrangeSceneManager : MonoBehaviour {


	public GameObject managerObject;
	public IngredientsManager ingredientsManager;


	// Use this for initialization
	void Start () {
		managerObject = GameObject.Find("Ingredient Manager");
		ingredientsManager = managerObject.GetComponent<IngredientsManager> ();



	}

	// Update is called once per frame
	void Update () {
	
	}
}

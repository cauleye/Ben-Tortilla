using UnityEngine;
using System.Collections;

public class ArrangeSceneManager : MonoBehaviour {

	public GameObject managerObject;
	public IngredientsManager ingredientsManager;

	public GameObject createTomato;
	public InstantiateFood tomatoInstantiator;
	public GameObject createChorizo;
	public InstantiateFood chorizoInstantiator;

	// Use this for initialization
	void Start () {
		managerObject = GameObject.Find("Ingredient Manager");
		ingredientsManager = managerObject.GetComponent<IngredientsManager> ();

		createTomato = GameObject.Find ("CreateTomato");
		tomatoInstantiator = createTomato.GetComponent<InstantiateFood> ();
		createChorizo = GameObject.Find ("CreateChorizo");
		chorizoInstantiator = createChorizo.GetComponent<InstantiateFood> ();



		SpawnTomatos ();
		SpawnChorizo ();
	}

	// Update is called once per frame
	void Update () {
	
	}

	//These scripts check the ingredients manager to see how many of each food the player prepared in the last scene
	//in order to spawn in the same number of ingredients in this scene. 
	void SpawnTomatos(){
		int tomatoCount = ingredientsManager.tomatoCount;
		for (int i = 0; i < tomatoCount; i++) {
			tomatoInstantiator.CreateFood ();
		}
	}

	void SpawnChorizo(){
		int chorizoCount = ingredientsManager.chorizoCount;
		for (int i = 0; i < chorizoCount; i++) {
			chorizoInstantiator.CreateFood ();
		}
	}


}

using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class FoodPersistenceManager : MonoBehaviour {

	//This is to make the food object pass from 03 where it was created to 04
	void Awake(){
		DontDestroyOnLoad (gameObject);
		Debug.Log ("Don't destroy on load: " + name);
	}

	void Update(){
		Scene scene = SceneManager.GetActiveScene ();
		if (scene.name == "05 Toast") {
			Destroy (gameObject);
		}
	}
}

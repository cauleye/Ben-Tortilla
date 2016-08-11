using UnityEngine;
using System.Collections;

public class IngredientsManager : MonoBehaviour {

	public int tomatoCount;
	public int onionCount;
	public int pepperCount;
	public int chorizoCount;
	public int cheeseCount;

	// Use this for initialization
	void Start () {
		tomatoCount = 0;
		onionCount = 0;
		pepperCount = 0;
		chorizoCount = 0;
		cheeseCount = 0;
	}

	//This prevents the script from being destroyed changing from scene 03 to 04
	void Awake(){
		DontDestroyOnLoad(gameObject);
		Debug.Log("Don't destroy on load: " + name);
	}

	public void AddTomato(){
		tomatoCount++;
	}

	public void AddOnion(){
		onionCount++;
	}

	public void AddPepper(){
		pepperCount++;
	}

	public void AddChorizo(){
		chorizoCount++;
	}

	public void AddCheese(){
		cheeseCount++;
	}
}

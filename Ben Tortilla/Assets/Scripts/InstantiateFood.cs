using UnityEngine;
using System.Collections;

public class InstantiateFood : MonoBehaviour {

	public GameObject food;

	public Transform foodSpawn;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void CreateFood(){
		//The following sets up a small amount of randomness in how the food spawns in 
		Vector3 foodSpawnRandom = new Vector3 (foodSpawn.position.x + Random.Range (-2, 2), foodSpawn.position.y + Random.Range (-2, 2), foodSpawn.position.z);
		Instantiate (food, foodSpawnRandom, Quaternion.identity);
	}
}

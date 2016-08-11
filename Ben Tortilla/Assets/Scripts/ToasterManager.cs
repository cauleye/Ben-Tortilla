using UnityEngine;
using System.Collections;

public class ToasterManager : MonoBehaviour {

	public Animator animator;

	public GameObject toastButton;
	public GameObject continueButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void Toast(){
		toastButton.SetActive (false);
		animator.Play ("Toasting");
		continueButton.SetActive (true);
	}
}

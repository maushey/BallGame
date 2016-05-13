using UnityEngine;
using System.Collections;

public class MainMenu : MonoBehaviour {

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	public void StartGame(){
		Application.LoadLevel ("Game");
	}

	public void Credit(){
		Application.LoadLevel ("Credit");
	}

	public void Quit(){
		Application.Quit ();
	}

	public void backtoMain(){
		Application.LoadLevel ("Start");
	}
}

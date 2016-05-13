using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	GameManager gameManager;

	Ball player;

	public GameObject[] platformArray;
	//Links to GUI objects
	public Text score;
	public Text currentTime;
	public Text bestTime; 
	public Text blocksplaced;


	// Use this for initialization
	void Start () {
		gameManager = GameObject.FindGameObjectWithTag ("GameManager").GetComponent<GameManager> ();
		player = GameObject.FindGameObjectWithTag ("Ball").GetComponent<Ball> ();
	}

	// Update is called once per frame
	void Update () {

		//Update GUI Elements
		score.text = "Score: " + gameManager.score;
		currentTime.text = "Current Time: " + gameManager.currentTime;
		bestTime.text = "Best Time: " + gameManager.bestTime;
		//blocksplaced.text = "Blocks Placed: " + player.blocksplaced;

	}

	//Functions to change the block that gets spawned
	public void changeBlockStop(){
		foreach (GameObject platform in platformArray) platform.GetComponent<Platform>().structureIndex = 1;
	}
	public void changeBlockGravityPull(){
		foreach (GameObject platform in platformArray) platform.GetComponent<Platform>().structureIndex = 2;
	}
	public void changeBlockSpeed(){
		foreach (GameObject platform in platformArray) platform.GetComponent<Platform>().structureIndex = 3;
	}
	public void changeBlockSlow(){
		foreach (GameObject platform in platformArray) platform.GetComponent<Platform>().structureIndex = 4;
	}


}


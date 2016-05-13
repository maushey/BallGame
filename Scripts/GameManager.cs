using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	public bool ballAlive = true;

	public float score = 0;
	public float currentTime = 60;
	public float bestTime;

	//Use  this for initialization
	void Start () {

		currentTime = 60;

		bestTime = PlayerPrefs.GetFloat ("Best Time", 0);
		score = PlayerPrefs.GetFloat ("Score ", 0);

	}


	// Update is called once per frame
	void Update () {
		
		//Increment currentTime if player is alive	
		if (ballAlive)
			currentTime -= Time.deltaTime;

		// Game Over Check - When player dies
		if (!ballAlive) {
			if (currentTime > bestTime) {
				PlayerPrefs.SetFloat ("BestTime", currentTime);
			
			}
		} 
	}
}

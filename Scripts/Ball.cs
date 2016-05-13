using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour{

	/*
	//Originally used to make ball change dircetion
	public Transform originalObject;
	public Transform reflectedObject;

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Wall") {reflectedObject.position = Vector3.Reflect(originalObject.position, Vector3.back);
		}
	}
	*/

	public static AudioManager audioManager;
	public AudioClip SpeedUp;
	public AudioClip audiofile;
	public AudioClip Hitwall;

	//When Ball or player hits objects tagged with "Wall", sound will play
	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Wall") {
			//Play Sound
			audioManager.PlayAudio(Hitwall);
		}
	}

	//Variable for AddForce
	public Vector3 initialImpulse; 

	//Movement variables
	public Rigidbody rb;

	//Speed of ball, alter here
	//public float moveForce = 70.0f;
	public float rotationSpeed = 100.0f;

	void Start ()
	{
		//This "launches" the ball in the beginning allowing it rebound off the walls whilst retaining that launch speed
		GetComponent<Rigidbody>().AddForce (initialImpulse, ForceMode.Impulse);

		//Allows to get scripts from AudioManager.cs
		audioManager = GameObject.FindGameObjectWithTag ("AudioManager").GetComponent<AudioManager>();
	}

	//Update is called once per frame
	void Update(){
		//Initially used to keep the ball rolling forward or right
		//transform.position += Vector3.forward * moveForce * Time.deltaTime;
	}
}
using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {
	void OnTriggerEnter(Collider other)
	{
		other.transform.rotation = Quaternion.Euler(0, 180, 0);
	}

	/*
	private float gForce;
	private Vector3 pullVector;
	public float pullRange = 10.0f;

	// This block, similar to the Gravitator Enemy in class, pulls the ball the player guides, closer to itself
	public void Attack()
	{
		gForce = (pullRange - Vector3.Distance (transform.position, Ball.transform.position)) * 10.0f;
		pullVector = (transform.position - Ball.transform.position).normalized;
		Ball.GetComponent<Ball> ().rb.AddForce (pullVector * gForce);
	} */


		
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	


	}
}

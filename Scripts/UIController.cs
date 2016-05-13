using UnityEngine;
using System.Collections;
using UnityEngine.EventSystems;

public class UIController : MonoBehaviour {
	public EventSystem LevelEventSystem;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//Has uer clicked on primary mouse button?
		if (Input.GetMouseButtonDown (0)) {
			
			// Is thge current mouse location over the UI?
			if (LevelEventSystem.IsPointerOverGameObject ()) {
				Debug.Log ("Over UI!");
			}
			else 
			{
				// Setup the ray based on mouse lovation
				Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);

				// Perform a raycast to determine what we have hit
				RaycastHit hitResults;
				if (Physics.Raycast (ray, out hitResults)) 
				{
					// Retrieve the game object that was hit
					GameObject hitObject = hitResults.collider.gameObject;

					// Attempts to retrieve the platform
					Platform platform = hitObject.GetComponent<Platform> ();
					if (platform !=null)
					{
						platform.ReactToMouseClick (); 
					}
				}
			}
		}
	}
}

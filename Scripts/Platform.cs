using UnityEngine;
using System.Collections;

public class Platform : MonoBehaviour {
	
	public GameObject AnchorPoint;
	public GameObject PrefabToSpawn;
	public GameObject blockSpeed;
	public GameObject blockSlow;
	public GameObject blockGravityPull;
	public GameObject blockStop;
	private GameObject AttachedBuilding = null;
	public int structureIndex;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ReactToMouseClick()
	{
		Debug.Log ("Hit Platform!");

		// Spawns the prefab or stated block
		GameObject addedObject = GameObject.Instantiate (PrefabToSpawn);

		// Positions the prefab at the anchor point
		addedObject.transform.position = AnchorPoint.transform.position;
		addedObject.transform.SetParent (AnchorPoint.transform);

		//Is something spawned already
		if (AttachedBuilding != null) {
			GameObject.Destroy (AttachedBuilding);
			AttachedBuilding = null;
		} else {
			//Spawn it
			if (structureIndex == 1) {
				AttachedBuilding = GameObject.Instantiate (blockStop);

				//Position the spawning block
				AttachedBuilding.transform.position = AnchorPoint.transform.position;
				AttachedBuilding.transform.SetParent (AnchorPoint.transform);
			} else if (structureIndex == 2) {
				AttachedBuilding = GameObject.Instantiate (blockGravityPull);

				//Position the spawning block
				AttachedBuilding.transform.position = AnchorPoint.transform.position;
				AttachedBuilding.transform.SetParent (AnchorPoint.transform);
			} else if (structureIndex == 3) {
				AttachedBuilding = GameObject.Instantiate (blockSpeed);

				//Position the spawning block
				AttachedBuilding.transform.position = AnchorPoint.transform.position;
				AttachedBuilding.transform.SetParent (AnchorPoint.transform);
			} else if (structureIndex == 4) {
				AttachedBuilding = GameObject.Instantiate (blockSlow);

				//Position the spawning block
				AttachedBuilding.transform.position = AnchorPoint.transform.position;
				AttachedBuilding.transform.SetParent (AnchorPoint.transform);
			}
		}
	}
}

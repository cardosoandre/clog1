using UnityEngine;
using System.Collections;

	public class light: MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	// when a player walks into the trigger on this gameobjects
	void OnTriggerEnter(Collider other) {
	// get the light component on this game object, turn it off
		gameObject.GetComponent<Light> ().enabled = false;
}
	void OnTriggerExit(Collider other) {
		// get the light component on this game object, turn it off
		gameObject.GetComponent<Light> ().enabled = true;

}
}
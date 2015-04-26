using UnityEngine;
using System.Collections;

public class NewBehaviourScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		GameObject player = GameObject.Find ("Player");
		GameObject gun = GameObject.Find ("Gun");
		float px = player.transform.position.x;
		float py = player.transform.position.y;
		float pz = player.transform.position.z;
		float dir = player.transform.eulerAngles.y;
		//Vector3 pos = Vector3(px+2, py+1, pz);
		gun.transform.position = new Vector3(px, py, pz);
		gun.transform.eulerAngles = player.transform.eulerAngles;
	}
}

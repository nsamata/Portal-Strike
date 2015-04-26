using UnityEngine;
using System.Collections;

public class Gun : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	

		GameObject player = GameObject.Find ("Player");
		GameObject guy1 = GameObject.Find ("guy2");
		float px = player.transform.position.x;
		float py = player.transform.position.y;
		float pz = player.transform.position.z;
		float dir = player.transform.eulerAngles.y;
		//Vector3 pos = Vector3(px+2, py+1, pz);
		
		guy1.transform.position = new Vector3(px, py, pz);
		guy1.transform.eulerAngles = player.transform.eulerAngles;
	}
}

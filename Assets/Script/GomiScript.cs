using UnityEngine;
using System.Collections;

public class GomiScript : MonoBehaviour {
	public static int gomicount = 0;
	public static int gomicount2 = 0;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(gomicount<=15){
			PlayerScript.sp = 1.0f;
		}
		if(gomicount>15){
			PlayerScript.sp = 0.8f;

		}
		if(gomicount>30){
			PlayerScript.sp = 0.4f;
		}
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.transform.name == "Player") {
			
			Destroy (this.gameObject);
			gomicount++;
		}
	}
}

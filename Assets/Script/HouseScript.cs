using UnityEngine;
using System.Collections;

public class HouseScript : MonoBehaviour {
	public AudioSource helpSound2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnCollisionEnter(Collision other){
		if (other.gameObject.transform.name == "Player") {
			if(GomiScript.gomicount>0){
				helpSound2.Play();
			GomiScript.gomicount2 += GomiScript.gomicount;
			GomiScript.gomicount = 0;
			}
		}
	}
}

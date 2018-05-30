using UnityEngine;
using System.Collections;

public class CameraScript : MonoBehaviour {

	public Transform target;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = target.transform.position + new Vector3 (0, 1, -5);
	}
}

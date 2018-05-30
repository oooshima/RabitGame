using UnityEngine;
using System.Collections;

public class GomiCreateScript : MonoBehaviour {
	public Transform gomi;
	public Transform table;
	// Use this for initialization
	void Start () {
		float var,var2;

		for (int i = 0; i < 15; i++) {
			var = Random.Range (-59.0f, 20.0f);
			var2 = Random.Range (-35.0f, 35.0f);
			Instantiate (gomi, new Vector3 (var, 30, var2), Quaternion.identity);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

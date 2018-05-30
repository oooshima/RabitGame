using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement; 

public class GoalScript : MonoBehaviour {
	public Text sokomade;
	public static float seni = 3.0f;
	// Use this for initialization
	void Start () {
		GetComponent<Canvas>().enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeScript.timeLimit <= 0) {
			GetComponent<Canvas> ().enabled = true;

		}
	}
}

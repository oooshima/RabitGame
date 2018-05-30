using UnityEngine;
using System.Collections;
using UnityEngine.UI;


public class StartCountScript : MonoBehaviour {
	public Text startcount;
	public static float num = 3.0f;




	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (num > 0) {
			num -= Time.deltaTime;
			if (num >= 1.0f) {
				startcount.text = num.ToString ("f0");
			}
		}else {
				startcount.text = " スタート！";
			}

		if (TimeScript.timeLimit < 177.0f && TimeScript.timeLimit > 0) {
			gameObject.SetActive (false);
		} 
	
	}
}

using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TimeScript : MonoBehaviour {
	public Text time;
	public static float timeLimit = 183.0f;


	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
		timeLimit -= Time.deltaTime;
		if (timeLimit < 180.0f && timeLimit > 0.0f) {
				timeLimit -= Time.deltaTime;
				int x = (int)timeLimit / 60;
				time.text = "あと " + x.ToString ("f0") + "分" + (timeLimit - x * 60).ToString ("f0") + "秒";

		} else {
			//Application.LoadLevel ("GameOver");
			//timeLimit = 30.0f;
		}
	}
}

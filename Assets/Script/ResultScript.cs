using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ResultScript : MonoBehaviour {
	public Text resultLabel;
	public Text resultLabel2;
	// Use this for initialization
	void Start () {
		float i = ((float)GomiScript.gomicount2 / 105.0f) * 100.0f;
		resultLabel.text = "部屋の綺麗度 : "+i.ToString("f0")+"%";
		resultLabel2.text = "猫とぶつかった回数 : "+CatScript.count+"回";

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}

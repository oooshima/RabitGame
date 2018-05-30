using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class CountScript : MonoBehaviour {
	public Text count;
	public Text count2;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		count.text = "持ってる数:"+GomiScript.gomicount.ToString ()+"個";
		count2.text = "巣穴にある数:"+GomiScript.gomicount2.ToString ()+"個";
	}
}

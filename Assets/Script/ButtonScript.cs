using UnityEngine;
using System.Collections;

public class ButtonScript : MonoBehaviour {
	public GameObject player;

	bool push = false; // ボタンが押されているか？

	public void StartPush()
	{
		push = true;
	}

	public void StopPush()
	{
		push = false;
	}


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (push) {
			player.transform.position += new Vector3 (0, 0, 1);
		}
	
	}



}

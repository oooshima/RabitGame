using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; 

public class StartButtonScript : MonoBehaviour {
	public AudioSource pageSound;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void StartButton(){
		SceneManager.LoadScene ("Main");
		TimeScript.timeLimit = 183.0f;
		GomiScript.gomicount = 0;
		GomiScript.gomicount2 = 0;
		StartCountScript.num = 3.0f;
	}

	public void ResultButton(){
		SceneManager.LoadScene ("Result");
	}

	public void ikou1Button(){
		
		SceneManager.LoadScene ("setumei1");
	}

	public void ikou2Button(){
		
		SceneManager.LoadScene ("setumei2");
	}

	public void ikou3Button(){
		
		SceneManager.LoadScene ("setumei3");
	}

	public void ikou4Button(){
		
		SceneManager.LoadScene ("setumei4");
	}

	public void ikou5Button(){
		
		SceneManager.LoadScene ("setumei5");
	}

}

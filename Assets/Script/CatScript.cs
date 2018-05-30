using UnityEngine;
using System.Collections;

public class CatScript : MonoBehaviour {

	public Transform target;
	UnityEngine.AI.NavMeshAgent agent;
	public Animator anim;
	public Transform gomi1;
	public Transform gomi2;
	public Transform gomi3;
	public Transform gomi4;
	public Transform gomi5;
	public static int count = 0;
	public AudioSource catSound;

	// Use this for initializ
	void Start () {
		agent = GetComponent<UnityEngine.AI.NavMeshAgent> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (TimeScript.timeLimit < 180.0f && TimeScript.timeLimit > 0) {
			agent.SetDestination (target.position);
			anim.SetTrigger ("walk3");
		}
	}
		


	void OnCollisionEnter(Collision other){
		if (other.gameObject.transform.name == "Player") {
			catSound.Play ();
			count++;
			float var, var2;
			int s = GomiScript.gomicount-5;
			int s2 = 5+s;
			if(s<0){
				GomiScript.gomicount = 0;
				for (int i = 0; i < s2; i++) {
					var = Random.Range (-6.0f, 6.0f);
					var2 = Random.Range (-6.0f, 6.0f);
				int f = Random.Range (1, s2);
				if(f == 1){
					Instantiate (gomi1,  new Vector3(other.gameObject.transform.position.x+var,other.gameObject.transform.position.y+var,other.gameObject.transform.position.z+var2), Quaternion.identity);
				}
				if(f == 2){
					Instantiate (gomi2,  new Vector3(other.gameObject.transform.position.x+var,other.gameObject.transform.position.y+var,other.gameObject.transform.position.z+var2), Quaternion.identity);
				}
				if(f == 3){
					Instantiate (gomi3,  new Vector3(other.gameObject.transform.position.x+var,other.gameObject.transform.position.y+var,other.gameObject.transform.position.z+var2), Quaternion.identity);
				}
				if(f == 4){
					Instantiate (gomi4,  new Vector3(other.gameObject.transform.position.x+var,other.gameObject.transform.position.y+var,other.gameObject.transform.position.z+var2), Quaternion.identity);
				}
				if(f == 5){
					Instantiate (gomi5,  new Vector3(other.gameObject.transform.position.x+var,other.gameObject.transform.position.y+var,other.gameObject.transform.position.z+var2), Quaternion.identity);
				}
				}
			}else{
			GomiScript.gomicount = GomiScript.gomicount - 5;
			float var3, var4;
	        int j;
			for (int i = 0; i < 5; i++) {
				var3 = Random.Range (-6.0f, 6.0f);
				var4 = Random.Range (-6.0f, 6.0f);
				j = Random.Range (1, 5);
				if(j == 1){
				Instantiate (gomi1,  new Vector3(other.gameObject.transform.position.x+var3,other.gameObject.transform.position.y+var3,other.gameObject.transform.position.z+var4), Quaternion.identity);
				}
				if(j == 2){
					Instantiate (gomi2,  new Vector3(other.gameObject.transform.position.x+var3,other.gameObject.transform.position.y+var3,other.gameObject.transform.position.z+var4), Quaternion.identity);
				}
				if(j == 3){
					Instantiate (gomi3,  new Vector3(other.gameObject.transform.position.x+var3,other.gameObject.transform.position.y+var3,other.gameObject.transform.position.z+var4), Quaternion.identity);
				}
				if(j == 4){
					Instantiate (gomi4,  new Vector3(other.gameObject.transform.position.x+var3,other.gameObject.transform.position.y+var3,other.gameObject.transform.position.z+var4), Quaternion.identity);
				}
				if(j == 5){
					Instantiate (gomi5,  new Vector3(other.gameObject.transform.position.x+var3,other.gameObject.transform.position.y+var3,other.gameObject.transform.position.z+var4), Quaternion.identity);
				}
			}
			}
		}
	}
}

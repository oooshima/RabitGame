using UnityEngine;
using System.Collections;
//using UnitySampleAssets.CrossPlatformInput; 


public class PlayerScript : MonoBehaviour {

[SerializeField]
  private Joystick _joystick = null;

  //移動速度
  private const float SPEED = 0.3f;


	public Animator anim;
	public GameObject rabit;
	public AudioSource startSound;
	float x;
	float z;
	public static float sp;
	public AudioSource helpSound;
	Rigidbody rb;
	float Upspeed = 80.0f;
	Vector3 pos;
	int finger_count;
	int jump_count = 0;


	// Use this for initialization
	void Start () {
		startSound.Play ();
		sp = 1.0f;
		rb = this.GetComponent<Rigidbody> ();
	}
	
	// Update is called once per frame
	void Update () {
		finger_count = Input.touchCount;
		Debug.Log(finger_count);
		pos = rabit.transform.position;

    	pos.x += _joystick.Position.x * SPEED * sp;
    	pos.z += _joystick.Position.y * SPEED * sp;

		x = _joystick.Position.x * SPEED;
    	z = _joystick.Position.y * SPEED;

		if (TimeScript.timeLimit < 180.0f && TimeScript.timeLimit > 0) {
			if(x != 0 && z != 0){
			rabit.transform.position = pos;
			rabit.transform.forward = new Vector3 (x, 0, z);  //rabitの向く方向
			anim.SetTrigger ("walk");
			Jump();
			}
			Jump();
		}else{
			anim.SetTrigger ("idol");
		}
	}

	void Jump(){
		if (finger_count >= 2) {
				rb.AddForce(transform.up * Upspeed);
				if (x != 0 || z != 0) {
					anim.SetTrigger ("jump2");		
				}
		}
		anim.SetTrigger ("idol2");
	}

	void OnCollisionEnter(Collision other){
		if (other.gameObject.transform.tag == "gomi") {
			helpSound.Play ();
		}
	}
}

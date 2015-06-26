using UnityEngine;
using System.Collections;

public class PlayerCtrl : MonoBehaviour {
	//private float h = 0.0f;
	private float v = 0.0f;
	
	private Transform tr;
	public float moveSpeed = 5.0f;
	public float rotSpeed = 100.0f;
	
	[System.Serializable]
	public class Anim{
		public AnimationClip idle;
		public AnimationClip runForward;
		public AnimationClip runBackward;
		//public AnimationClip runRight;
		//public AnimationClip runLeft;
	}
	
	public Anim anim;
	public Animation _animation;

	void Start () {
		tr = GetComponent<Transform>();
		_animation = GetComponentInChildren<Animation>();
		
		_animation.clip = anim.idle;
		_animation.Play();
	}
	
	void Update () {
		//h = Input.GetAxis("Horizontal");
		v = Input.GetAxis("Vertical");
		
		Vector3 moveDir = (Vector3.forward * v);
		
		tr.Translate( moveDir * Time.deltaTime * moveSpeed , Space.Self );
		
		tr.Rotate( Vector3.up * Time.deltaTime * rotSpeed * Input.GetAxis("Mouse X"));
		
		if(v >= 0.1f){
			//前進
			_animation.CrossFade(anim.runForward.name, 0.3f);
		}
		else if(v <= -0.1f){
			//後退
			_animation.CrossFade(anim.runBackward.name, 0.3f);
		}
		else {
			//停止
			_animation.CrossFade(anim.idle.name, 0.3f);
		}
		
	}
}

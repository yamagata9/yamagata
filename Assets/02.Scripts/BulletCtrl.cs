using UnityEngine;
using System.Collections;

public class BulletCtrl : MonoBehaviour {

	public int damage = 20;
	public float speed = 300.0f;
	
	public Vector3 firePos = Vector3.zero;
	
	void Start () {
		GetComponent<Rigidbody>().AddForce(transform.forward * speed);
		firePos = GetComponent<Transform>().position;
	}
}

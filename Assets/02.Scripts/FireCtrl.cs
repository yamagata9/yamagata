using UnityEngine;
using System.Collections;

public class FireCtrl : MonoBehaviour {
	public GameObject bullet;
	public Transform firePos;
	public MeshRenderer _renderer;
	
	void Start(){
		_renderer.enabled = false;
	}
	
	void Update(){
		if(Input.GetMouseButtonDown(0)){
			Fire();
		}
	}
	
	void Fire(){
		StartCoroutine(this.CreateBullet());
		StartCoroutine(this.ShowShock());
	}
	
	IEnumerator ShowShock(){
		_renderer.enabled = true;
		
		yield return new WaitForSeconds(Random.Range(0.03f, 0.3f));
		_renderer.enabled = false;
	}
	
	IEnumerator CreateBullet(){
		Instantiate(bullet, firePos.position, firePos.rotation);
		yield return null;
	}
}

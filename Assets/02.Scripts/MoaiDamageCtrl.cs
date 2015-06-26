using UnityEngine;
using System.Collections;

public class MoaiDamageCtrl : MonoBehaviour {
	
	public GameObject burstEffect1;
	public GameObject burstEffect2;
	//public GameObject Aura;
	private Transform tr;
	private int hitCount = 0;
	
	void Start () {
		tr = GetComponent<Transform>();
	}
	
	void OnCollisionEnter(Collision coll){
		if(coll.collider.tag == "BULLET"){
			
			Object obj1 = Instantiate(burstEffect1, tr.position, Quaternion.identity);
			Destroy(obj1, 0.5f);
		
			Destroy(coll.gameObject);
			
			if(++hitCount >= 5){
				StartCoroutine(this.BurstMoai());
			}
		}
	}
	
	IEnumerator BurstMoai(){

		Object obj2 = Instantiate(burstEffect2, tr.position, Quaternion.identity);
		//Object obj3 = Instantiate(Aura, tr.position, Quaternion.identity);
		
		Destroy(obj2, 0.7f);
		//Destroy(obj3, 1.0f);
		Destroy(gameObject, 0.0f);
		yield return null;
	}
}

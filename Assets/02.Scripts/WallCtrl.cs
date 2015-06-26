using UnityEngine;
using System.Collections;

public class WallCtrl : MonoBehaviour {
	public GameObject burstEffect1;
	
	void OnCollisionEnter(Collision coll)
	{
		if(coll.collider.tag == "BULLET")
		{
			Vector3 firePos = coll.gameObject.GetComponent<BulletCtrl>().firePos;
			Vector3 relativePos = firePos - coll.transform.position;
			Object obj = Instantiate(burstEffect1, coll.transform.position, Quaternion.LookRotation(relativePos));
			
			Destroy(obj,0.6f);
			Destroy(coll.gameObject);
		}
	}
}
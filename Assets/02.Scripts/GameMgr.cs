using UnityEngine;
using System.Collections;

public class GameMgr : MonoBehaviour {
	public Transform[] points;
	public GameObject MoaiPrefab;
	public float createTime = 2.0f;
	public int maxMoai = 10;
	public bool isGameOver;
	
	void Start(){
		points = GameObject.Find("SpawnPoint").GetComponentsInChildren<Transform>();
		
		if(points.Length > 0){
			StartCoroutine (this.CreateMoai());
		}
	}
	
	IEnumerator CreateMoai()
	{
		while(!isGameOver)
		{
			int monsterCount = (int) GameObject.FindGameObjectsWithTag("MOAI").Length;
			
			if(monsterCount < maxMoai )
			{
				yield return new WaitForSeconds(createTime);
				
				int idx = Random.Range(1, points.Length);
				Instantiate( MoaiPrefab, points[idx].position, points[idx].rotation);
			}else{
				yield return null;
			}
		}
	}
}

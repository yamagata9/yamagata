using UnityEngine;
using System.Collections;

public class MoaiCtrl : MonoBehaviour {
	
	private Transform moaiTr;
	private Transform playerTr;
	private NavMeshAgent nvAgent;
	
	void Start () {
		moaiTr = this.gameObject.GetComponent<Transform>();
		playerTr = GameObject.FindWithTag("Player").GetComponent<Transform>();
		nvAgent = this.gameObject.GetComponent<NavMeshAgent>();
		
		nvAgent.destination = playerTr.position;
	}
}

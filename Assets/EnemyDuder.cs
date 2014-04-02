using UnityEngine;
using System.Collections;

public class EnemyDuder : MonoBehaviour {
	Rigidbody2D R2D;
	GameObject player;
	// Use this for initialization
	void Start () {
		R2D = GetComponent<Rigidbody2D>();
		player = GameObject.Find("CenterToDefend");
	}
	
	// Update is called once per frame
	void Update () {
		Vector2 toPlayer = (player.transform.position - transform.position).normalized;
		R2D.velocity = 2* toPlayer;
	}
}

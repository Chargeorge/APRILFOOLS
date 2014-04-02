using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour {
	Rigidbody2D r2D;
	float unitsecondSpeedBase = 3f;
	// Use this for initialization
	void Start () {
		r2D = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update () {
		r2D.velocity = new Vector2(unitsecondSpeedBase * Input.GetAxis ("Horizontal"), unitsecondSpeedBase	 * Input.GetAxis ("Vertical"));
		
	}
	
	void OnCollisionEnter2D(){
		Debug.Log("Do Lose Stuff");
	}
}

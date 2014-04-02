using UnityEngine;
using System.Collections;

public class Biggening : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
		
	}
	
	void OnMouseDown(){
		this.transform.parent.localScale*=1.5f;
	}
}

using UnityEngine;
using System.Collections;

public class Closeable : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
//		if(Input.GetButtonDown("Fire1")){
//			Debug.Log ("Mouse Button down");
//			RaycastHit[] hits = Physics.RaycastAll(Camera.main.transform.position, this.transform.position - Camera.main.transform.position);
//			for(int x = 0; x < hits.Length; x++){
//				
//			}
//		}
	
	}
	
	void OnMouseDown(){
		//Do damage/Destroy
		
		Destroy(this.transform.parent.gameObject);
		
	}
}

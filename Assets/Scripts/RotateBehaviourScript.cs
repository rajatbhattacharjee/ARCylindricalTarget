using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotateBehaviourScript : MonoBehaviour {

	// Use this for initialization
	public int yDirection;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		transform.Rotate(new Vector3(0,yDirection,0) * Time.deltaTime);
	}
}

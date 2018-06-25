using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class random : MonoBehaviour {
    public Vector3[] position;
	// Use this for initialization
	void Start () {
		int randomNumber=Random.Range(0,position.Length);
	    transform.position = position[randomNumber];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}

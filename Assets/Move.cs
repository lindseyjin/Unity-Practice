using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 direction = Camera.main.transform.forward;
        float scalar = 10 * Time.deltaTime;

        transform.Translate(direction * scalar); //transform and translate the player
	}
}

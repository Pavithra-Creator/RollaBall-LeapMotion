using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpherePoints : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.name == "Player")
        {
            KeepScore.Score += 1;
            Destroy(gameObject);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour {
    public Material[] material;
    Renderer rend;
	// Use this for initialization
	void Start () {
        rend = GetComponent<Renderer>();
        rend.enabled = true;
        rend.sharedMaterial = material[0];
	}
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "color")
        {
            rend.sharedMaterial = material[1];
        }
    }
	
	/*// Update is called once per frame
	void Update () {
		
	}*/
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickup : MonoBehaviour {

    public GameObject Cube;
    public GameObject Cube1;
    public GameObject Cube2;
    public GameObject Cube3;


    void OnTriggerEnter(Collider collider)
    {
        //First Cube 
        if (collider.gameObject.tag == "player" && gameObject.tag == "cube")
        {
            Cube.SetActive(false);
            Cube1.SetActive(true);
            Cube3.SetActive(true);

        }
        //Second Cube
        if (collider.gameObject.tag == "player" && gameObject.tag == "cube1")
        {

            Cube1.SetActive(false);
            Cube2.SetActive(true);
            Cube.SetActive(true);
            Cube3.SetActive(false);
        }
        if (collider.gameObject.tag == "player" && gameObject.tag == "cube2")
        {
            Cube2.SetActive(false);
            Cube3.SetActive(true);
            Cube1.SetActive(true);
            Cube.SetActive(false);
        }
        if (collider.gameObject.tag == "player" && gameObject.tag == "cube3")
        {
            Cube.SetActive(true);
            Cube1.SetActive(true);
            Cube2.SetActive(true);
            Cube3.SetActive(true);


        }



    }

}

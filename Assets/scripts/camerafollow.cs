using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Experimental.UIElements;

public class camerafollow : MonoBehaviour {

    public Transform target ;
    Camera mycam;
	void Start () {

        mycam = GetComponent <Camera>();
		
	}
	void Update () {
                
        mycam.orthographicSize = (Screen.height / 100f) / 1.5f;


        if (target) // if target exists
        {
            //transform the position of mycam to the position of the target 
            transform.position = Vector3.Lerp(transform.position, target.position, 0.1f) + new Vector3 (0,0, -10);

        }



		
	}
}


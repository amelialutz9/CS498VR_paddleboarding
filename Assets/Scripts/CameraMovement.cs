using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public GameObject paddleboardObj;
	// Use this for initialization
	void Start () {
		//transform.SetAsLastSibling(); //move to the front (on parent)
	}
	
	// Update is called once per frame
	void Update () {
        transform.position = paddleboardObj.transform.position;
        Vector3 forward = paddleboardObj.transform.forward;
        transform.forward = forward;
        Vector3 correction = transform.rotation.eulerAngles;
        correction += new Vector3(0, -90, 0);
        transform.rotation = Quaternion.Euler(correction);
    }
}

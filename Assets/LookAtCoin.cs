using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAtCoin : MonoBehaviour {
	public GameObject[] gotargets;
	public Transform[] ttargets;

	public GameObject reddot;
	GameObject curTarget;

	int count;

	// Use this for initialization
	void Start () {
		count = 0;
		curTarget = gotargets[count];
	}
	
	// Update is called once per frame
	void Update () {		
 
		{
			count++;
            if (count >= gotargets.Length) {
				count = gotargets.Length - 1;
			}
			curTarget = gotargets[count];
		}

		Vector3 relativePos = ttargets[count].position - this.transform.position;
		Quaternion tempQuat = Quaternion.LookRotation(relativePos);
		Quaternion tempFloat = this.transform.rotation;
		this.transform.rotation = Quaternion.LookRotation(relativePos);
		this.transform.position = reddot.transform.position + new Vector3(50, 50, 80);

	}
}

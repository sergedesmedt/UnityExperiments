﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EulerRotateY : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        this.transform.localEulerAngles = new Vector3(0, 30, 0);
    }
}

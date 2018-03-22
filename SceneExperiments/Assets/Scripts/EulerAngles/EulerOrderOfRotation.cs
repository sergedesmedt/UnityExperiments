using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// https://en.wikipedia.org/wiki/Euler_angles
public class EulerOrderOfRotation : MonoBehaviour {

    float _startX = 0.0f;
    float _startY = 0.0f;
    float _startZ = 0.0f;

    // Use this for initialization
    void Start () {
        this.transform.localEulerAngles = new Vector3(_startX, _startY, _startZ);
    }

    // Update is called once per frame
    void Update () {
        // From the UNity documentation
        // The x, y, and z angles represent a rotation 
        //      z degrees around the z axis, 
        //      x degrees around the x axis, and 
        //      y degrees around the y axis
        // !!!  (in that order).  !!!

        // Order of rotation is important for eulerangles, which is why it is explicitely mentioned in the Unity documentation

        // think what this should give when we first rotate around the Y axis and then around the Z axis
        // now, look at what we got: this clearly firts rotated around the Z axis and then around the Y axis
        this.transform.localEulerAngles = new Vector3(0, 30, 45);

    }

}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionDetection : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("OnCollisionEnter: collided with > " + collision.gameObject.name);
        Debug.Log("OnCollisionEnter: Nof contact points > " + collision.contacts.Length);
        Debug.Log("OnCollisionEnter: impulse > " + collision.impulse);
        Debug.Log("OnCollisionEnter: relative velocity > " + collision.relativeVelocity);
    }

    //private void OnCollisionStay(Collision collision) {
    //    Debug.Log("OnCollisionStay: " + collision.gameObject.name);
    //}

    //private void OnCollisionExit(Collision collision) {
    //    Debug.Log("OnCollisionExit: " + collision.gameObject.name);
    //}

    //private void OnTriggerEnter(Collider other) {
    //    Debug.Log("OnTriggerEnter: " + other.gameObject.name);
    //}

    //private void OnTriggerStay(Collider other) {
    //    Debug.Log("OnTriggerStay: " + other.gameObject.name);
    //}

    //private void OnTriggerExit(Collider other) {
    //    Debug.Log("OnTriggerExit: " + other.gameObject.name);
    //}
}

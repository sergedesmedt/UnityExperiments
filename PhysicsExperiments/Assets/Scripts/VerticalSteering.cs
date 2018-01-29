using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class VerticalSteering : MonoBehaviour {

    public Rigidbody rb;

    // Use this for initialization
    void Start() {
        rb = this.GetComponent<Rigidbody>();
    }

    private Vector3 GetTranslation(float deltaTime) {
        Vector3 translation = Vector3.zero;
        if (Input.GetKey(KeyCode.UpArrow)) {
            translation = (Vector3.up * deltaTime);
        }
        if (Input.GetKey(KeyCode.DownArrow)) {
            translation = (Vector3.down * deltaTime);
        }

        return translation;
    }

    //private void FixedUpdate() {
    //    rb.MovePosition(transform.position + GetTranslation(Time.fixedDeltaTime));
    //    if (Input.GetKey(KeyCode.P)) {
    //        rb.MovePosition(new Vector3(0, 1, 0));
    //    }
    //    if (Input.GetKey(KeyCode.V)) {
    //        rb.velocity = new Vector3(0, 0, 10);
    //    }
    //}

    // Update is called once per frame
    void Update() {
        this.transform.Translate(GetTranslation(Time.deltaTime));
    }

    private void OnCollisionEnter(Collision collision) {
        Debug.Log("OnCollisionEnter: collided with > " + collision.gameObject.name);
        Debug.Log("OnCollisionEnter: Nof contact points > " + collision.contacts.Length);
        Debug.Log("OnCollisionEnter: impulse > " + collision.impulse);
        Debug.Log("OnCollisionEnter: relative velocity > " + collision.relativeVelocity);
    }

    //private void OnCollisionStay(Collision collision) {
    //    Debug.Log("OnCollisionStay");
    //}

    //private void OnCollisionExit(Collision collision) {
    //    Debug.Log("OnCollisionExit");
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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuaternionAnimation : MonoBehaviour {

    bool _doAnimation = false;
    bool _setExtremes = false;

    float _startValue = 1.0f;
    float _endValue = 0.0f;
    float _delta = -1.0f;

    static float t = 0.0f;

    // Use this for initialization
    void Start () {
        this.transform.rotation.Set(1, 0, 0, _startValue);
        StartAnimation();
    }
	
	// Update is called once per frame
	void Update () {

        if (!_doAnimation)
            return;

        if (_setExtremes) {
            //_startValue = this.transform.eulerAngles.y;
            //_startValue = this.transform.rotation.w;
            _endValue = _startValue + _delta;

            _setExtremes = false;
        }

        //this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, Mathf.Lerp(_startValue, _endValue, t), this.transform.eulerAngles.z);
        float xAnimation = Mathf.Lerp(_startValue, _endValue, t);
        Quaternion newQuat = new Quaternion();
        newQuat.Set(1, 0, 0, xAnimation);
        Debug.Log("newQuat: " + newQuat.ToString());
        this.transform.rotation = newQuat;
        Debug.Log("xAnimation: " + xAnimation.ToString() + ", Rotation: " + this.transform.rotation.ToString());
        //this.transform.RotateAround(transform.position, transform.up, Mathf.Lerp(_startValue, _endValue, t));

        t += 0.5f * Time.deltaTime;
        if (t > 1.0f) {
            StopAnimation();
        }
    }

    public void StartAnimation() {
        _doAnimation = true;
        _setExtremes = true;
    }

    public void StopAnimation() {
        _doAnimation = false;
    }
}

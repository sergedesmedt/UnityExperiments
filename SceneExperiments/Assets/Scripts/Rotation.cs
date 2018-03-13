using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour {

    bool _doAnimation = false;
    bool _setExtremes = false;

    float _startValue = 0.0f;
    float _endValue = 90.0f;
    float _distance = 90.0f;

    static float t = 0.0f;

    // Use this for initialization
    void Start () {
        StartAnimation();
    }

    // Update is called once per frame
    void Update () {

        if (!_doAnimation)
            return;

        if (_setExtremes) {
            //_startValue = this.transform.eulerAngles.y;
            _startValue = this.transform.localEulerAngles.y;
            _endValue = _startValue + _distance;

            _setExtremes = false;
        }

        //this.transform.eulerAngles = new Vector3(this.transform.eulerAngles.x, Mathf.Lerp(_startValue, _endValue, t), this.transform.eulerAngles.z);
        this.transform.localEulerAngles = new Vector3(this.transform.localEulerAngles.x, Mathf.Lerp(_startValue, _endValue, t), this.transform.localEulerAngles.z);

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

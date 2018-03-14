using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour {

    bool _doAnimation = false;
    bool _setExtremes = false;

    float _startValue = 0.0f;
    float _endValue = 2.0f;
    float _scale = 2.0f;

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
            _startValue = this.transform.localScale.y;
            _endValue = _startValue + _scale;

            _setExtremes = false;
        }

        this.transform.localScale = new Vector3(this.transform.localScale.x, Mathf.Lerp(_startValue, _endValue, t), this.transform.localScale.z);

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

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Translate : MonoBehaviour {

    bool _doAnimation = false;
    bool _setExtremes = false;

    float _startValue = 0.0f;
    float _endValue = 3.0f;
    float _distance = 3.0f;

    static float t = 0.0f;

    // Use this for initialization
    void Start () {
        StartAnimation();
    }
	
	// Update is called once per frame
	void Update () {

        if (!_doAnimation)
            return; 

        if(_setExtremes) {
            //_startValue = this.transform.position.x;
            _startValue = this.transform.localPosition.x;
            _endValue = _startValue + _distance;

            _setExtremes = false;
        }

        //this.transform.position = new Vector3(Mathf.Lerp(_startValue, _endValue, t), this.transform.position.y, this.transform.position.z);
        this.transform.localPosition = new Vector3(Mathf.Lerp(_startValue, _endValue, t), this.transform.localPosition.y, this.transform.localPosition.z);

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

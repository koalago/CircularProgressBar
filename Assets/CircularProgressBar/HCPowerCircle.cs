using UnityEngine;
using System.Collections;

public class HCPowerCircle : MonoBehaviour {

    public Transform redTrans;
    public Transform blueTrans;
    public Transform greenTrans;

	public float tmp = 0.5f;

	public bool _test = true;
	// Use this for initialization
	void Start () {
	
	}

	// Update is called once per frame
	void Update () {
		if (_test == true) {
			
			SetGreenValue (tmp);
			SetRedValue (tmp);
			SetBlueValue (tmp);
		}

    }


    /// <summary>
    /// green interface
    /// </summary>
    /// <param name="value"> 0-1.0 </param>
    public void SetGreenValue(float value) {
        value = Mathf.Clamp01(value);
        float t = 120 - (value * 120);
        greenTrans.transform.localEulerAngles = Vector3.forward * t;
    }
    /// <summary>
    /// red interface
    /// </summary>
    /// <param name="value"> 0-1.0 </param>
    public void SetRedValue(float value) {
        value = Mathf.Clamp01(value);
        float t = 120 - (value * 120);
        redTrans.transform.localEulerAngles = Vector3.forward * t;
    }
    /// <summary>
    /// blue interface
    /// </summary>
    /// <param name="value"> 0-1 </param>
    public void SetBlueValue(float value) {
        value = Mathf.Clamp01(value);
        float t = 120 - (value * 120);
        blueTrans.transform.localEulerAngles = Vector3.forward * t;
    }
}

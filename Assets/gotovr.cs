using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;

public class gotovr : MonoBehaviour {


	void Start () {
		StartCoroutine(startvr("Cardboard"));
	}
	
	public IEnumerator startvr(string vr)
	{
		XRSettings.LoadDeviceByName (vr);
		yield return null;
		XRSettings.enabled = true;
	}
}

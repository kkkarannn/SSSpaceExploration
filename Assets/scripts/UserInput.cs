using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	SpacecraftControl spacecraftControl;
	[Range(0f,1f)]
	public float throttle;

	void Start () 
	{
		spacecraftControl = GetComponent<SpacecraftControl> ();
	}
	

	void FixedUpdate () 
	{
		float roll = Input.GetAxis("Vertical");
		float pitch = Input.GetAxis("Horizontal");
		bool airBrakes = Input.GetButton("Fire1");


		spacecraftControl.Move(roll,pitch,0,throttle,airBrakes) ;
	}


}

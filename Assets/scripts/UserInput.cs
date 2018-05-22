using UnityEngine;
using System.Collections;

public class UserInput : MonoBehaviour {

	SpacecraftControl spacecraftControl;
	[Range(0f,1f)]
	public float throttle;
	public bool airBrakes;


	void Start () 
	{
		spacecraftControl = GetComponent<SpacecraftControl> ();
	}
	

	void FixedUpdate () 
	{
		float roll = Input.GetAxis("Vertical");
		float pitch = Input.GetAxis("Horizontal");


		if (Input.GetKey(KeyCode.JoystickButton5)) 
		{
			throttle = 1f;
		
		} 
		else 
		{
			throttle = -0.5f;

		}
		if (Input.GetKey(KeyCode.JoystickButton4)) 
		{
			airBrakes = true;

		} 
		else 
		{
			airBrakes = false;

		}
			
		spacecraftControl.Move(roll,pitch,0,throttle,airBrakes) ;
	}


}

using UnityEngine;
using System.Collections;
using CnControls;

public class CharacterMovement : MonoBehaviour {

	public float speed = 3.0F;
	public float rotateSpeed = 1.0F;

	void Update() {
		CharacterController controller = GetComponent<CharacterController>();
		transform.Rotate(0, CnInputManager.GetAxis("LookHor") * rotateSpeed, 0);
		transform.FindChild("Camera").transform.Rotate(-CnInputManager.GetAxis("LookVert") * rotateSpeed,0, 0);
		Vector3 forward = transform.TransformDirection(Vector3.forward);
		float curSpeed = speed * CnInputManager.GetAxis("Vertical"); 
		controller.SimpleMove(forward * curSpeed);
		Vector3 right = transform.TransformDirection(Vector3.right);
		float rightSpeed = speed * CnInputManager.GetAxis("Horizontal");
		controller.SimpleMove(right*rightSpeed);
	}
}

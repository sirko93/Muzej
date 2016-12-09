using UnityEngine;
using System.Collections;

public class VRMovement : MonoBehaviour {

	public float speed = 11.0F;
	//public float speed = 0.5F;
	public float rotateSpeed = 3.0F;
	private bool isMoving=false;
	CharacterController controller;
	void Start()
	{
		controller = GetComponent<CharacterController>();
	}
	void Update() {
		if (isMoving) {
			Vector3 forward = transform.FindChild("CardboardMain").FindChild ("Head").TransformDirection (Vector3.forward);
			controller.SimpleMove (forward * speed);

		}
	}
	public void Move()
	{
		isMoving = !isMoving;
	}
}

using UnityEngine;

public class FreeFlyCamera : MonoBehaviour
{
	float sensitivity = 1.8f;
	float translationSpeed = 55f;
	float movementSpeed = 10f;
	float boostedSpeed = 50f;
	KeyCode boostSpeed = KeyCode.LeftShift;
	KeyCode moveUp = KeyCode.E;
	KeyCode moveDown = KeyCode.Q;
	bool enableSpeedAcceleration = true;
	float speedAccelerationFactor = 1.5f;

	float currentIncrease = 1;
	float currentIncreaseMem = 0;


	public void LockCursor(bool enabled)
	{
		if (enabled)
		{
			Cursor.lockState = CursorLockMode.None;
			Cursor.visible = true;
		}
		else
		{
			Cursor.lockState = CursorLockMode.Locked;
			Cursor.visible = false;
		}	
	}

	public void Increase(bool moving)
	{
		currentIncrease = Time.deltaTime;

		if (!enableSpeedAcceleration || enableSpeedAcceleration && !moving)
		{
			currentIncreaseMem = 0;
			return;
		}

		currentIncreaseMem += Time.deltaTime * (speedAccelerationFactor - 1);
		currentIncrease = Time.deltaTime + Mathf.Pow(currentIncreaseMem, 3) * Time.deltaTime;
	}

	public void Update()
	{
		transform.Translate(Vector3.forward * Input.mouseScrollDelta.y * Time.deltaTime * translationSpeed);
		
			Vector3 deltaPosition = Vector3.zero;
			float currentSpeed = movementSpeed;

			if (Input.GetKey(boostSpeed))
				currentSpeed = boostedSpeed;

			if (Input.GetKey(KeyCode.W))
				deltaPosition += transform.forward;

			if (Input.GetKey(KeyCode.S))
				deltaPosition -= transform.forward;

			if (Input.GetKey(KeyCode.A))
				deltaPosition -= transform.right;

			if (Input.GetKey(KeyCode.D))
				deltaPosition += transform.right;

			if (Input.GetKey(moveUp))
				deltaPosition += transform.up;

			if (Input.GetKey(moveDown))
				deltaPosition -= transform.up;

		Increase(deltaPosition != Vector3.zero);

			transform.position += deltaPosition * currentSpeed * currentIncrease;
		

			transform.rotation *= Quaternion.AngleAxis(
				-Input.GetAxis("Mouse Y") * sensitivity,
				Vector3.right
			);
			
			transform.rotation = Quaternion.Euler(
				transform.eulerAngles.x,
				transform.eulerAngles.y + Input.GetAxis("Mouse X") * sensitivity,
				transform.eulerAngles.z
			);
		
	}
}

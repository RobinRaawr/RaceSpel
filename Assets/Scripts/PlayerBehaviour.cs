using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : MonoBehaviour
{
	Vector3 spawnPosition;
	Quaternion spawnRotation;

	void Start()
	{
		Rigidbody rigidbodyRef = GetComponent<Rigidbody>();

		spawnPosition = transform.position;
		spawnRotation = transform.rotation;
	}

	public void GoToSpawnPosition()
	{
		Rigidbody rigidbodyRef = GetComponent<Rigidbody>();

		rigidbodyRef.position = spawnPosition;
		rigidbodyRef.rotation = spawnRotation;

		rigidbodyRef.velocity = Vector3.zero;
		GetComponent<Rigidbody>().angularVelocity = Vector3.zero;
	}
}

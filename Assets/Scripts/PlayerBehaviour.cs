using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody))]
public class PlayerBehaviour : RaceGameBehaviour
{
	Vector3 spawnPosition;
	Quaternion spawnRotation;

	void Start()
	{
		Rigidbody rigidbodyRef = rigidbody;

		spawnPosition = transform.position;
		spawnRotation = transform.rotation;
	}

	public void GoToSpawnPosition()
	{
		Rigidbody rigidbodyRef = rigidbody;

		rigidbodyRef.position = spawnPosition;
		rigidbodyRef.rotation = spawnRotation;

		rigidbodyRef.velocity = Vector3.zero;
		rigidbody.angularVelocity = Vector3.zero;
	}
}

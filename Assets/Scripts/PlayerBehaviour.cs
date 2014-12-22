using UnityEngine;
using System.Collections;

public class PlayerBehaviour : RaceGameBehaviour
{
	Vector3 spawnPosition;

	void Start()
	{
		spawnPosition = transform.position;
	}

	public void GoToSpawnPosition()
	{
		spawnPosition = transform.position;
	}
}

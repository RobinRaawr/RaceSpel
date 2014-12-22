using UnityEngine;
using System.Collections;

public abstract class RaceGameBehaviour : MonoBehaviour
{
	protected RaceGameManager GameManager
	{
		get;
		private set;
	}

	void Awake()
	{
		GameManager = MonoBehaviour.FindObjectOfType<RaceGameManager>();
	}
}

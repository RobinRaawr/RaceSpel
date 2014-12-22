using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RaceGameManager : MonoBehaviour
{
	public Button restartButton;

	void OnJoinedRoom()
	{
		if (PhotonNetwork.isMasterClient)
			restartButton.enabled = true;
		else
			restartButton.enabled = false;
	}

	public void RestartRace()
	{
		foreach (PlayerBehaviour e in GameObject.FindObjectsOfType<PlayerBehaviour>())
			e.GoToSpawnPosition();
	}
}

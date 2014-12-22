using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class RaceGameManager : MonoBehaviour
{
	public Button restartButton;

	void OnJoinedRoom()
	{
		if (PhotonNetwork.isMasterClient)
			restartButton.gameObject.SetActive(true);
		else
			restartButton.gameObject.SetActive(false);
	}

	public void RestartRace()
	{
		int c = 0;

		foreach (PlayerBehaviour e in MonoBehaviour.FindObjectsOfType<PlayerBehaviour>())
		{
			e.GoToSpawnPosition();
			c++;
		}

		Debug.Log(
			"Restarting race...\n" +
			"Number of players found: " + c);
	}
}

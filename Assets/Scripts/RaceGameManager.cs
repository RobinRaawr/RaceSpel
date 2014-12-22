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
		PlayerBehaviour[] playerList = MonoBehaviour.FindObjectsOfType<PlayerBehaviour>();

		foreach (PlayerBehaviour e in playerList)
		{
			e.GoToSpawnPosition();
		}

		Debug.Log(
			"Restarting race...\n" +
			"Number of players found: " + playerList.Length);
	}
}

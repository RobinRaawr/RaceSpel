using UnityEngine;
using System.Collections;

public class RandomMatchMaker : MonoBehaviour {

	void Start () 
    {
        PhotonNetwork.ConnectUsingSettings("0.1");	
	}
	
	void Update () 
    {
        Debug.Log(PhotonNetwork.connectionStateDetailed.ToString());	
	}

    void OnJoinedLobby() // It’s called when PUN got you into a lobby.
    {
        PhotonNetwork.JoinRandomRoom();
    }
    void OnPhotonRandomJoinFailed()
    {
        Debug.Log("Can't join random room!");
        PhotonNetwork.CreateRoom(null); // null means a random name. ATM we dont care about naming a room.
    }

    void OnJoinedRoom()
    {
        GameObject car = PhotonNetwork.Instantiate("Basic Car Model", Vector3.zero, Quaternion.identity, 0);
        // Don’t mix it up with Unity’s Instantiate or Network.Instantiate. This makes sure the view gets instantiated on the other clients, too.

        HoverMotor controller = car.GetComponent<HoverMotor>();
        controller.enabled = true;

        NetworkCharacter character = car.GetComponent<NetworkCharacter>();
        character.enabled = false;

        Camera cam = car.GetComponentInChildren<Camera>();
        cam.enabled = true;

        // Misschien is dit niet handig, maar goed for now.
        cam.GetComponent<AudioListener>().enabled = false;


    }
}

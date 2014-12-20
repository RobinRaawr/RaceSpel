using UnityEngine;
using System.Collections;

public class NetworkCharacter : Photon.MonoBehaviour {

    Vector3 realPosition = Vector3.zero;
    Quaternion realRotation = Quaternion.identity;

    public float lerpValue = 0.1f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void FixedUpdate () {

        if (photonView.isMine)
        {
            // Do nothing. -- the character motor/input etc is moving us.
        }
        else
        {
            transform.position = Vector3.Lerp(transform.position, realPosition, lerpValue);
            transform.rotation = Quaternion.Lerp(transform.rotation, realRotation, lerpValue);
        }
	
	}

    public void OnPhotonSerializeView(PhotonStream stream, PhotonMessageInfo info)
    {
        if (stream.isWriting)
        { // This is OUR player, send our actual position to the network
            stream.SendNext(transform.position);
            stream.SendNext(transform.rotation);
        }
        else
        { // this is someone elses player. receive their position
            realPosition = (Vector3)stream.ReceiveNext();
            realRotation = (Quaternion)stream.ReceiveNext();
        }
    }
}

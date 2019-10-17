using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LobbyNewtork : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Connecting to server....");
        PhotonNetwork.ConnectUsingSettings("v001");
    }

    private void OnConnectedToMaster()
    {
        Debug.Log("Connected to Master Successfully");
        PhotonNetwork.playerName = PlayerNetwork.Instance.PlayerName;

        PhotonNetwork.JoinLobby(TypedLobby.Default);
    }

    private void OnJoinedLobby()
    {
        Debug.Log("Oh dip! We joined a lobby");
    }
}

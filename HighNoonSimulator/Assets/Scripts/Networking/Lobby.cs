using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//using Photon.Pun;
//using Photon.Realtime;

//namespace Photon.Pun.Demo.PunBasics
//{


//public class Lobby : MonoBehaviour
//{
//    private string playerName, roomName;
//    public GameObject lobby;
//    public GameObject buttonLoadArena;
//    public GameObject buttonJoinRoom;
//    // Start Method
//    void Start()
//    {
//        //1
//        PlayerPrefs.DeleteAll();

//        Debug.Log("Connecting to Photon Network");

//        //2
//        lobby.SetActive(false);
//        buttonLoadArena.SetActive(false);

//        //3
//        ConnectToPhoton();
//    }

//    void Awake()
//    {
//        //4 
//        PhotonNetwork.AutomaticallySyncScene = true;
//    }
//    public void SetPlayerName(string name)
//    {
//        playerName = name;
//    }

//    public void SetRoomName(string name)
//    {
//        roomName = name;
//    }
//    void ConnectToPhoton()
//    {
//        connectionStatus.text = "Connecting...";
//        PhotonNetwork.GameVersion = "v0001"; //1
//        PhotonNetwork.ConnectUsingSettings(); //2
//    }
//    public void JoinRoom()
//    {
//        if (PhotonNetwork.IsConnected)
//        {
//            PhotonNetwork.LocalPlayer.NickName = playerName; //1
//            Debug.Log("PhotonNetwork.IsConnected! | Trying to Create/Join Room " +
//                roomNameField.text);
//            RoomOptions roomOptions = new RoomOptions(); //2
//            TypedLobby typedLobby = new TypedLobby(roomName, LobbyType.Default); //3
//            PhotonNetwork.JoinOrCreateRoom(roomName, roomOptions, typedLobby); //4
//        }
//    }

//    public void LoadArena()
//    {
//        // 5
//        if (PhotonNetwork.CurrentRoom.PlayerCount > 1)
//        {
//            PhotonNetwork.LoadLevel("Main");
//        }
//        else
//        {
//            playerStatus.text = "Minimum 2 Players required to Load Arena!";
//        }
//    }
//}
//}

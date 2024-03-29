﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLayoutGroup : MonoBehaviour
{
    
    [SerializeField]
    private GameObject _PlayerListingPrefab;
    private GameObject PlayerListingPrefab
    {
        get
        {
            return _PlayerListingPrefab;
        }
    }

    private List<PlayerListing>_playerListings = new List<PlayerListing>();
    private List<PlayerListing> PlayerListings
    {
        get { return _playerListings; }
    }

    //Called by photon whenever you join a room
    private void OnJoinedRoom()
    {
         MainCanvasManager.Instance.CurrentRoomCanvas.transform.SetAsLastSibling();
      
      
        PhotonPlayer[] photonPlayers = PhotonNetwork.playerList;
        for(int i = 0; i < photonPlayers.Length; i++)
        {
            PlayerJoinedRoom(photonPlayers[i]);
        }
    }

    private void OnPhotonPlayerConnected(PhotonPlayer photonPlayer)
    {
        PlayerJoinedRoom(photonPlayer);
    }
    //Called by photon when a player leaves the room.
    private void OnPhotonPlayerDisconnected(PhotonPlayer photonPlayer)
    {
        PlayerLeftRoom(photonPlayer);
    }

    private void PlayerJoinedRoom(PhotonPlayer photonPlayer)
    {
        if(photonPlayer == null)
        {
            return;
        }

        PlayerLeftRoom(photonPlayer);

        GameObject playerListingObj = Instantiate(PlayerListingPrefab);
        playerListingObj.transform.SetParent(transform, false);

        PlayerListing playerListing = playerListingObj.GetComponent<PlayerListing>();
        playerListing.ApplyPhotonPlayer(photonPlayer);

        PlayerListings.Add(playerListing);
    }

    private void PlayerLeftRoom(PhotonPlayer photonPlayer)
    {
        int index = PlayerListings.FindIndex(x => x.PhotonPlayer == photonPlayer);
        if(index != -1)
        {
            Destroy(PlayerListings[index].gameObject);
            PlayerListings.RemoveAt(index);
        }
    }
    public void OnClickRoomState()
    {
        if (PhotonNetwork.isMasterClient)
        {
            PhotonNetwork.room.IsOpen = !PhotonNetwork.room.IsOpen;
            PhotonNetwork.room.IsVisible = PhotonNetwork.room.IsOpen;
        }
        else
        {
            return;
        }
      
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerListing : MonoBehaviour
{
    public PhotonPlayer PhotonPlayer { get; private set; }

    [SerializeField]
    private Text _PlayerName;
    private Text PlayerName
    {
        get
        {
        return _PlayerName;
        }
    }

        public void ApplyPhotonPlayer(PhotonPlayer photonPlayer)
    {
        PlayerName.text = photonPlayer.NickName;
    }
}

﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomLayoutGroup : MonoBehaviour
{
    [SerializeField]
    private GameObject _rommListingPrefab;
    private GameObject RoomListingPrefab
    {
        get { return _rommListingPrefab; }
    }
}

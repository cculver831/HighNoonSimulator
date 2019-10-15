using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Char_Select : MonoBehaviour
{
    public GameObject PlayerSelect;
    public GameObject LobbyUI;

    public void Play()
    {
        PlayerSelect.SetActive(false);
        LobbyUI.SetActive(true);

    }
}

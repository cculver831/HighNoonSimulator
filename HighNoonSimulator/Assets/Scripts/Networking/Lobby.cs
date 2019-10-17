
using UnityEngine;



//Asks a Don't Destroy Script so the networking scripts Do not Delete upon entering a new scene/
// Every child object attatched to an object with this script will not be destroyed


public class Lobby : MonoBehaviour
{

    private void Awake()
    {
        DontDestroyOnLoad(this);
    }

}


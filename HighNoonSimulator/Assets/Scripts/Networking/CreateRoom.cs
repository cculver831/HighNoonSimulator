using UnityEngine.UI;
using UnityEngine;

public class CreateRoom : MonoBehaviour
{
    [SerializeField]
    private Text _roomName;
    private Text RoomName
    {
        get { return _roomName; }
    }

    public void OnClick_CreateRoom()
    {
        RoomOptions roomOptions = new RoomOptions() { isVisible = true, IsOpen = true, MaxPlayers = 6 };
        if (PhotonNetwork.CreateRoom(RoomName.text, roomOptions, TypedLobby.Default))
        {
            Debug.Log("Create Room Succsefully Sent");
        }
        else
        {
            Debug.Log("Room not Created");
        }
    }
    private void OnPhotonCreateRoomFailed(object[] codeAndMessage)
    {
        Debug.Log("Create Room failed: " + codeAndMessage[1]);
    }

    private void OnCreateRoom()
    {
        Debug.Log("Room Created Successfully!");
    }
}

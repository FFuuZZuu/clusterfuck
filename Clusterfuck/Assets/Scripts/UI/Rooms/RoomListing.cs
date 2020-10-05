using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

public class RoomListing : MonoBehaviour
{
    [SerializeField] private TMP_Text text;

    public RoomInfo RoomInfo { get; private set; }
    
    public void SetRoomInfo(RoomInfo roomInfo)
    {
        RoomInfo = roomInfo;
        text.text = roomInfo.Name;
    }

    public void OnClick_JoinGame()
    {
        PhotonNetwork.JoinRoom(RoomInfo.Name);
        PhotonNetwork.LoadLevel(1);
    }
}

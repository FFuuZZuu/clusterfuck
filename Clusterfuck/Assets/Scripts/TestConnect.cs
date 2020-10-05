using System.Collections;
using System.Collections.Generic;
using DebugConsole;
using Photon.Pun;
using Photon.Realtime;
using UnityEngine;

public class TestConnect : MonoBehaviourPunCallbacks
{
    // Called on script start
    private void Start()
    {
        Debug.Log("Connecting to server.");
        PhotonNetwork.AutomaticallySyncScene = true;
        PhotonNetwork.NickName = GameManager.Instance.username;
        PhotonNetwork.GameVersion = GameManager.Instance.gameVersion;
        PhotonNetwork.ConnectUsingSettings();
    }

    public override void OnConnectedToMaster()
    {
        Debug.Log("Connected to server.");

        PhotonNetwork.JoinLobby();
    }

    public override void OnDisconnected(DisconnectCause cause)
    {
        Debug.Log($"Disconnected from server for reason: {cause.ToString()}");
    }
}

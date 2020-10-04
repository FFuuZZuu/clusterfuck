using Photon.Pun;
using Photon.Realtime;
using TMPro;
using UnityEngine;

namespace UI.Rooms
{
    public class CreateRoom : MonoBehaviourPunCallbacks
    {
        [SerializeField] private TMP_InputField roomName;
        [SerializeField] private byte maxPlayers;

        public void OnClick_CreateRoom()
        {
            if (!PhotonNetwork.IsConnected)
                return;
            
            RoomOptions options = new RoomOptions();
            options.MaxPlayers = maxPlayers;
            PhotonNetwork.JoinOrCreateRoom(roomName.text, options, TypedLobby.Default);
        }

        public override void OnCreatedRoom()
        {
            Debug.Log($"Created room successfully.");
        }

        public override void OnCreateRoomFailed(short returnCode, string message)
        {
            Debug.Log($"Room creation failed: {message}");
        }
    }
}
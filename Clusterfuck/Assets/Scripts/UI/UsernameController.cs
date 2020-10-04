using System.Collections;
using System.Collections.Generic;
using Photon.Pun;
using TMPro;
using UnityEngine;

namespace UI
{
    public class UsernameController : MonoBehaviour
    {
        [SerializeField] private TMP_InputField username;
        
        public void ChangeUsername()
        {
            GameManager.Instance.username = username.text;
            PhotonNetwork.NickName = GameManager.Instance.username;
            Debug.Log(PhotonNetwork.NickName);
        }
    }
}

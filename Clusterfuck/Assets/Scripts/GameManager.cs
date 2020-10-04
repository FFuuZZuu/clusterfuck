using System.Collections;
using System.Collections.Generic;
using DebugConsole;
using JetBrains.Annotations;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    #region Variables
    
    public string gameVersion = "0.0.0";
    public string username;
    
    #endregion

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }

        int num = Random.Range(0, 9999);
        username = $"Player{num.ToString()}";
    }
}
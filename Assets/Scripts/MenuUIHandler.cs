using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class MenuUIHandler : MonoBehaviour
{
    public void Start()
    {
        
    }
    public void StartNew()
    {
        SceneManager.LoadScene(1);
    }

    public void ReadPlayerName(string playerNameInput)
    {
        StoreData.Instance.PlayerName = playerNameInput;
        Debug.Log(StoreData.Instance.PlayerName);
    }
}

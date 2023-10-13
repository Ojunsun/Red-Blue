using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    [SerializeField] private bool isStart = false;
    [SerializeField] private Canvas _inGameCanvas;
    [SerializeField] private GameObject _ingameObj;
    [SerializeField] private Canvas _lobbyCanvas;

    private void Awake()
    {

    }

    private void Update()
    {
        GameStart();
    }

    private void GameStart()
    {
        if (isStart == true)
        {
            _ingameObj.SetActive(true);
            _inGameCanvas.enabled = true;
            _lobbyCanvas.enabled = false;
        }
        else
        {
            _ingameObj.SetActive(false);
            _inGameCanvas.enabled = false;
            _lobbyCanvas.enabled = true;
        }
    }
}

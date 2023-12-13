using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    [SerializeField] private GameObject _inGameCanvas;
    [SerializeField] private GameObject _lobbyCanvas;
    [SerializeField] private GameObject _gameOverCanvas;
    [SerializeField] private GameObject _ingameObj;
    public bool isStart;

    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }

    private void Start()
    {
        _lobbyCanvas.SetActive(true);
        _ingameObj.SetActive(false);
        _inGameCanvas.SetActive(false);
        _gameOverCanvas.SetActive(false);
    }

    public void GameStart()
    {
        isStart = true;
        _ingameObj.SetActive(true);
        _inGameCanvas.SetActive(true);
        _gameOverCanvas.SetActive(false);
        _lobbyCanvas.SetActive(false);
    }

    public void GameOver()
    {
        isStart = false;
        _ingameObj.SetActive(false);
        _gameOverCanvas.SetActive(true);
        _inGameCanvas.SetActive(false);
        _lobbyCanvas.SetActive(false);
    }
}

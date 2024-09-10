using meekobytes;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance;
    
    public GameState CurrentState;

    public static event Action<GameState> OnGameStateChanged;

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
    }

    private void Update()
    {
       
        if (Keyboard.current.pKey.wasPressedThisFrame)
        {
            UpdateGameState(GameState.PAUSE);
        }
    }

    public void UpdateGameState(GameState newState)
    {
        CurrentState = newState;

        switch (newState)
        {
            case GameState.MAINMENU:
                HandleMainMenu();
                break;
            case GameState.INGAME:
                HandleInGame();
                break;
            case GameState.PAUSE:
                HandlePause();
                break;
            case GameState.WIN:
                HandleWin();
                break;
            case GameState.LOSE:
                HandleLose();
                break;
        }
        OnGameStateChanged?.Invoke(newState);
    }

    private void HandleLose()
    {
        UIManager.Instance.RequestLoseScreen(CurrentState);
    }

    private void HandleWin()
    {
        UIManager.Instance.RequestWinScreen(CurrentState);
    }

    private void HandlePause()
    {
        //Stop all co-routines.
        //Unlock Mouse
        //Display Pause Menu
    }

    private void HandleInGame()
    {
        
    }

    private void HandleMainMenu()
    {
        
    }


    [SerializeField]
    public enum GameState
    {
        MAINMENU,
        INGAME,
        PAUSE,
        WIN,
        LOSE
    }
}
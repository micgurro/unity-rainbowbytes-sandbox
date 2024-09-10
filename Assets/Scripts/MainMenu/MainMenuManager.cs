using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace meekobytes
{
    public class MainMenuManager : MonoBehaviour
    {
        private void Start()
        {
            GameManager.Instance.UpdateGameState(GameManager.GameState.MAINMENU);
        }
        public void Awake()
        {
            GameManager.OnGameStateChanged += GameManagerOnGameStateChanged;
        }

        private void OnDestroy()
        {
            GameManager.OnGameStateChanged -= GameManagerOnGameStateChanged;
        }

        private void GameManagerOnGameStateChanged(GameManager.GameState state)
        {
        }

        public void ContinueGame()
        {
            GameManager.Instance.UpdateGameState(GameManager.GameState.INGAME);
            LevelManager.Instance.LoadScene(1);
        }

        public void NewGame()
        {
            GameManager.Instance.UpdateGameState(GameManager.GameState.INGAME);
            LevelManager.Instance.LoadScene(1);
        }

        public void Options()
        {

        }

        public void Quit()
        {
            Application.Quit();
        }
    }
}
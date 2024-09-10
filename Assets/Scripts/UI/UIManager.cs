using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class UIManager : MonoBehaviour
    {
        public static UIManager Instance;

        [SerializeField] private WinLoseUIController _winLossUIController;

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

        internal void RequestLoseScreen(GameManager.GameState loseState)
        {
            if (loseState != GameManager.GameState.LOSE) return;
            else _winLossUIController.DisplayLoseScreen();
        }

        internal void RequestWinScreen(GameManager.GameState winState)
        {
            if (winState != GameManager.GameState.WIN) return;
            else _winLossUIController.DisplayWinScreen();
        }
    }
}
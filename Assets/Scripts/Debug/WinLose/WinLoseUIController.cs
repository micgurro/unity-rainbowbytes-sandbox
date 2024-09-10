using UnityEngine;


namespace meekobytes
{
    public class WinLoseUIController : MonoBehaviour
    {

        [SerializeField] private GameObject _winScreen;
        [SerializeField] private GameObject _loseScreen;


        public GameObject WinScreen { get; private set; }
        public GameObject LoseScreen { get; private set; }


        private void Awake()
        {
            WinScreen = _winScreen;
            LoseScreen = _loseScreen;

            ClearWinLossScreens();
        }

        private void OnDisable()
        {
            ClearWinLossScreens();
        }

        internal void DisplayWinScreen()
        {
            ClearWinLossScreens();
            _winScreen.SetActive(true);
        }

        internal void DisplayLoseScreen()
        {
            ClearWinLossScreens();
            _loseScreen.SetActive(true);
        }

        internal void ClearWinLossScreens()
        {
            _winScreen.SetActive(false);
            _loseScreen.SetActive(false);
        }
    }
}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class LevelChangeTrigger : MonoBehaviour
    {
        [SerializeField] private int _levelIndex;
        public int LevelIndex => _levelIndex;


        public void Awake()
        {
           
        }

        public void OnTriggerEnter(Collider other)
        {
            if (other.TryGetComponent<PlayerManager>(out PlayerManager player))
            {
                if (player)
                {
                    LevelManager.Instance.LoadScene(_levelIndex);
                }
            }
        }
    }
}
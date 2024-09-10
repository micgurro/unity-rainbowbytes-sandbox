using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class SceneEnter : MonoBehaviour
    {
        public int LastExitIndex;

        private void Start()
        {
            if (PlayerManager.Instance.LastSceneIndex == LastExitIndex)
            {
                PlayerManager.Instance.transform.position = transform.position;
                PlayerManager.Instance.transform.eulerAngles = transform.eulerAngles;
            }
        }

    }
}

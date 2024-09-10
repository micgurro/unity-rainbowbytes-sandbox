using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace meekobytes
{
    public class SceneExit : MonoBehaviour, IInteractable
    {
        [SerializeField] private string _prompt = "Go in";
        [SerializeField] private int _sceneToLoad;
        [SerializeField] private int _exitIndex;
        [SerializeField] private bool _isTriggerExit;

        [SerializeField] BoxCollider myCollider;
        
        public UnityAction<IInteractable> OnInteractionComplete { get; set; }

        public string InteractionPrompt => _prompt;

        public void EndInteraction()
        {
            
        }

        private void Awake()
        {
            myCollider = this.GetComponent<BoxCollider>();

            if (_isTriggerExit)
            {
                myCollider.isTrigger = true;
            }
            else
            {
                return;
            }
        }

        private void OnTriggerEnter(Collider other)
        {
            other.TryGetComponent<PlayerManager>(out PlayerManager player);
            if (player != null && _isTriggerExit)
            {
                PlayerManager.Instance.LastSceneIndex = _exitIndex;
                LevelManager.Instance.LoadScene(_sceneToLoad);
            }
            else
            {
                return;
            }
        }

        public void Interact(Interactor interactor, out bool interactSuccessful)
        {
            if (!_isTriggerExit)
            {
                PlayerManager.Instance.LastSceneIndex = _exitIndex;
                LevelManager.Instance.LoadScene(_sceneToLoad);
                interactSuccessful = true;
            }
            else
            {
                interactSuccessful = false;
            }
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

namespace meekobytes
{
    public class BedLevelChange : MonoBehaviour, IInteractable
    {
        private string _prompt = "Go to bed";
        public UnityAction<IInteractable> OnInteractionComplete { get; set; }

        public string InteractionPrompt => _prompt;

        public void EndInteraction()
        {
            throw new System.NotImplementedException();
        }

        public void Interact(Interactor interactor, out bool interactSuccessful)
        {
            interactor.TryGetComponent<PlayerManager>(out PlayerManager player);

            if(player != null)
            {
                LevelManager.Instance.LoadScene(3);
                interactSuccessful = true;
            }
            else
            {
                interactSuccessful = false;
            }

        }
    }
}

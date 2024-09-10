using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

namespace meekobytes
{
    public class DialogueManager : MonoBehaviour
    {
        public static DialogueManager Instance;
        public Image actorImage;
        public TextMeshProUGUI actorName;
        public TextMeshProUGUI messageText;
        public RectTransform backgroundBox;
        public GameObject dialogueUI;

        Message[] currentMessages;
        Actor[] currentActors;
        int activeMessage = 0;
        public static bool isActive = false;

        public void Awake()
        {
            if(Instance != null && Instance != this)
            {
                Destroy(this);
            }
            else
            {
                Instance = this;
                DontDestroyOnLoad(this);
            }
            if(dialogueUI.activeInHierarchy == true)
            {
                dialogueUI.SetActive(false);
            }
        }

        public void NextMessage()
        {
            activeMessage++;
            if(activeMessage < currentMessages.Length)
            {
                DisplayMessage();
            }
            else
            {
                Debug.Log("Conversation ended.");
                dialogueUI.SetActive(false);
                isActive = false;
            }
        }

        private void Update()
        {
            if(Input.GetKeyDown(KeyCode.Space) && isActive == true)
            {
                NextMessage();
            }
        }

        public void OpenDialogue(Message[] messages, Actor[] actors)
        {
            currentMessages = messages;
            currentActors = actors;
            activeMessage = 0;
            isActive = true;
            dialogueUI.SetActive(true);
            DisplayMessage();
        }

        void DisplayMessage()
        {
            Message messageToDisplay = currentMessages[activeMessage];
            messageText.text = messageToDisplay.message;

            Actor actorToDisplay = currentActors[messageToDisplay.actorID];
            actorName.text = actorToDisplay.name;
            actorImage.sprite = actorToDisplay.sprite;
        }
    }

}
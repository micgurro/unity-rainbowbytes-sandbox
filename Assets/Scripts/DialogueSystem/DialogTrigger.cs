using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public interface IDialogTrigger
    {
        public Message[] messages { get; set; }
        public Actor[] actors { get; set; }

        public void StartDialogue()
        {
            DialogueManager.Instance.OpenDialogue(messages, actors);
        }
    }
    [System.Serializable]
    public class Message
    {
        public int actorID;
        public string message;
    }
    [System.Serializable]
    public class Actor
    {
        public string name;
        public Sprite sprite;
    }
}

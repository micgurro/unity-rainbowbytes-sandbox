using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class PlayerManager : CharacterManager
    {
        public static PlayerManager Instance;

        private int _lastSceneIndex;

        [HideInInspector] public PlayerAnimatorManager PlayerAnimatorManager;

        

        public int LastSceneIndex { get {return _lastSceneIndex; } set { _lastSceneIndex = value; } }

        protected override void Awake()
        {
            base.Awake();

            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);

                PlayerAnimatorManager = GetComponent<PlayerAnimatorManager>();
          

            }
            
            else
            {
                Destroy(gameObject);
            }
        }

        protected override void Update()
        {
            base.Update();
            
        }

        protected override void FixedUpdate()
        {
            base.FixedUpdate();
            
        }
    }

}
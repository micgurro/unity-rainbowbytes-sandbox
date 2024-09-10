using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class PlayerAnimatorManager : CharacterAnimatorManager
    {

        public static PlayerAnimatorManager Instance;

        private Animator animator;

        protected override void Awake()
        {
            base.Awake();
            if (Instance == null)
            {
                Instance = this;
                DontDestroyOnLoad(gameObject);
                animator = GetComponent<Animator>();

            }
            else
            {
                Destroy(this);
            }
        }
    }
}
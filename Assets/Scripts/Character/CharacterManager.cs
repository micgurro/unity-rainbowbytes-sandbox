using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace meekobytes
{
    public class CharacterManager : MonoBehaviour
    {
        [HideInInspector] public Animator animator;
        protected virtual void Awake()
        {
            DontDestroyOnLoad(this);
            animator = GetComponent<Animator>();

        }

        protected virtual void Update()
        {

        }

        protected virtual void FixedUpdate()
        {

        }
    }

}
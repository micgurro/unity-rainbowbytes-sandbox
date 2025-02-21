﻿using UnityEngine;
using UnityEngine.Events;

public class GameEventListener : MonoBehaviour
{
    [SerializeField] protected GameEvent _gameEvent;
    [SerializeField] protected UnityEvent _unityEvent;

    void Awake() => _gameEvent.Register(gameEventListener:this);

    void OnDestroy() => _gameEvent.Deregister(gameEventListener:this);

    public virtual void RaiseEvent() => _unityEvent.Invoke();
}
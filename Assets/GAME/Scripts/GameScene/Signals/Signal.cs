using System;
using System.Collections.Generic;

public abstract class Signal<TSignal> : ISignal
    where TSignal : Signal<TSignal>, new()
{
    private readonly List<Action<object[]>> _listeners = new List<Action<object[]>>();

    public void Subscribe(Action<object[]> listener)
    {
        if (!_listeners.Contains(listener))
        {
            _listeners.Add(listener);
        }
    }

    public void Unsubscribe(Action<object[]> listener)
    {
        if (_listeners.Contains(listener))
        {
            _listeners.Remove(listener);
        }
    }

    public void Invoke(params object[] args)
    {
        foreach (var listener in _listeners)
        {
            listener?.Invoke(args);
        }
    }
}
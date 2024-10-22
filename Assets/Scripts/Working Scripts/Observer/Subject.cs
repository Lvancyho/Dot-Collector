using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Subject : MonoBehaviour
{
    private readonly
    List<Observer> _observers = new List<Observer>();

    protected void Attach(Observer observer)
    {
        _observers.Add(observer);
    }
    protected void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }
    protected void NotifyObservers()
    {
        foreach (Observer observer in _observers)
        {
            observer.Notify(this);
        }
    }

    //doesnt work idk bro. its supposed to be able to attach and listen to observers and in this case that would be the score system. when a coin is picked up, the score system is listening for the player to pick coins up.
}
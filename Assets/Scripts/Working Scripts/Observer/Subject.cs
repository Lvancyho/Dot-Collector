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

    //adds observers to the list
    protected void Detach(Observer observer)
    {
        _observers.Remove(observer);
    }

    //removes observers from the list
    protected void NotifyObservers()
    {
        foreach (Observer observer in _observers)
        {
            observer.Notify(this);
        }
    }

    //notifies observers in the list

    //when a coin is picked up, the score system is listening for the player to pick coins up.
}
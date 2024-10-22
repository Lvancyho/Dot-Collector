using System.Collections.Generic;
using UnityEngine;

public class ScoreObserver : MonoBehaviour
{
    private List<IScoreObserver> observers = new List<IScoreObserver>();

    public void AddObserver(IScoreObserver observer)
    {
        observers.Add(observer);
    }

    public void NotifyObservers(int newScore)
    {
        foreach (var observer in observers)
        {
            observer.UpdateScore(newScore);
        }
    }
}

public interface IScoreObserver
{
    void UpdateScore(int newScore);
}
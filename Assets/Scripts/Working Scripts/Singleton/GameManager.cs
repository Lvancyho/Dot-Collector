using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : Observer
{
    public static GameManager Instance;

    public TMP_Text score; //makes the score visable and accessable
    int currentScore = 0; //starts at 0

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
        }
        Instance = this;

        score.text = "0";

        // singleton stuff, makes sure there can only be one at a time or else it destroys the duplicates.
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddToScore(int val)
    {
        currentScore += val;
        score.text = $"{currentScore}"; //displays your current score
    }

    public override void Notify(Subject subject)
    {
        currentScore += subject.GetComponent<BaseCoin>().moneyValue;
        score.text = $"{currentScore}"; //displays your current score while calling for the observer
    }
}

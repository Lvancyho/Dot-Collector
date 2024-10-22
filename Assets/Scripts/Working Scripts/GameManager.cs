using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameManager : Observer
{
    public static GameManager Instance;

    public TMP_Text score;
    int currentScore = 0;

    // Start is called before the first frame update
    void Start()
    {
        if (Instance != this && Instance != null)
        {
            Destroy(this);
        }
        Instance = this;

        score.text = "0";
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void AddToScore(int val)
    {
        currentScore += val;
        score.text = $"{currentScore}";
    }

    public override void Notify(Subject subject)
    {
        currentScore += subject.GetComponent<BaseCoin>().moneyValue;
        score.text = $"{currentScore}";
    }
}

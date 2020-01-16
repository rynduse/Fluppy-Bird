using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    public static GameController gameController;
    private bool isPlaying;
    private int score;
    private GameObject UI;
    private void Awake()
    {
        if (GameController.gameController == null)
        {
            GameController.gameController = this;
        }
        else
        {
            if (this != GameController.gameController)
            {
                Destroy(this.gameObject);
            }
        }
        DontDestroyOnLoad(GameController.gameController.gameObject);
    }

    public void IncreaseScore()
    {
        score++;
        UI.GetComponent<UIController>().SetScoreText(score);
    }

    public bool GetGameState() {

        return isPlaying;
    }
    public void SetGameState(bool aGameState) {
        isPlaying = aGameState;

    }
    public int GetScore() {
        return score;
    }
    public void SetScore(int aScore) {
        score = aScore;
    }
    void Start()
    {
        isPlaying = true;
        score = 0;
        UI = GameObject.FindGameObjectWithTag("UserInterface");
        UI.GetComponent<UIController>().SetScoreText(score);

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

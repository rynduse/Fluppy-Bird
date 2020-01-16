using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

using UnityEngine.UI;

public class UIController : MonoBehaviour
{
    // Start is called before the first frame update
    public Button replayBtn;
    public Transform deathPanel, mainPanel;
    public Text scoreText;
    void Start()
    {
        replayBtn.onClick.AddListener(Replay);
        
        
    }
    public void SetScoreText(int aScore) {
        scoreText.text = "Score :" + aScore;
    }
    private void Replay()
    {
        
        Time.timeScale = 1;
        mainPanel.gameObject.SetActive(true);
        GameController.gameController.SetGameState(true);
        int sahne = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(sahne);
    }
    public void ShowEndGame() {
        mainPanel.gameObject.SetActive(false);
        GameController.gameController.SetGameState(false);
        Time.timeScale = 0;
        deathPanel.gameObject.SetActive(true);
    }

    // Update is called once per frame
    void Update()
    {
      
    }
}

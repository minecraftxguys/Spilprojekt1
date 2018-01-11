using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HighScoreScript : MonoBehaviour
{
    //Gameobjects
    public GameObject GameManager;
    public GameObject AgePanel;
    public GameObject GamePanel;
    public GameObject HighScorePanel;

    //Scripts
    private ButtonPressManager BPM;

    void Start()
    {
        BPM = GameManager.GetComponent<ButtonPressManager>();
    }

    public void GameEnded()
    {
        HighScorePanel.SetActive(true);
        GamePanel.SetActive(false);
    }
}

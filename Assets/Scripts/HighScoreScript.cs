using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HighScoreScript : MonoBehaviour
{
    //Gameobjects
    public GameObject GameManager;
    public GameObject AgePanel;
    public GameObject GamePanel;
    public GameObject HighScorePanel;
    public Text PlayerText;
    float Top1 = 5;
    float Top2 = 4;
    float Top3 = 3;
    float Top4 = 2;
    float Top5 = 1;
    float Top1Cache = 0;
    float Top2Cache = 0;
    float Top3Cache = 0;
    float Top4Cache = 0;
    float Top5Cache = 0;

    float Time1 = 0;
    float Time2 = 0;
    float Time3 = 0;
    float Time4 = 0;
    float Time5 = 0;
    float Time1Cache = 0;
    float Time2Cache = 0;
    float Time3Cache = 0;
    float Time4Cache = 0;
    float Time5Cache = 0;
    float HiddenTime;

    public Text Top1Text;
    public Text Top2Text;
    public Text Top3Text;
    public Text Top4Text;
    public Text Top5Text;

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
        PlayerText.text = "Du har fået: " + BPM.Point + " point";
#region Checkifbigger
        if(BPM.Point > Top1)
        {
            Top1Text.text = "1. " + BPM.Point + " point";
            Top2Text.text = "2. " + Top1 + " point";
            Top3Text.text = "3. " + Top2 + " point";
            Top4Text.text = "4. " + Top3 + " point";
            Top5Text.text = "5. " + Top4 + " point";
            Top1Cache = Top1;
            Top2Cache = Top2;
            Top3Cache = Top3;
            Top4Cache = Top4;

            Top1 = BPM.Point;
            Top2 = Top1Cache;
            Top3 = Top2Cache;
            Top4 = Top3Cache;
            Top5 = Top4Cache;
        }
        if (BPM.Point < Top1 && BPM.Point > Top2)
        {
            Top2Text.text = "2. " + BPM.Point + " point";
            Top3Text.text = "3. " + Top2 + " point";
            Top2 = Top3;
            Top4Text.text = "4. " + Top3 + " point";
            Top3 = Top4;
            Top5Text.text = "5. " + Top4 + " point";

            Top2Cache = Top2;
            Top3Cache = Top3;
            Top4Cache = Top4;
            Top5Cache = Top5;

            Top2 = BPM.Point;
            Top3 = Top2Cache;
            Top4 = Top3Cache;
            Top5 = Top4Cache;
        }
        if (BPM.Point < Top1 && BPM.Point < Top2 && BPM.Point > Top3)
        {
            Top3Text.text = "3. " + BPM.Point + " point";
            Top4Text.text = "4. " + Top3 + " point";
            Top5Text.text = "5. " + Top4 + " point";

            Top3Cache = Top3;
            Top4Cache = Top4;

            Top3 = BPM.Point;
            Top4 = Top3Cache;
            Top5 = Top4Cache;
        }
        if (BPM.Point < Top1 && BPM.Point < Top2 && BPM.Point < Top3 && BPM.Point > Top4)
        {
            Top4Text.text = "4. " + BPM.Point + " point";
            Top5Text.text = "5. " + Top4 + " point";
            
            Top4Cache = Top4;

            Top4 = BPM.Point;
            Top5 = Top4Cache;
        }
        if (BPM.Point < Top1 && BPM.Point < Top2 && BPM.Point < Top3 && BPM.Point < Top4 && BPM.Point > Top5)
        {
            Top5Text.text = "5. " + BPM.Point + " point" ;

            Top5 = BPM.Point;
        }

        if (BPM.Point < Top5)
        {
            Top1Text.text = "1. " + Top1 + " point";
            Top2Text.text = "2. " + Top2 + " point";
            Top3Text.text = "3. " + Top3 + " point";
            Top4Text.text = "4. " + Top4 + " point";
            Top5Text.text = "5. " + Top5 + " point";
        }
        #endregion

#region Equalscheck
        if (BPM.Point == Top1)
        {
            if (HiddenTime < Time1)
            {
                Top1Text.text = "1. " + BPM.Point + " point";//+timer
                Top2Text.text = "2. " + Top1 + " point";
                Top3Text.text = "3. " + Top2 + " point";
                Top4Text.text = "4. " + Top3 + " point";
                Top5Text.text = "5. " + Top4 + " point";
                Top1Cache = Top1;
                Top2Cache = Top2;
                Top3Cache = Top3;
                Top4Cache = Top4;

                Top1 = BPM.Point;
                Top2 = Top1Cache;
                Top3 = Top2Cache;
                Top4 = Top3Cache;
                Top5 = Top4Cache;
            }

            if (Time1 < HiddenTime)
            {
                Top2Text.text = "2. " + BPM.Point + " point";
                Top3Text.text = "3. " + Top2 + " point";
                Top2 = Top3;
                Top4Text.text = "4. " + Top3 + " point";
                Top3 = Top4;
                Top5Text.text = "5. " + Top4 + " point";

                Top2Cache = Top2;
                Top3Cache = Top3;
                Top4Cache = Top4;
                Top5Cache = Top5;

                Top2 = BPM.Point;
                Top3 = Top2Cache;
                Top4 = Top3Cache;
                Top5 = Top4Cache;
            }
        }

        if(BPM.Point == Top2)
        {
            if (HiddenTime < Time2)
            {
                Top2Text.text = "2. " + BPM.Point + " point";
                Top3Text.text = "3. " + Top2 + " point";
                Top2 = Top3;
                Top4Text.text = "4. " + Top3 + " point";
                Top3 = Top4;
                Top5Text.text = "5. " + Top4 + " point";

                Top2Cache = Top2;
                Top3Cache = Top3;
                Top4Cache = Top4;
                Top5Cache = Top5;

                Top2 = BPM.Point;
                Top3 = Top2Cache;
                Top4 = Top3Cache;
                Top5 = Top4Cache;
            }
            if (Time2 < HiddenTime)
            {
                Top3Text.text = "3. " + BPM.Point + " point";
                Top4Text.text = "4. " + Top3 + " point";
                Top5Text.text = "5. " + Top4 + " point";

                Top3Cache = Top3;
                Top4Cache = Top4;

                Top3 = BPM.Point;
                Top4 = Top3Cache;
                Top5 = Top4Cache;
            }
        }

        if (BPM.Point == Top3)
        {
            if (HiddenTime < Time3)
            {
                Top3Text.text = "3. " + BPM.Point + " point";
                Top4Text.text = "4. " + Top3 + " point";
                Top5Text.text = "5. " + Top4 + " point";

                Top3Cache = Top3;
                Top4Cache = Top4;

                Top3 = BPM.Point;
                Top4 = Top3Cache;
                Top5 = Top4Cache;
            }
            if (Time3 < HiddenTime)
            {
                Top4Text.text = "4. " + BPM.Point + " point";
                Top5Text.text = "5. " + Top4 + " point";

                Top4Cache = Top4;

                Top4 = BPM.Point;
                Top5 = Top4Cache;
            }
        }

        if (BPM.Point == Top4)
        {
            if(HiddenTime < Time4)
            {
                Top4Text.text = "4. " + BPM.Point + " point";
                Top5Text.text = "5. " + Top4 + " point";

                Top4Cache = Top4;

                Top4 = BPM.Point;
                Top5 = Top4Cache;
            }
            if(Time4 < HiddenTime)
            {
                Top5Text.text = "5. " + BPM.Point + " point";

                Top5 = BPM.Point;
            }
        }
        if (BPM.Point == Time5)
        {
            if(HiddenTime < Time5)
            {
                Top5Text.text = "5. " + BPM.Point + " point";

                Top5 = BPM.Point;
            }
        }
        #endregion

    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            GameEnded();
        }

    }

    public void StartHiddenTimer()
    {
        StartCoroutine(HiddenTimer());
    }

    IEnumerator HiddenTimer()
    {
        yield return new WaitForSeconds(1);
        HiddenTime++;

    } 
}

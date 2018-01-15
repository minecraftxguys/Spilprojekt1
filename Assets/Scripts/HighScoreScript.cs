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

    //variables from timer scirpt
    float TimerSeconds1 = 0;
    float TimerSeconds2 = 0;
    float TimerSeconds3 = 0;
    float TimerSeconds4 = 0;
    float TimerSeconds5 = 0;

    float TimerMinutes1 = 0;
    float TimerMinutes2 = 0;
    float TimerMinutes3 = 0;
    float TimerMinutes4 = 0;
    float TimerMinutes5 = 0;

    float TimerSeconds1Cache = 0;
    float TimerSeconds2Cache = 0;
    float TimerSeconds3Cache = 0;
    float TimerSeconds4Cache = 0;
    float TimerSeconds5Cache = 0;

    float TimerMinutes1Cache = 0;
    float TimerMinutes2Cache = 0;
    float TimerMinutes3Cache = 0;
    float TimerMinutes4Cache = 0;
    float TimerMinutes5Cache = 0;

    //text
    public Text Top1Text;
    public Text Top2Text;
    public Text Top3Text;
    public Text Top4Text;
    public Text Top5Text;

    //Scripts
    private ButtonPressManager BPM;
    private Timer T;

    void Start()
    {
        BPM = GameManager.GetComponent<ButtonPressManager>();
        T = GameManager.GetComponent<Timer>();
    }

    public void GameEnded()
    {

        //todo:
        // cache the hiddentime
        HighScorePanel.SetActive(true);
        GamePanel.SetActive(false);
        PlayerText.text = "Du har fået: " + BPM.Point + " point";
    
        #region Checkifbigger
        if(BPM.Point > Top1)
        {
            Top1Text.text = "1. " + BPM.Point + " point " + T.Minutes +":" + T.Seconds;
            Top2Text.text = "2. " + Top1 + " point " + TimerMinutes1 + ":" + TimerSeconds1;
            Top3Text.text = "3. " + Top2 + " point " + TimerMinutes2 + ":" + TimerSeconds2;
            Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
            Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

            Top1Cache = Top1;
            Top2Cache = Top2;
            Top3Cache = Top3;
            Top4Cache = Top4;
            TimerMinutes1Cache = TimerMinutes1;
            TimerSeconds1Cache = TimerSeconds1;

            TimerMinutes2Cache = TimerMinutes2;
            TimerSeconds2Cache = TimerSeconds2;

            TimerMinutes3Cache = TimerMinutes3;
            TimerSeconds3Cache = TimerSeconds3;

            TimerMinutes4Cache = TimerMinutes4;
            TimerSeconds4Cache = TimerSeconds4;

            TimerMinutes5Cache = TimerMinutes5;
            TimerSeconds5Cache = TimerSeconds5;


            Top1 = BPM.Point;
            Top2 = Top1Cache;
            Top3 = Top2Cache;
            Top4 = Top3Cache;
            Top5 = Top4Cache;

            TimerMinutes1 = TimerMinutes1Cache;
            TimerSeconds1 = TimerSeconds1Cache;

            TimerMinutes2 = TimerMinutes2Cache;
            TimerSeconds2 = TimerSeconds2Cache;

            TimerMinutes3 = TimerMinutes3Cache;
            TimerSeconds3 = TimerSeconds3Cache;

            TimerMinutes4 = TimerMinutes4Cache;
            TimerSeconds4 = TimerSeconds4Cache;

            TimerMinutes5 = TimerMinutes5Cache;
            TimerSeconds5 = TimerSeconds5Cache;
        }
        if (BPM.Point < Top1 && BPM.Point > Top2)
        {
            Top2Text.text = "2. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
            Top3Text.text = "3. " + Top2 + " point " + TimerMinutes2 + ":" + TimerSeconds2;
            Top2 = Top3;
            Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
            Top3 = Top4;
            Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

            Top2Cache = Top2;
            Top3Cache = Top3;
            Top4Cache = Top4;
            Top5Cache = Top5;

            TimerMinutes2Cache = TimerMinutes2;
            TimerSeconds2Cache = TimerSeconds2;

            TimerMinutes3Cache = TimerMinutes3;
            TimerSeconds3Cache = TimerSeconds3;

            TimerMinutes4Cache = TimerMinutes4;
            TimerSeconds4Cache = TimerSeconds4;

            TimerMinutes5Cache = TimerMinutes5;
            TimerSeconds5Cache = TimerSeconds5;

            Top2 = BPM.Point;
            Top3 = Top2Cache;
            Top4 = Top3Cache;
            Top5 = Top4Cache;

            TimerMinutes2 = TimerMinutes2Cache;
            TimerSeconds2 = TimerSeconds2Cache;

            TimerMinutes3 = TimerMinutes3Cache;
            TimerSeconds3 = TimerSeconds3Cache;

            TimerMinutes4 = TimerMinutes4Cache;
            TimerSeconds4 = TimerSeconds4Cache;

            TimerMinutes5 = TimerMinutes5Cache;
            TimerSeconds5 = TimerSeconds5Cache;
        }
        if (BPM.Point < Top1 && BPM.Point < Top2 && BPM.Point > Top3)
        {
            Top3Text.text = "3. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
            Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
            Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

            Top3Cache = Top3;
            Top4Cache = Top4;
            Top5Cache = Top5;

            TimerMinutes3Cache = TimerMinutes3;
            TimerSeconds3Cache = TimerSeconds3;

            TimerMinutes4Cache = TimerMinutes4;
            TimerSeconds4Cache = TimerSeconds4;

            TimerMinutes5Cache = TimerMinutes5;
            TimerSeconds5Cache = TimerSeconds5;

            Top3 = BPM.Point;
            Top4 = Top3Cache;
            Top5 = Top4Cache;


            TimerMinutes3 = TimerMinutes3Cache;
            TimerSeconds3 = TimerSeconds3Cache;

            TimerMinutes4 = TimerMinutes4Cache;
            TimerSeconds4 = TimerSeconds4Cache;

            TimerMinutes5 = TimerMinutes5Cache;
            TimerSeconds5 = TimerSeconds5Cache;
        }
        if (BPM.Point < Top1 && BPM.Point < Top2 && BPM.Point < Top3 && BPM.Point > Top4)
        {
            Top4Text.text = "4. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
            Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

            Top4Cache = Top4;
            Top5Cache = Top5;

            TimerMinutes4Cache = TimerMinutes4;
            TimerSeconds4Cache = TimerSeconds4;

            TimerMinutes5Cache = TimerMinutes5;
            TimerSeconds5Cache = TimerSeconds5;


            Top4 = BPM.Point;
            Top5 = Top4Cache;

            TimerMinutes4 = TimerMinutes4Cache;
            TimerSeconds4 = TimerSeconds4Cache;

            TimerMinutes5 = TimerMinutes5Cache;
            TimerSeconds5 = TimerSeconds5Cache;
        }
        if (BPM.Point < Top1 && BPM.Point < Top2 && BPM.Point < Top3 && BPM.Point < Top4 && BPM.Point > Top5)
        {
            Top5Text.text = "5. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;

            Top5 = BPM.Point;
        }

        if (BPM.Point < Top5)
        {
            Top1Text.text = "1. " + Top1 + " point " + TimerMinutes1 + ":" + TimerSeconds1;
            Top2Text.text = "2. " + Top2 + " point " + TimerMinutes2 + ":" + TimerSeconds2;
            Top3Text.text = "3. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
            Top4Text.text = "4. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;
            Top5Text.text = "5. " + Top5 + " point " + TimerMinutes5 + ":" + TimerSeconds5;
        }
        #endregion

#region Equalscheck
        if (BPM.Point == Top1)
        {
            if (HiddenTime < Time1)
            {
                Top1Text.text = "1. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
                Top2Text.text = "2. " + Top1 + " point " + TimerMinutes1 + ":" + TimerSeconds1;
                Top3Text.text = "3. " + Top2 + " point " + TimerMinutes2 + ":" + TimerSeconds2;
                Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top1Cache = Top1;
                Top2Cache = Top2;
                Top3Cache = Top3;
                Top4Cache = Top4;

                Time1Cache = Time1;
                Time2Cache = Time2;
                Time3Cache = Time3;
                Time4Cache = Time4;
                Time5Cache = Time5;


                TimerMinutes1Cache = TimerMinutes1;
                TimerSeconds1Cache = TimerSeconds1;

                TimerMinutes2Cache = TimerMinutes2;
                TimerSeconds2Cache = TimerSeconds2;

                TimerMinutes3Cache = TimerMinutes3;
                TimerSeconds3Cache = TimerSeconds3;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;


                Top1 = BPM.Point;
                Top2 = Top1Cache;
                Top3 = Top2Cache;
                Top4 = Top3Cache;
                Top5 = Top4Cache;

                Time1 = HiddenTime;
                Time2 = Time1Cache;
                Time3 = Time2Cache;
                Time4 = Time3Cache;
                Time5 = Time4Cache;

                TimerMinutes1 = TimerMinutes1Cache;
                TimerSeconds1 = TimerSeconds1Cache;

                TimerMinutes2 = TimerMinutes2Cache;
                TimerSeconds2 = TimerSeconds2Cache;

                TimerMinutes3 = TimerMinutes3Cache;
                TimerSeconds3 = TimerSeconds3Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;

            }

            if (Time1 < HiddenTime)
            {
                Top2Text.text = "2. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
                Top3Text.text = "3. " + Top2 + " point " + TimerMinutes2 + ":" + TimerSeconds2;
                Top2 = Top3;
                Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
                Top3 = Top4;
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top2Cache = Top2;
                Top3Cache = Top3;
                Top4Cache = Top4;
                Top5Cache = Top5;

                Time2Cache = Time2;
                Time3Cache = Time3;
                Time4Cache = Time4;
                Time5Cache = Time5;

                TimerMinutes2Cache = TimerMinutes2;
                TimerSeconds2Cache = TimerSeconds2;

                TimerMinutes3Cache = TimerMinutes3;
                TimerSeconds3Cache = TimerSeconds3;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;

                Top2 = BPM.Point;
                Top3 = Top2Cache;
                Top4 = Top3Cache;
                Top5 = Top4Cache;

                Time2 = HiddenTime;
                Time3 = Time2Cache;
                Time4 = Time3Cache;
                Time5 = Time4Cache;

                TimerMinutes2 = TimerMinutes2Cache;
                TimerSeconds2 = TimerSeconds2Cache;

                TimerMinutes3 = TimerMinutes3Cache;
                TimerSeconds3 = TimerSeconds3Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;
            }
        }

        if(BPM.Point == Top2)
        {
            if (HiddenTime < Time2)
            {
                Top2Text.text = "2. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
                Top3Text.text = "3. " + Top2 + " point " + TimerMinutes2 + ":" + TimerSeconds2;
                Top2 = Top3;
                Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
                Top3 = Top4;
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top2Cache = Top2;
                Top3Cache = Top3;
                Top4Cache = Top4;
                Top5Cache = Top5;

                Time2Cache = Time2;
                Time3Cache = Time3;
                Time4Cache = Time4;
                Time5Cache = Time5;

                TimerMinutes2Cache = TimerMinutes2;
                TimerSeconds2Cache = TimerSeconds2;

                TimerMinutes3Cache = TimerMinutes3;
                TimerSeconds3Cache = TimerSeconds3;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;

                Top2 = BPM.Point;
                Top3 = Top2Cache;
                Top4 = Top3Cache;
                Top5 = Top4Cache;

                Time2 = HiddenTime;
                Time3 = Time2Cache;
                Time4 = Time3Cache;
                Time5 = Time4Cache;

                TimerMinutes2 = TimerMinutes2Cache;
                TimerSeconds2 = TimerSeconds2Cache;

                TimerMinutes3 = TimerMinutes3Cache;
                TimerSeconds3 = TimerSeconds3Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;
            }
            if (Time2 < HiddenTime)
            {
                Top3Text.text = "3. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
                Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top3Cache = Top3;
                Top4Cache = Top4;
                Top5Cache = Top5;

                Time3Cache = Time3;
                Time4Cache = Time4;
                Time5Cache = Time5;

                TimerMinutes3Cache = TimerMinutes3;
                TimerSeconds3Cache = TimerSeconds3;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;

                Top3 = BPM.Point;
                Top4 = Top3Cache;
                Top5 = Top4Cache;

                Time3 = HiddenTime;
                Time4 = Time3Cache;
                Time5 = Time4Cache;

                TimerMinutes3 = TimerMinutes3Cache;
                TimerSeconds3 = TimerSeconds3Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;
            }
        }

        if (BPM.Point == Top3)
        {
            Debug.Log("lortet virker ikke");
            if (HiddenTime < Time3)
            {
                Top3Text.text = "3. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds + "equal";
                Top4Text.text = "4. " + Top3 + " point " + TimerMinutes3 + ":" + TimerSeconds3;
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top3Cache = Top3;
                Top4Cache = Top4;
                Top5Cache = Top5;

                Time3Cache = Time3;
                Time4Cache = Time4;
                Time5Cache = Time5;

                TimerMinutes3Cache = TimerMinutes3;
                TimerSeconds3Cache = TimerSeconds3;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;

                Top3 = BPM.Point;
                Top4 = Top3Cache;
                Top5 = Top4Cache;

                Time3 = HiddenTime;
                Time4 = Time3Cache;
                Time5 = Time4Cache;

                TimerMinutes3 = TimerMinutes3Cache;
                TimerSeconds3 = TimerSeconds3Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;
            }
            if (Time3 < HiddenTime)
            {
                Top4Text.text = "4. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds + "test";
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top4Cache = Top4;
                Top5Cache = Top5;

                Time4Cache = Time4;
                Time5Cache = Time5;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;


                Top4 = BPM.Point;
                Top5 = Top4Cache;

                Time4 = HiddenTime;
                Time5 = Time4Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;
            }
        }

        if (BPM.Point == Top4)
        {
            if(HiddenTime < Time4)
            {
                Top4Text.text = "4. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;
                Top5Text.text = "5. " + Top4 + " point " + TimerMinutes4 + ":" + TimerSeconds4;

                Top4Cache = Top4;
                Top5Cache = Top5;

                Time4Cache = Time4;
                Time5Cache = Time5;

                TimerMinutes4Cache = TimerMinutes4;
                TimerSeconds4Cache = TimerSeconds4;

                TimerMinutes5Cache = TimerMinutes5;
                TimerSeconds5Cache = TimerSeconds5;


                Top4 = BPM.Point;
                Top5 = Top4Cache;

                Time4 = HiddenTime;
                Time5 = Time4Cache;

                TimerMinutes4 = TimerMinutes4Cache;
                TimerSeconds4 = TimerSeconds4Cache;

                TimerMinutes5 = TimerMinutes5Cache;
                TimerSeconds5 = TimerSeconds5Cache;
            }
            if(Time4 < HiddenTime)
            {
                Top5Text.text = "5. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;

                Top5 = BPM.Point;

                Time5 = HiddenTime;

            }
        }
        if (BPM.Point == Time5)
        {
            if(HiddenTime < Time5)
            {
                Top5Text.text = "5. " + BPM.Point + " point " + T.Minutes + ":" + T.Seconds;

                Top5 = BPM.Point;

                Time5 = HiddenTime;
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

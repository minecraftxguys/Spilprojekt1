using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class Timer : MonoBehaviour
{

    public Text TimerText;
    private int Seconds;
    private float Minutes;
    private bool TimeEnabled = false;
    private bool TwoDigitsSec;
    private bool TwoDigitsMin;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Y))
        {
            Debug.Log("Start Timer");
            StartCoroutine(GainTime());
        }

        if (Seconds > 9)
        {
            TwoDigitsSec = true;
        }

        if (TwoDigitsSec == true)
        {
            if (TwoDigitsMin == true)
            {
                TimerText.text = Minutes + ":" + Seconds;
            }
            else
            {
                TimerText.text = "0" + Minutes + ":" + Seconds;
            }
        }
        else
        {
            if (TwoDigitsMin == true)
            {
                TimerText.text = Minutes + ":0" + Seconds;
            }
            else
            {
                TimerText.text = "0" + Minutes + ":0" + Seconds;
            }
        }

        if (Seconds > 59)
        {
            Minutes++;
            Seconds = 0;
            TwoDigitsSec = false;
        }
        if (Minutes > 9)
        {
            TwoDigitsMin = true;
        }
    }

    public void StartTime()
    {
        Debug.Log("haahaminionmemes");
        StartCoroutine(GainTime());
    }

    IEnumerator GainTime()
    {

        while (true)
        {
            yield return new WaitForSeconds(1);
            Seconds++;
        }
    }
}

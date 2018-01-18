using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonManager : MonoBehaviour {

    //0-15
    public GameObject Answer1Young;
    public GameObject Answer2Young;
    public GameObject Answer3Young;

    //16-24
    public GameObject Answer1Middle;
    public GameObject Answer2Middle;
    public GameObject Answer3Middle;
    public GameObject Answer4Middle;
    public GameObject Answer5Middle;
    public GameObject Answer6Middle;
    //25+
    public GameObject Answer1Old;
    public GameObject Answer2Old;
    public GameObject Answer3Old;
    public GameObject Answer4Old;
    public GameObject Answer5Old;


    void Update()
    {

    }

    #region YoungChangeAnswer
    public void YoungChangeAnswer(int id)
    {
        if (id == 0)
        {
            Answer1Young.SetActive(true);
        }
            
        if (id == 1)
        {
            Answer1Young.SetActive(false);
            Answer2Young.SetActive(true);
        }

        if (id == 2)
        {
            Answer1Young.SetActive(false);
            Answer2Young.SetActive(false);
            Answer3Young.SetActive(true);
        }

        if (id == 3)
        {
            Answer1Young.SetActive(false);
            Answer2Young.SetActive(false);
            Answer3Young.SetActive(false);
        }

        if (id == 4)
        {

        }

        if (id == 5)
        {

        }

        if (id == 6)
        {

        }
    }
    #endregion

    #region MiddleChangeAnswer
    public void MiddleChangeAnswer(int id)
    {
        if (id == 0)
        {
            Answer1Middle.SetActive(true);
        }

        if (id == 1)
        {
            Answer1Middle.SetActive(false);
            Answer2Middle.SetActive(true);
        }

        if (id == 2)
        {
            Answer1Middle.SetActive(false);
            Answer2Middle.SetActive(false);
            Answer3Middle.SetActive(true);
        }

        if (id == 3)
        {
            Answer1Middle.SetActive(false);
            Answer2Middle.SetActive(false);
            Answer3Middle.SetActive(false);
            Answer4Middle.SetActive(true);
        }

        if (id == 4)
        {
            Answer1Middle.SetActive(false);
            Answer2Middle.SetActive(false);
            Answer3Middle.SetActive(false);
            Answer4Middle.SetActive(false);
            Answer5Middle.SetActive(true);
        }

        if (id == 5)
        {
            Answer1Middle.SetActive(false);
            Answer2Middle.SetActive(false);
            Answer3Middle.SetActive(false);
            Answer4Middle.SetActive(false);
            Answer5Middle.SetActive(false);
            Answer6Middle.SetActive(true);
        }

        if (id == 6)
        {
            Answer1Middle.SetActive(false);
            Answer2Middle.SetActive(false);
            Answer3Middle.SetActive(false);
            Answer4Middle.SetActive(false);
            Answer5Middle.SetActive(false);
            Answer6Middle.SetActive(false);
        }
    }
    #endregion

    #region OldChangeAnswer
    public void OldChangeAnswer(int id)
    {
        if (id == 0)
        {
            Answer1Old.SetActive(true);
        }

        if (id == 1)
        {
            Answer1Old.SetActive(false);
            Answer2Old.SetActive(true);
        }

        if (id == 2)
        {
            Answer1Old.SetActive(false);
            Answer2Old.SetActive(false);
            Answer3Old.SetActive(true);
        }

        if (id == 3)
        {
            Answer1Old.SetActive(false);
            Answer2Old.SetActive(false);
            Answer3Old.SetActive(false);
            Answer4Old.SetActive(true);
        }

        if (id == 4)
        {
            Answer1Old.SetActive(false);
            Answer2Old.SetActive(false);
            Answer3Old.SetActive(false);
            Answer4Old.SetActive(false);
            Answer5Old.SetActive(true);

        }

        if (id == 5)
        {
            Answer1Old.SetActive(false);
            Answer2Old.SetActive(false);
            Answer3Old.SetActive(false);
            Answer4Old.SetActive(false);
            Answer5Old.SetActive(false);
        }

        if (id == 6)
        {

        }
    }
    #endregion
}
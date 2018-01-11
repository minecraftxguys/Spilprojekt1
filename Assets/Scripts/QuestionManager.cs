using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class QuestionManager : MonoBehaviour {


    public GameObject textBox;

    public Text theText;

    //public Text YoungText;
    //public Text MiddleText;
    //public Text OldText;

    public TextAsset YoungFile;
    public TextAsset MiddleFile;
    public TextAsset OldFile;
    public string[] YoungLines;
    public string[] MiddleLines;
    public string[] OldLines;
    public string[] textLines;

    public int currentLine;
    public int YoungEndAtLine;
    public int MiddleEndAtLine;
    public int OldEndAtLine;
    public int endAtLine;


    public bool isActive = true;
 


    private bool isTyping = false;
    private bool cancelTyping = false;

    public float typeSpeed;

    public GameObject GameManager;
    ButtonPressManager BPM;
    PointSystem PS;



    void Start()
    {
        PS = GameManager.GetComponent<PointSystem>();
        Debug.Log("hahahahha");
        BPM = GameManager.GetComponent<ButtonPressManager>();


        if (YoungFile != null)
        {
            YoungLines = (YoungFile.text.Split('\n'));
        }

        if (MiddleFile != null)
        {
            MiddleLines = (MiddleFile.text.Split('\n'));
        }

        if (OldFile != null)
        {
            OldLines = (OldFile.text.Split('\n'));
        }

        if (YoungEndAtLine == 0)
        {
            YoungEndAtLine = YoungLines.Length - 1;
        }

        if (MiddleEndAtLine == 0)
        {
            MiddleEndAtLine = MiddleLines.Length - 1;
        }

        if (OldEndAtLine == 0)
        {
            OldEndAtLine = OldLines.Length - 1;
        }

        if (isActive)
        {
            EnableTextBox();
        }
        else
        {
            DisableTextBox();
        }

    }

    void Update()
    {
        #region Checking for age
        if (BPM.Age == 1)
        {
            endAtLine = YoungEndAtLine;
            textLines = YoungLines;
        }

        if (BPM.Age == 2)
        {
            endAtLine = MiddleEndAtLine;
            textLines = MiddleLines;
        }

        if (BPM.Age == 3)
        {
            endAtLine = OldEndAtLine;
            textLines = OldLines;
        }
        #endregion

    #region Checklines if Young
        if (BPM.Age == 1)
        {
        if (currentLine == 0)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(0);
        }

        if (currentLine == 1)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(1);
        }

        if (currentLine == 2)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(2);
        }

        if (currentLine == 3)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(3);
        }

        if (currentLine == 4)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(4);
        }

        if (currentLine == 5)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(5);
        }

        if (currentLine == 6)
        {
            GameManager.GetComponent<ButtonManager>().YoungChangeAnswer(6);
        }
        }
        #endregion

    #region Checklines if Middle
        if (BPM.Age == 1)
        {
            if (currentLine == 0)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(0);
            }

            if (currentLine == 1)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(1);
            }

            if (currentLine == 2)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(2);
            }

            if (currentLine == 3)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(3);
            }

            if (currentLine == 4)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(4);
            }

            if (currentLine == 5)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(5);
            }

            if (currentLine == 6)
            {
                GameManager.GetComponent<ButtonManager>().MiddleChangeAnswer(6);
            }
        }
        #endregion

    #region Checklines if Old
        if (BPM.Age == 1)
        {
            if (currentLine == 0)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(0);
            }

            if (currentLine == 1)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(1);
            }

            if (currentLine == 2)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(2);
            }

            if (currentLine == 3)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(3);
            }

            if (currentLine == 4)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(4);
            }

            if (currentLine == 5)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(5);
            }

            if (currentLine == 6)
            {
                GameManager.GetComponent<ButtonManager>().OldChangeAnswer(6);
            }
        }
        #endregion

        if (!isActive)
        {
            return;
        }

    }

    public void QuestionAnswered()
    {

        PS.PointAdded();

            if (!isTyping)
            {

                currentLine += 1;


                if (currentLine > endAtLine)
                {
                    DisableTextBox();
                    //Application.LoadLevel("GameDay");

                    //Quiz is done
                }
                else
                {
                    StartCoroutine(TextScroll(textLines[currentLine]));
                }


            }
            else if (isTyping && !cancelTyping)
            {
                cancelTyping = true;
            }

        }

    public void QuestionFailed()
    {
        PS.PointNotAdded();

        if (!isTyping)
        {

            currentLine += 1;


            if (currentLine > endAtLine)
            {
                DisableTextBox();
                //Application.LoadLevel("GameDay");

                //Quiz is done
            }
            else
            {
                StartCoroutine(TextScroll(textLines[currentLine]));
            }


        }
        else if (isTyping && !cancelTyping)
        {
            cancelTyping = true;
        }

}

    private IEnumerator TextDelays()
    {
        yield return new WaitForSeconds(2f);
        StartCoroutine(TextScroll(textLines[currentLine]));
    }


    private IEnumerator TextScroll(string lineOfText)
    {
        int letter = 0;
        theText.text = "";
        isTyping = true;
        cancelTyping = false;
        while (isTyping && !cancelTyping && (letter < lineOfText.Length - 1))
        {
            theText.text += lineOfText[letter];
            letter += 1;
            yield return new WaitForSeconds(typeSpeed);
        }
        theText.text = lineOfText;
        isTyping = false;
        cancelTyping = false;
    }

    public void EnableTextBox()
    {
        textBox.SetActive(true);
        isActive = true;
        Debug.Log("Im enabled");



        StartCoroutine(TextDelays());
    }

    public void DisableTextBox()
    {
        textBox.SetActive(false);
        isActive = false;
    }


}
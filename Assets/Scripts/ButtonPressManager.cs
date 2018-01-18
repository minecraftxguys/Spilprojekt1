using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressManager : MonoBehaviour
{

    #region Publics and Privates
    //The GameObject in which the script is on
    public GameObject QuestionManager;
    public GameObject GamePanel;
    public GameObject AgeSelectPanel;
    public GameObject GameManager;

    //These objects are the. Correct and Wrong answer images that we enable and disable depending on if the answer is correct or wrong

    //wrong answers (redx)
    public GameObject LeftWrongAnswerImage;
    public GameObject MiddleWrongAnswerImage;
    public GameObject RightWrongAnswerImage;

    //correct answers (green thingy)
    public GameObject LeftCorrectAnswerImage;
    public GameObject MiddleCorrectAnswerImage;
    public GameObject RightCorrectAnswerImage;

    //References the "QuestionManager Script"
    private QuestionManager QM;
    //0 = The state where age can be defined
    public int Age = 0;

    //Boolean testing
    public bool CanAnswer = true;
    public bool canGetPoint = true;

    //Point System
    public float Point = 0;
    public float NotAPoint = 0;
    public Text ScoreCounter;
    #endregion

    // Use this for initialization
    void Start()
    {
        QM = QuestionManager.GetComponent<QuestionManager>();

    }

    // Update is called once per frame
	

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            PointAdded();
        }


        ScoreCounter.text = "Score: " + Point;
        #region AgeSelection
        if (Age == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GamePanel.SetActive(true);
                AgeSelectPanel.SetActive(false);
                StartCoroutine(LeftButtonWait());
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                GamePanel.SetActive(true);
                AgeSelectPanel.SetActive(false);
                StartCoroutine(MiddleButtonWait());
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                GamePanel.SetActive(true);
                AgeSelectPanel.SetActive(false);
                StartCoroutine(RightButtonWait());

            }
        }
        #endregion

        #region 0-15
        if (Age == 1)
        {
            #region LeftButton
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            //checks if user presses left button
            {
                Debug.Log("User pressed the left button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true) // add boolean. Turn to true when u cant write or whatever.
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 4)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 5)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion

            #region MiddleButton
            if (Input.GetKeyDown(KeyCode.UpArrow))
            //checks if user presses middle button
            {
                Debug.Log("User pressed the middle button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();

                }

                if (QM.currentLine == 4)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 5)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion

            #region RightButton
            if (Input.GetKeyDown(KeyCode.RightArrow))
            //checks if user presses right button
            {
                Debug.Log("User pressed the right button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightCorrectAnswerImage.SetActive(true);
                    StartCoroutine(RightCorrectAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    RightCorrectAnswerImage.SetActive(true);
                    StartCoroutine(RightCorrectAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 4)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 5)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion
        }

        #endregion

        #region 16-24
        if (Age == 2)
        {
            #region LeftButton
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            //checks if user presses left button
            {
                Debug.Log("User pressed the left button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 3 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 4 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 5 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion

            #region MiddleButton
            if (Input.GetKeyDown(KeyCode.UpArrow))
            //checks if user presses middle button
            {
                Debug.Log("User pressed the middle button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 3 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());

                }

                if (QM.currentLine == 4 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 5 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion

            #region RightButton
            if (Input.GetKeyDown(KeyCode.RightArrow))
            //checks if user presses right button
            {
                Debug.Log("User pressed the right button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 3 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 4 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 5 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    RightCorrectAnswerImage.SetActive(true);
                    StartCoroutine(RightCorrectAnswer());
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion
        }

        #endregion

        #region 25+
        if (Age == 3)
        {
            #region LeftButton
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            //checks if user presses left button
            {
                Debug.Log("User pressed the left button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 3 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 4 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 5)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion

            #region MiddleButton
            if (Input.GetKeyDown(KeyCode.UpArrow))
            //checks if user presses middle button
            {
                Debug.Log("User pressed the middle button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 3 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());

                }

                if (QM.currentLine == 4 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 5)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion

            #region RightButton
            if (Input.GetKeyDown(KeyCode.RightArrow))
            //checks if user presses right button
            {
                Debug.Log("User pressed the right button");
                if (QM.currentLine == 0 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 1 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 2 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 3 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 4 && CanAnswer == true)
                {
                    CanAnswer = false;
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 5)
                {
                    QM.QuestionFailed();
                }

                if (QM.currentLine == 6)
                {
                    QM.QuestionFailed();
                }
            }
            #endregion
        }

        #endregion
    }
    #region IEnumerators
    private IEnumerator LeftWrongAnswer()
    {
        yield return new WaitForSeconds(1f);
        CanAnswer = true;
        LeftWrongAnswerImage.SetActive(false);
    }

    private IEnumerator RightWrongAnswer()
    {
        yield return new WaitForSeconds(1f);
        CanAnswer = true;
        RightWrongAnswerImage.SetActive(false);
    }

    private IEnumerator MiddleWrongAnswer()
    {
        yield return new WaitForSeconds(1f);
        CanAnswer = true;
        MiddleWrongAnswerImage.SetActive(false);
    }

    private IEnumerator LeftCorrectAnswer()
    {
        yield return new WaitForSeconds(1f);
        CanAnswer = true;
        LeftCorrectAnswerImage.SetActive(false);
    }

    private IEnumerator RightCorrectAnswer()
    {
        yield return new WaitForSeconds(1f);
        CanAnswer = true;
        RightCorrectAnswerImage.SetActive(false);
    }

    private IEnumerator MiddleCorrectAnswer()
    {
        yield return new WaitForSeconds(1f);
        CanAnswer = true;
        MiddleCorrectAnswerImage.SetActive(false);
    }

    private IEnumerator LeftButtonWait()
    {
        yield return new WaitForSeconds(1f);
        Age = 1;
        QM.EnableTextBox();
    }

    private IEnumerator RightButtonWait()
    {
        yield return new WaitForSeconds(1f);
        Age = 3;
        QM.EnableTextBox();
    }

    private IEnumerator MiddleButtonWait()
    {
        yield return new WaitForSeconds(1f);
        Age = 2;
        QM.EnableTextBox();
    }
    #endregion

    #region Points

    public void PointAdded()
    {
        if (canGetPoint == true)
        {
            Point++;
            print("Added point");
        }
    }

    public void PointNotAdded()
    {
        NotAPoint++;
    }
    #endregion
}

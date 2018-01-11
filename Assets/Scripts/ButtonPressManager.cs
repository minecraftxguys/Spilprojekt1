using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonPressManager : MonoBehaviour {

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
    private Timer TM;
    //0 = The state where age can be defined
    public int Age = 0;

    //Point System
    public float Point = 0;
    public float NotAPoint = 0;
    public Text ScoreCounter;
    #endregion

    // Use this for initialization
    void Start ()
    {
        QM = QuestionManager.GetComponent<QuestionManager>();
        TM = GameManager.GetComponent<Timer>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ScoreCounter.text = "Score: " + Point;
        #region AgeSelection
        if (Age == 0)
        {
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                GamePanel.SetActive(true);
                AgeSelectPanel.SetActive(false);
                StartCoroutine(LeftButtonWait());
                TM.StartTime();
            }
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                Age = 2;
                GamePanel.SetActive(true);
                AgeSelectPanel.SetActive(false);
                TM.StartTime();
            }
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                Age = 3;
                GamePanel.SetActive(true);
                AgeSelectPanel.SetActive(false);
                TM.StartTime();
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 2)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 2)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionFailed();
                    RightCorrectAnswerImage.SetActive(true);
                    StartCoroutine(RightCorrectAnswer());
                }

                if (QM.currentLine == 2)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 2)
                {
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 4)
                {
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 5)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 2)
                {
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());

                }

                if (QM.currentLine == 4)
                {
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 5)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 2)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 4)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 5)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionAnswered();
                    LeftCorrectAnswerImage.SetActive(true);
                    StartCoroutine(LeftCorrectAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 2)
                {
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();
                    LeftWrongAnswerImage.SetActive(true);
                    StartCoroutine(LeftWrongAnswer());
                }

                if (QM.currentLine == 4)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionFailed();
                    MiddleWrongAnswerImage.SetActive(true);
                    StartCoroutine(MiddleWrongAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 2)
                {
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionAnswered();
                    MiddleCorrectAnswerImage.SetActive(true);
                    StartCoroutine(MiddleCorrectAnswer());

                }

                if (QM.currentLine == 4)
                {
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
                if (QM.currentLine == 0)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 1)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 2)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 3)
                {
                    QM.QuestionFailed();
                    RightWrongAnswerImage.SetActive(true);
                    StartCoroutine(RightWrongAnswer());
                }

                if (QM.currentLine == 4)
                {
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
        LeftWrongAnswerImage.SetActive(false);
    }

    private IEnumerator RightWrongAnswer()
    {
        yield return new WaitForSeconds(1f);
        RightWrongAnswerImage.SetActive(false);
    }

    private IEnumerator MiddleWrongAnswer()
    {
        yield return new WaitForSeconds(1f);
        MiddleWrongAnswerImage.SetActive(false);
    }

    private IEnumerator LeftCorrectAnswer()
    {
        yield return new WaitForSeconds(1f);
        LeftCorrectAnswerImage.SetActive(false);
    }

    private IEnumerator RightCorrectAnswer()
    {
        yield return new WaitForSeconds(1f);
        RightCorrectAnswerImage.SetActive(false);
    }

    private IEnumerator MiddleCorrectAnswer()
    {
        yield return new WaitForSeconds(1f);
        MiddleCorrectAnswerImage.SetActive(false);
    }

    private IEnumerator LeftButtonWait()
    {
        yield return new WaitForSeconds(1f);
        Age = 1;
    }
    #endregion

    #region Points

    public void PointAdded()
    {
        Point++;
    }

    public void PointNotAdded()
    {
        NotAPoint++;
    }
    #endregion
}

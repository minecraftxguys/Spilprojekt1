using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PointSystem : MonoBehaviour {

    public GameObject QuestionManager;
    private QuestionManager QM;
    private float Point = 0;
    private float NotAPoint = 0;
    public Text ScoreCounter;

	// Use this for initialization
	void Start ()
    {
        QM = QuestionManager.GetComponent<QuestionManager>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        ScoreCounter.text = "Score: " + Point;
        if (Input.GetKeyDown(KeyCode.P))
        {
            PointAdded();
        }
	}

    public void PointAdded()
    {
        Point++;
    }

    public void PointNotAdded()
    {
        NotAPoint++;
    }



}

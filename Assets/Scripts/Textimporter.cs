using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Textimporter : MonoBehaviour {

    public TextAsset YoungFile;
    public TextAsset MiddleFile;
    public TextAsset OldFile;
    public string[] YoungLines;
    public string[] MiddleLines;
    public string[] OldLines;

    // Use this for initialization
    void Start()
    {

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

    }

}
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Course : MonoBehaviour
{
    private string courseID;
    [SerializeField] private string currentWord;
    private bool isCompleted;

    private int totalPoints;
    private List<string> wordsUsed;
    // Start is called before the first frame update
    void Start()
    {

    }

    public string GetCurrentWord()
    {
        return currentWord;
    }

}

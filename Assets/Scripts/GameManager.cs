using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Burst.Intrinsics;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    //initialize unity details
    [Header(" Game Details ")]
    [SerializeField] private string gameWord;
    [SerializeField] private List<string> anagramsList;
    [SerializeField] private Dictionary<char, int> pointValues;

    [Header("Live Data")]
    [SerializeField] private int totalPoints;
    [SerializeField] private List<string> wordsUsed;


    // Start is called before the first frame update
    void Start()
    {
        InitializeGame();
        //InitializeTimer() or smth like that
    }

    //initialize all variables and signal the start of the course with a selected word
    private void InitializeGame()
    {
        totalPoints = 0;
        pointValues = new Dictionary<char, int>()
        {
            {'a', 1}, {'e', 1}, {'i', 1}, {'l', 1}, {'n', 1}, {'o', 1}, {'r', 1}, {'s', 1}, {'t', 1}, {'u', 1},
            {'d', 2}, {'g', 2},
            {'b', 3}, {'c', 3}, {'m', 3}, {'p', 3},
            {'f', 4}, {'h', 4}, {'v', 4}, {'w', 4}, {'y', 4},
            {'k', 5},
            {'j', 8}, {'x', 8},
            {'q', 10}, {'z', 10},
        };

        Debug.Log($"Game has begun with the word: {gameWord}");


    }

    public string GetGameWord()
    {
        return gameWord;
    }
    //check if the inputted word Can or Cannot be submitted and adjust the point values accordingly.
    public void submitWord(string word)
    {
        Debug.Log($"attempting to use word: {word}");
        Debug.Log($"Does the anagram list contain {word}?: {anagramsList.Contains(word)}");

        if (anagramsList.Contains(word) && !wordsUsed.Contains(word) /*|| check if word is in scrabble dictionary*/)
        {

            //true -> calculate points earned and increase totalPoints
            var pointsReceived = 0;
            wordsUsed.Add(word);
            foreach (char a in word)
            {
                pointsReceived += pointValues[a];
            }

            totalPoints += pointsReceived;
            Debug.Log($"Points received for word \"{word}\": {pointsReceived} points.");
            Debug.Log($"Total points now: {totalPoints}");
        }
        else
        {
            //false, output error msg --> need to define specific errors later
            Debug.Log($"\"{word}\" is not a valid word/has already been used.");
        }
    }

    //Sets the word for this game. Must be called separately so far (can you give the class/script a parameter upon instantiation?)
    public void SetWord(string word)
    {
        gameWord = word;
        Debug.Log($"gameWord has been updated to: \"{word}\".");
    }

    //load in the anagrams for the current word
    public void SetAnagramsList(List<string> anagrams)
    {
        this.anagramsList = anagrams;
        foreach (string word in anagrams)
        {
            Debug.Log($"added \"{word}\"");
        }
    }
}

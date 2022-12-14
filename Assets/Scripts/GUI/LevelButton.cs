using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class LevelButton : MonoBehaviour
{
    [SerializeField] private int id;
    [SerializeField] private GUIManager GUIManager;
    [SerializeField] private string jsonFileName;
    [SerializeField] private Course course;
    [SerializeField] private Button currentButton;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        currentButton.onClick.AddListener(() => ButtonPressedCallback());

        yield return null;

        currentButton.transform.SetParent(GameObject.Find("GUICanvas").transform);
    }

    public void ButtonPressedCallback()
    {
        SceneManager.LoadScene("GameScreen");
        GUIManager.StartGame(course.GetCurrentWord(), jsonFileName);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialScreenGUI : MonoBehaviour
{
    [SerializeField] private GUIManager TutorialScreenGUIManager;
    void Start()
    {
        TutorialScreenGUIManager.GenerateGUICanvas();
        TutorialScreenGUIManager.GenerateBackgroundCanvas();
        TutorialScreenGUIManager.GenerateEventSystem();
        TutorialScreenGUIManager.GenerateBackground();
        TutorialScreenGUIManager.GeneratePauseButton(1);
        TutorialScreenGUIManager.GenerateTextBox(new Vector2(0, 650), "TutorialTitle", new Vector2(600, 100), 90, "How to Play");
    }
}

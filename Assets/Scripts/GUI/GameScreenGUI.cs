using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameScreenGUI : MonoBehaviour
{
    [SerializeField] private GUIManager GameScreenGUIManager;
    [SerializeField] private GameManager GameManager;

    IEnumerator Start()
    {
        GameScreenGUIManager.GenerateGUICanvas();
        GameScreenGUIManager.GenerateBackgroundCanvas();
        GameScreenGUIManager.GenerateEventSystem();
        GameScreenGUIManager.GenerateKeyboard();
        GameScreenGUIManager.GenerateTextInputBox(1);
        GameScreenGUIManager.GenerateBackground(/*Resources.Load<Sprite>("Images/backgroundBlue")*/);
        GameScreenGUIManager.GeneratePauseButton(1);
        // initialize game/logic "StartGame()"

        yield return null;

        GameScreenGUIManager.GenerateTextBox(new Vector2(0, 200), "GameWordDisplay", new Vector2(Screen.width * .8f, Screen.height * .075f), 100, GameManager.GetGameWord());
    }
}

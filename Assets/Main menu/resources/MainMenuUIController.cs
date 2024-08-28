using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class MainMenuUIController : MonoBehaviour
{
    Button play, exit;
    void Start()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        play = root.Q<Button>("play");
        exit = root.Q<Button>("exit");

        play.RegisterCallback<ClickEvent>(onPlayButtonClicked);
        exit.RegisterCallback<ClickEvent>(onExitButtonClicked);
    }

    void onPlayButtonClicked(ClickEvent evt)
    {
        SceneManager.LoadSceneAsync(1);
    }
    void onExitButtonClicked(ClickEvent evt)
    {
        Application.Quit();
    }
}

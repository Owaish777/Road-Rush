using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class PauseMenuController : MonoBehaviour
{
    // Start is called before the first frame update
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
        gameObject.SetActive(false);
        Time.timeScale = 1;
    }
    void onExitButtonClicked(ClickEvent evt)
    {
        SceneManager.LoadSceneAsync(0);
        Time.timeScale = 1;
    }

    private void OnEnable()
    {
        VisualElement root = GetComponent<UIDocument>().rootVisualElement;
        play = root.Q<Button>("play");
        exit = root.Q<Button>("exit");

        play.RegisterCallback<ClickEvent>(onPlayButtonClicked);
        exit.RegisterCallback<ClickEvent>(onExitButtonClicked);


        Time.timeScale = 0;
    }
}

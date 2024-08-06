using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System.IO;
#if UNITY_EDITOR
using UnityEditor;
#endif

// Sets the script to be executed later than all default scripts
// This is helpful for UI, since other things may need to be initialized before setting the UI
[DefaultExecutionOrder(1000)]
public class MenuUIHandler : MonoBehaviour
//attached to Menu scene - Canvas
{
    public static MenuUIHandler Instance;

    public InputField nameInput;

    void Awake()
    {
        Instance = this;
    }

    public void StartNew()
    {
        DataHandler.Instance.playerName = nameInput.text;
        if (string.IsNullOrEmpty(DataHandler.Instance.playerName))
        {
            DataHandler.Instance.playerName = "Nameless";
        }
        SceneManager.LoadScene(1);
    }

    public void Exit()
    {
        //SaveName();

#if UNITY_EDITOR
        EditorApplication.ExitPlaymode();
#else
        Application.Quit();
#endif
    }


}

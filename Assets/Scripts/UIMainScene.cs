using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIMainScene : MonoBehaviour
{
    public static UIMainScene Instance;

    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }
}

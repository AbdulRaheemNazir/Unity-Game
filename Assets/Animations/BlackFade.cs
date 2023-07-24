using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BlackFade : MonoBehaviour
{
    void OnBlackFadeFinished()
    {
        if(SceneManager.GetActiveScene().name == "Menu")
        {
            SceneManager.LoadScene("king");
        }
        else if(SceneManager.GetActiveScene().name == "king")
        {
            SceneManager.LoadScene("menu");
        }
    }
}

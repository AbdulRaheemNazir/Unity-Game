using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour
{
    public Animator blackFadeAnim;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void OnPlayBtnPressed()
    {
        SceneManager.LoadScene("king");

        blackFadeAnim.SetTrigger("fadeIn");
    }




}

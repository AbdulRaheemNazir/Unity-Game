using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class medal : MonoBehaviour
{
    public Sprite normalMedal;
    public Sprite bronzeMedal;
    public Sprite silverMedal;
    public Sprite goldMedal;
    //public Sprite noMedal;
    Image img;


    // Start is called before the first frame update
    void Start()
    {
        img = GetComponent<Image>();
        int gameScore = GameManager.gameScore;


        if (gameScore > 0 && gameScore <= 10)
        {
            img.sprite = normalMedal;
        }
        else if (gameScore > 10 && gameScore <= 20)
        {
            img.sprite = bronzeMedal;
        }
        else if (gameScore > 20 && gameScore <= 40)
        {
            img.sprite = silverMedal;
        }
        else if (gameScore > 40)
        {
            img.sprite = goldMedal;
        }


    }

}

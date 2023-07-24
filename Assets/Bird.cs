using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : MonoBehaviour
{
    //refernces
    public Score score;
    public GameManager gameManager;
    public Animator getReadyAnim;
    public ColumnSpawner columnSpawner;
    public Animator hitEffect;

    Rigidbody2D rb;
    public float speed;

    bool touchedGround;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
        rb.gravityScale = 0;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0) &&
                GameManager.gameOver == false &&
                GameManager.gameIsPaused == false)

        {
            if(GameManager.gameHasStarted == false)
            {
                rb.gravityScale = 0.8f;
                Flap();
                getReadyAnim.SetTrigger("fadeout");
                //column spawner


            }
            else
            {
                Flap();
            }

   
        }


    }

    public void OnGetReadyAnimFinished()
    {
        columnSpawner.InstantiateColumn();
        gameManager.GameHasStarted();
    }



    void Flap()
    {
        rb.velocity = Vector2.zero;
        rb.velocity = new Vector2(rb.velocity.x, speed);
    }




















    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(GameManager.gameOver == false)
        {
            if (collision.CompareTag("column"))
            {
            //    print("We have scored");
                score.Scored();
            }
            else if (collision.CompareTag("Pipe"))
            {
                hitEffect.SetTrigger("hit");
                gameManager.GameOver();
            }
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground")) //make sure that it is set to ground collision not column
        {
            if(GameManager.gameOver == false)
            {
                hitEffect.SetTrigger("hit");
                gameManager.GameOver();
            }
            else
            {
                touchedGround = true;
            }
        }
    }


}
 
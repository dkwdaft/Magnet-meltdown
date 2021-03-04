using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum Polarity {Postive,Negative,Neutral}


public class Magnet : MonoBehaviour
{

    [HideInInspector] public Rigidbody2D Rb2D;
    public float strenth;
    GameManager gameManager;

    public Polarity polarity;

  

    Animator animator;
    

    SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();
        gameManager = FindObjectOfType<GameManager>();
        Rb2D = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        gameManager.AllMagnets.Add(this);

        if (polarity == Polarity.Postive)
        {
            animator.SetBool("positive", true);


        }
        else if (polarity == Polarity.Negative)
        {
            animator.SetBool("positive", false);


        }
        



    }

    // Update is called once per frame
    void Update()
    {

       
     

        
    }
    private void OnMouseDown()
    {



        if (gameManager.SelectedMagnet.Contains(this))
        {
           gameManager.SelectedMagnet.Remove(this);
           Rb2D.velocity = Vector2.zero;
            animator.SetBool("selected", false);
        }
        else
        {
            gameManager.SelectedMagnet.Add(this);
            animator.SetBool("selected", true);


        }

      

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class BoxButon : MonoBehaviour
{

    public List<bars> bars;

    public Sprite UpSprite;
    public Sprite DownSprite;

    public bool IsExit;
    public int ObjOnButon;

    bool isDoun;

    SpriteRenderer SpriteRenderer;
    GameManager GameManager;

    // Start is called before the first frame update
    void Start()
    {
        GameManager = FindObjectOfType<GameManager>();
        SpriteRenderer = GetComponent<SpriteRenderer>();
        SpriteRenderer.sprite = UpSprite;
        if (IsExit)
        {
            GameManager.exits.Add(this);
        }
    }



    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        ObjOnButon ++;
        SpriteRenderer.sprite = DownSprite;
        if (isDoun) { return; }
        foreach (var bar in bars)
        {
            if (bar.isOpen)
            {

                bar.close();
            }
            else
            {

            bar.Open();
            }

            
        }
        isDoun = true;
        if (IsExit)
        {
            GameManager.exits.Add(this);
            GameManager.TriExet();
        }

    }

    private void OnTriggerExit2D(Collider2D collision)
    {


        ObjOnButon--;

        if(ObjOnButon > 0) { return; }

        SpriteRenderer.sprite = UpSprite;
        foreach (var bar in bars)
        {
            if (bar.isOpen)
            {
            bar.close();

            }
            else
            {
                bar.Open();

            }





        }
        isDoun = false; 
    }
}

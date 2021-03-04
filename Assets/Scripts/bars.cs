using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bars : MonoBehaviour
{
    public bool isOpen;

    public GameObject metal;

    BoxCollider2D boxCollider2D;


    SpriteRenderer SpriteRenderer;
    // Start is called before the first frame update
    void Start()
    {
        SpriteRenderer = GetComponent<SpriteRenderer>();

        boxCollider2D = GetComponent<BoxCollider2D>();

        if (isOpen)  {Open(); } else { close(); }
        }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Open()
    {
        isOpen = true;



        metal.SetActive(false);


        boxCollider2D.isTrigger = true;
    }

    public void close()
    {
        isOpen = false;


        metal.SetActive(true);

        boxCollider2D.isTrigger = false;


    }

}

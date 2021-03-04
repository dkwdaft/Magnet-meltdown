using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Magnetic : MonoBehaviour
{

    [HideInInspector] public Rigidbody2D Rb2D;

    GameManager gameManager;
    public float weight; 

    Vector3 forse;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
        Rb2D = GetComponent<Rigidbody2D>();

        Rb2D.drag = weight;
        Rb2D.mass = weight;
        Rb2D.angularDrag = weight;
    }
    bool afected;

    // Update is called once per frame
    void Update()
    {
         afected = false;

        float totelPower = 0;
        forse = Vector3.zero;
        
        foreach (var magnet in gameManager.AllMagnets)
        {
        
           Vector3 tempforse = magnet.transform.position - transform.position;



 // if (tempforse.y <= -magnet.strenth || tempforse.y >= magnet.strenth)
            if (tempforse.y <= -magnet.strenth || tempforse.y >= magnet.strenth)
            {

            }
            else if  (tempforse.x <= -magnet.strenth || tempforse.x >= magnet.strenth)
            {

            }
            else
            {
                 afected = true;

                if (magnet.polarity == Polarity.Postive)
                {
                forse += tempforse;
                       totelPower += magnet.strenth; 
                }
                else if (magnet.polarity == Polarity.Negative)
                {
                        forse -= tempforse;
                        totelPower += magnet.strenth;
                }




            }
        }
        

        if ( totelPower >= weight && afected)
        {
        Rb2D.velocity = forse;
            
        }
        else
        {
            Rb2D.velocity = Vector3.zero;

        }
     
            
        
        


        

    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class backB : MonoBehaviour
{
    GameManager gameManager;
    // Start is called before the first frame update
    void Start()
    {
        gameManager = FindObjectOfType<GameManager>();
    }

    // Update is called once per frame
   public void pres()
    {
        Destroy(gameManager.gameObject);
        Destroy(Camera.main.gameObject);
        gameManager.LodeLeval(0);

       
    }

    public void FinedAndLode(int lode)
    {
        gameManager.LodeLeval(lode);

        
    }

}

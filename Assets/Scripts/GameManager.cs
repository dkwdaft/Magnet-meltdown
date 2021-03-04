using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Cinemachine;

public class GameManager : MonoBehaviour
{
    Camera mainCam;
    Vector3 mousePos;
    Vector3 Goto;
    public List<Magnet> SelectedMagnet;

    public List<Magnet> AllMagnets;
    public int Leval;
    public List<BoxButon> exits;

    public float distens;
    // Start is called before the first frame update
    void Start()
    {
        mainCam = Camera.main;
 


        DontDestroyOnLoad(gameObject);
        DontDestroyOnLoad(mainCam);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.R))
        {
            ReLodeLeval();

        }
        MoveSelectedMagnet();

        if(Goto.x < distens && Goto.x > -distens)
        {

            if (Goto.y < distens && Goto.y > -distens)
            {



transform.position = new Vector3(Goto.x, Goto.y, -9);

            }



        }

        



    }
    void MoveSelectedMagnet()
    {
       if (SelectedMagnet == null) { return; }
        mousePos = Input.mousePosition;
        mousePos.z = -10;

        Goto = mainCam.ScreenToWorldPoint(mousePos);

        foreach (var item in SelectedMagnet) 
        {
        item.Rb2D.velocity = (Goto - item.transform.position);
        }



       

    }
    public void TriExet()
    {

        foreach (var exit in exits)
        {
            if (exit.ObjOnButon < 1)
            {
                return;
            }


        }

        NextLeval();
    }


     void cleenUp()
    {

        Debug.Log("setUp");

        AllMagnets.Clear();
        SelectedMagnet.Clear();
        exits.Clear();
        

        transform.position = Vector3.zero;
     
       
    }



    
    public void NextLeval()
    {
        Leval++;
        SceneManager.LoadScene(Leval);
        cleenUp();
    }
    public void ReLodeLeval()
    {
      
        SceneManager.LoadScene(Leval);
        cleenUp();
    }
    public void LodeLeval(int levalToLode)
    {
        Leval = levalToLode;
        SceneManager.LoadScene(levalToLode);
        cleenUp();
    }

    public void levalSelect()
    {
        SceneManager.LoadScene("Levelselect");
    }

    public void goToManual()
    {
        SceneManager.LoadScene("manual");
    }

    public void quit()
    {
        Debug.Log("app quiting");
        Application.Quit();
    }

}

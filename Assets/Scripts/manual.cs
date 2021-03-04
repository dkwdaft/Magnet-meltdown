using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class manual : MonoBehaviour
{
   public void back()
    {
        SceneManager.LoadScene(0);
    }

    public void Controls()
    {
        SceneManager.LoadScene("Controls");
    }

    public void Objectives()
    {
        SceneManager.LoadScene("Objectives");
    }
}

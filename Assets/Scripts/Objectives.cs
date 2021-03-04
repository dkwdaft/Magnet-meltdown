using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Objectives : MonoBehaviour
{
    public void backToManual()
    {
        SceneManager.LoadScene("manual");
    }
}

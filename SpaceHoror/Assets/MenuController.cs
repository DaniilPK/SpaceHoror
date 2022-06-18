using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuController : MonoBehaviour
{
    public void ChengScenes(int numscen)
    {

        SceneManager.LoadScene(numscen);
    }

    public void Exit()
    { 
    Application.Quit();
    }
}

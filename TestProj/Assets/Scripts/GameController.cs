using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class GameController : MonoBehaviour
{
    public static int Score;
    [SerializeField] private Text txt;
    [SerializeField] private Text txt2;
    private int sc;
    private void Update()
    {
        // fps = 1.0f / Time.deltaTime; 
        // txt.text = "Fps: " + (int)fps;  фпс
    /* Время */    txt.text = "Time: " + System.DateTime.Now.Hour + ":" + System.DateTime.Now.Minute + ":" + System.DateTime.Now.Second;

        sc = GameController.Score;
        txt2.text = "Score: " + sc;// Результат
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuScript : MonoBehaviour {

    public GameObject menuPanel;

    void Start ()
    {
        Time.timeScale = 0;
    }

    public void onClickStart()
    {
        menuPanel.SetActive(false);
        Time.timeScale = 1;
    }
    public void onClickExit()
    {
        Application.Quit();
    }
}

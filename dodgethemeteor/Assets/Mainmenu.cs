using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Mainmenu : MonoBehaviour
{
    public GameObject mainmenue;
    public GameObject Player;
    public GameObject MenuCam;

    public void Start()

    {
        Player.SetActive(false);
        mainmenue.SetActive(true);
    }



    public void StartButton()

    {
        mainmenue.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
        Player.SetActive(true);
        MenuCam.SetActive(false);
    }

}


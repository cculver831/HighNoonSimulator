using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    public static bool PlayerSelect = false;
    public GameObject PlayerS;
    public GameObject optionsUI;
    public GameObject Main_Menu;
    public static bool MainM = true;
    public AnimationClip Camera;
    public GameObject Cam;
    private void Start()
    {
        Cam = GameObject.Find("Main Camera");
        Camera = gameObject.GetComponent<Animator>();
    }
    public void Play()
    {

        PlayerSelect = true;
        PlayerS.SetActive(true);
        Main_Menu.SetActive(false);
        MainM = false;
        //Camera.Play();



    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

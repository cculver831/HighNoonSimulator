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
    private Animator Camera;
    public GameObject Cam;
    private void Start()
    {
        Cam = GameObject.Find("Main Camera");
        Camera = Cam.GetComponent<Animator>();
    }
    public void Play()
    {
        Camera.Play("Camera_Pan");
        StartCoroutine(ChangeMenu());
        print(Time.time);
        PlayerS.SetActive(true);


    }

    // Update is called once per frame
    void Update()
    {
        
    }
    IEnumerator ChangeMenu()
    {
        Main_Menu.SetActive(false);
        print(Time.time);
        yield return new WaitForSeconds(2);
        
    }
}

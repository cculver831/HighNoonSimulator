using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDamage : MonoBehaviour
{
    private Animator Player;
    public float enemyHealth = 10f;
    public Camera DeathCam;
    public Camera Cam;
    public Canvas PlayerUI;

    private void Start()
    {
        DeathCam.gameObject.SetActive(false);
        Player = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
       if(enemyHealth <= 0)
        {
            PlayerUI.gameObject.SetActive(false);
            Player.SetBool("Idle", false);
            Player.SetBool("Dying", true);
            Cam.gameObject.SetActive(false); ;
            DeathCam.gameObject.SetActive(true);

        } 
    }
    public void DeductPoints(int Damage)
    {
        enemyHealth -= Damage;
    }
}

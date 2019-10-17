using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerDamage : MonoBehaviour
{
    private Animator PlayerAnim;
    public float enemyHealth = 10f;
    public Camera DeathCam;
    public Camera Cam;
    public Canvas PlayerUI;
    
    public Respawn Respawn;
    public GameObject Player;

    private void Start()
    {
        DeathCam.gameObject.SetActive(false);
        PlayerAnim = gameObject.GetComponent<Animator>();
    }
    void Update()
    {
       if(enemyHealth <= 0)
        {
            PlayerUI.gameObject.SetActive(false);
            PlayerAnim.SetBool("Idle", false);
            PlayerAnim.SetBool("Dying", true);
            Cam.gameObject.SetActive(false); ;
            DeathCam.gameObject.SetActive(true);
            //StartCoroutine(Spawning());
            enemyHealth = 10;

        }
        //else if (enemyHealth == 10)
        //{
        //    PlayerUI.gameObject.SetActive(true);
        //    PlayerAnim.SetBool("Idle", true);
        //    PlayerAnim.SetBool("Dying", false);
        //    Cam.gameObject.SetActive(true); ;
        //    DeathCam.gameObject.SetActive(false);
        //}
    }
    public void DeductPoints(int Damage)
    {
        enemyHealth -= Damage;
    }
    IEnumerator Spawning()
    {
        yield return new WaitForSeconds(3);
        Respawn.respawn(Player);
        PlayerUI.gameObject.SetActive(true);
        PlayerAnim.SetBool("Idle", true);
        PlayerAnim.SetBool("Dying", false);   
        Cam.gameObject.SetActive(true); ;
        DeathCam.gameObject.SetActive(false);
    }

}

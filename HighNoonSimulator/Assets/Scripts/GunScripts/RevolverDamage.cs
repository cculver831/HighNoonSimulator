using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RevolverDamage : MonoBehaviour
{
    //public ParticleSystem muzzleFlash;
    public int Damage = 5;
    public float fireRate = .25f;
    public float weaponRange = 50f;
    private LineRenderer laserLine;
    private float nextFire;

    public RaycastHit Shot;
    private Camera fpsCam;
    private WaitForSeconds shotDuration = new WaitForSeconds(0.7f);
    private void Start()
    {
        laserLine = GetComponent<LineRenderer>();
        fpsCam = GetComponentInParent<Camera>();
    }
    // Update is called once per frame
    void Update()
    {

        if (Input.GetButtonDown("Fire1") && Time.time > nextFire)
        {
            Shoot();
            nextFire = Time.time + fireRate;

        }
    }


    void Shoot()
    {
       // muzzleFlash.Play();
        RaycastHit Hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out Hit))
        {
            Debug.Log(Hit.transform.name);
            Hit.transform.SendMessage("DeductPoints", Damage, SendMessageOptions.DontRequireReceiver);
        }
    }
}

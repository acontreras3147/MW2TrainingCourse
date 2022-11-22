using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gun : MonoBehaviour
{
    public float damage = 10f;
    public float range = 100f;
    public Camera fpsCam;
    public ParticleSystem muzzleFlash;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            muzzleFlash.Play();
            Shoot();
        }
    }

    void Shoot()
    {
        RaycastHit hitInfo;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hitInfo, range))
        {
            
            Debug.Log(hitInfo.transform.name);
            
            Enemy enemy = hitInfo.transform.GetComponent<Enemy>();
            //if we actually hit something that is an "enemy"
            if (enemy != null)
            {
                //enemy health reduced by what we set damage to
                enemy.takeDamage(damage);
            }
        }
    }
}

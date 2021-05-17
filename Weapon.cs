using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{

    public Transform firePoint;

    public int maxAmmo = 1;
    public int currentAmmo;


    public GameObject itemPrefab;

    // Update is called once per frame

    void Start()
    {
        currentAmmo = 1;
    }
    void Update()
    {
        if (currentAmmo <= 0)
        {
            return;
        }

        if (Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
    }

    void Shoot()
    {
        currentAmmo--;

        //shooting logic
        Instantiate(itemPrefab, firePoint.position, firePoint.rotation);

    }
}

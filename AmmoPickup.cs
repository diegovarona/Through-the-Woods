using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AmmoPickup : MonoBehaviour
{
    public Weapon weapon;

    void Start()
    {
        weapon = GameObject.Find("Player").GetComponent<Weapon>();
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag.Equals("Player"))
        {
            if (weapon.currentAmmo == 0)
            {
                weapon.currentAmmo = 1;
                Destroy(gameObject);
                Destroy(gameObject);
            }

            else
            {
                return;
            }

        }
    }
}

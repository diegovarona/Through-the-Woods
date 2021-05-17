using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Respawn : MonoBehaviour
{

    [SerializeField] private GameObject player;
    [SerializeField] private Transform respawnPoint;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy"))
            player.transform.position = respawnPoint.transform.position;

        if (collision.gameObject.tag.Equals("Player"))
            player.transform.position = respawnPoint.transform.position;

    }
}
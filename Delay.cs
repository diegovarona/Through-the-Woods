using Pathfinding;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Delay : MonoBehaviour
{
    public AIBase movement;

    [SerializeField] private GameObject item;

    public float maxSpeed = 20f;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        maxSpeed -= 10f;
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        maxSpeed += 10f;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly_at_player : MonoBehaviour
{

    [SerializeField] Transform player;
    [SerializeField] float speed = 1.0f;
    Vector3 playerPosition;
 
    void Start()
    {
        playerPosition = player.transform.position;
    }

    void Update()
    {
        Vector3.MoveTowards(transform.position, playerPosition, speed*Time.deltaTime);
    }
}

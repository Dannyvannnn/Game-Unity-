using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ATTACH TO BOUNDARY/NON PLAYER OBJECTS
// THIS IS TO RESPAWN THE PLAYER IF HE DIES

// PLAYER : ATTACH THIRD PERSON PLAYER
// RESPAWN POINT : CHECKPOINT1

public class RespawnPoint : MonoBehaviour
{
    public Transform player;
    public Transform respawnPoint;
    //public bool triggered = false;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
        player.transform.position = respawnPoint.transform.position;
        Physics.SyncTransforms();
        //triggered = true;
        }
    }

}

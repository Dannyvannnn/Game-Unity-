using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ATTACH TO BOUNDARY/NON PLAYER OBJECTS
// CHANGE CHECKPOINT/RESPAWN POSITION

// PLAYER : THIRD PERSON PLAYER
// CHECKPOINT 1 : CHECKPOINT1 (CURRENT CHECKPOINT)
// CHECKPOIN 2 : CHECKPOINT2 (NEW CHECKPOINT LOCATION)

public class ChangeCheckpoint : MonoBehaviour
{
    public Transform Player;
    public Transform checkPoint1;
    public Transform checkPoint2;
    //public bool triggered = false;

    private void OnTriggerEnter(Collider other) 
    {
        if(other.gameObject.CompareTag("Player"))
        {
        checkPoint1.transform.position = checkPoint2.transform.position;
        Physics.SyncTransforms();
        //triggered = true;
        }
    }

}

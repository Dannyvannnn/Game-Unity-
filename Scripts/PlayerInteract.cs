using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInteract : MonoBehaviour
{
    
    bool active = false;
    [SerializeField]
    private GameObject platformSpawn;
    [SerializeField]
    private Transform position1;
    [SerializeField]
    private float _speed = 3.0f;
    private bool triggered = false;
    
     private void OnTriggerEnter(Collider other) { 
         if ( other.CompareTag("Player")){
            active = true;
         }
        }

        private void OnTriggerExit(Collider other){
             if ( other.CompareTag("Player")) {
            active = false;
             }
        }
    
    // Update is called once per frame
    private void Update()
    {
       
        if(Input.GetKeyDown(KeyCode.F) && active == true) {
           triggered = true;
           
        }
           if (triggered == true){
       platformSpawn.transform.position = Vector3.MoveTowards(platformSpawn.transform.position, position1.position,
                _speed * Time.deltaTime);
           }
        

    }
}



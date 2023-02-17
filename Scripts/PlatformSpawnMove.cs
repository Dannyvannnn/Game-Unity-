using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Place on the platform that is going to trigger the platform spawn
public class PlatformSpawnMove : MonoBehaviour

{
    
    [SerializeField]
    private GameObject platformSpawn;
    [SerializeField]
    private Transform position1;
    [SerializeField]
    private float _speed = 3.0f;

    private bool triggered = false;
    
    private void OnTriggerEnter(Collider other){
         if ( other.CompareTag("Player")) 
        {
           triggered = true;
        }
    
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    { 
      if (triggered == true){
       platformSpawn.transform.position = Vector3.MoveTowards(platformSpawn.transform.position, position1.position,
                _speed * Time.deltaTime);  
      }
}
}

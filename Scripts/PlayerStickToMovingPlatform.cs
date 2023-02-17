using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Place on the moving platform

public class PlayerStickToMovingPlatform : MonoBehaviour
{
   private void OnTriggerEnter(Collider other)
    {
        
            other.transform.parent = this.transform;
            
        
    }
     private void OnTriggerExit(Collider other)
    {
        
            other.transform.parent = null;
        
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

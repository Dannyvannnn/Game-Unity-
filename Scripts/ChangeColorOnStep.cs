using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColorOnStep : MonoBehaviour
{

        public bool triggered = false;
         public void OnTriggerEnter(Collider other)
         {
         // Change the cube color to green.
         MeshRenderer meshRend = GetComponent<MeshRenderer>();
         meshRend.material.color = Color.yellow;
         Debug.Log(other.name);
         triggered = true;
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

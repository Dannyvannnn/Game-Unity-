using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Place on the moving platform

public class MovingPlatform : MonoBehaviour
{

       [SerializeField]
    private Transform position1, position2;

        [SerializeField]
    private float _speed = 3.0f;
    private bool _switch = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
   void FixedUpdate()
    {

        if(_switch == false)
        {
            transform.position = Vector3.MoveTowards(transform.position, position1.position,
                _speed * Time.deltaTime);  
        }
        else if (_switch == true)
        {
            transform.position = Vector3.MoveTowards(transform.position, position2.position,
                _speed * Time.deltaTime);
        }

        if(transform.position == position1.position)
        {
            _switch = true;
        }
        else if(transform.position == position2.position)
        {
            _switch = false;
        }
        
    }
}

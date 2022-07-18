using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimRotativo : MonoBehaviour
{
    public float speed = 20;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0f, 0f, speed * Time.deltaTime);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0f, 0f, -speed * Time.deltaTime);
        }

    }
}

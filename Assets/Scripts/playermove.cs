using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//[System.Serializable]
//public class Boundary
//{
//    public float xMin, xMax;
//}

public class playermove : MonoBehaviour
{

    public float speed = 10;
    public float speed_rotation = 20;
    public bool Andando = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            //Audiomanager.PlaySound("Coche");
            Andando = true;
            transform.position += transform.up * Time.deltaTime * speed;
            //Audiomanager.PlaySound("Andando");

            if (Andando == true && Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0f, 0f, speed_rotation * Time.deltaTime);
            }
            if (Andando == true && Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0f, 0f, -speed_rotation * Time.deltaTime);
            }

        }
        else
        {
            
        }
       



        if (Input.GetKey(KeyCode.DownArrow))
        {
            Andando = true;
            transform.position -= transform.up * Time.deltaTime * speed;

            if (Andando == true && Input.GetKey(KeyCode.A))
            {
                transform.Rotate(0f, 0f, -speed_rotation * Time.deltaTime);
            }
            if (Andando == true && Input.GetKey(KeyCode.D))
            {
                transform.Rotate(0f, 0f, speed_rotation * Time.deltaTime);
            }
        }

        //if (Input.GetKey(KeyCode.LeftArrow))
        //{
        //    transform.position -= transform.right * Time.deltaTime * speed;
        //}

        //if (Input.GetKey(KeyCode.RightArrow))
        //{
        //    transform.position += transform.right * Time.deltaTime * speed;
        //}
    }

    private void Awake()
    {
        //Myrb = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        //float moveHorizontal = Input.GetAxis("Horizontal");
        //float moveVerical = Input.GetAxis("Vertical");

        //Vector3 movement = new Vector3(moveHorizontal, moveVerical);
        //Myrb.velocity = movement * speed;
        //Myrb.position = new Vector3(Mathf.Clamp(Myrb.position.x, boundary.xMin, boundary.xMax), 0f);
    }

    //public void ChangeSpeed(float speedMod, float timeToChange)
    //{
    //    speedModValue = speedMod;
    //    Invoke("ChangeSpeed2", timeToChange);
    //}

    //public void ChangeSpeed2()
    //{
    //    speed = speedModValue;
    //}
}

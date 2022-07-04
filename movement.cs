using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Vector3 myvec = new Vector3(1, 2, 3);
    public float movespeed = 40f;
    public float turnspeed = 140f;
   

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.S))
        {
            transform.Translate(Vector3.forward * Time.deltaTime * movespeed );
        }
        if (Input.GetKey(KeyCode.W))
        {
            transform.Translate(Vector3.back * Time.deltaTime * movespeed );
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * -turnspeed);
        }
        if (Input.GetKey(KeyCode.D))
        {
            transform.Rotate(Vector3.up * Time.deltaTime * turnspeed);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.left * Time.deltaTime * movespeed);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.right * Time.deltaTime * movespeed);
        }
    }

}

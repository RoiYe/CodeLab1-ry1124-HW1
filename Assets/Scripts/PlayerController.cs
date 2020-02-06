using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float force = 5;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello,World");
        rb = GetComponent<Rigidbody2D>();
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(Vector2.right * force);

    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Goodbye,World");

        if (Input.GetKey(KeyCode.A))//if D is pressed
        {
            rb.AddForce(Vector2.left * force);// moce right by force
        }
        if (Input.GetKey(KeyCode.S))//if D is pressed
        {
            rb.AddForce(Vector2.right * force);// moce right by force
        }
        if (Input.GetKey(KeyCode.W))//if D is pressed
        {
            rb.AddForce(Vector2.up * force);// moce right by force
        }
        if (Input.GetKey(KeyCode.Z))//if D is pressed
        {
            rb.AddForce(Vector2.down * force);// moce right by force
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public Text lostText;

    public float force = 5;
    Rigidbody2D rb;
    public Vector3 scaleChange = new Vector3(0.1f, 0.1f, 0);

    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello,World");
        rb = GetComponent<Rigidbody2D>();
        //Rigidbody2D rb = GetComponent<Rigidbody2D>();
        //rb.AddForce(Vector2.right * force);

    }

    // Update is called once per frame
    void FixedUpdate()
    {
        if (transform.position.x - transform.localScale.x/2 < -5 || transform.position.x + transform.localScale.x / 2 > 5 || transform.position.y - transform.localScale.y / 2 < -5 || transform.position.y + transform.localScale.y / 2 > 5)
        {
            Debug.Log("out of boarder");
            lostText.text = "You Lost!";
            lostText.gameObject.SetActive(true);

        }
        else
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector2 movement = new Vector2(moveHorizontal, moveVertical);
            rb.AddForce(movement * force);

            //if (Input.GetKey(KeyCode.A))//if A is pressed
            //{
            //    rb.AddForce(Vector2.left * force);// moce right by force
            //}
            //if (Input.GetKey(KeyCode.S))//if S is pressed
            //{
            //    rb.AddForce(Vector2.right * force);// moce right by force
            //}
            //if (Input.GetKey(KeyCode.W))//if W is pressed
            //{
            //    rb.AddForce(Vector2.up * force);// moce right by force
            //}
            //if (Input.GetKey(KeyCode.Z))//if Z is pressed
            //{
            //    rb.AddForce(Vector2.down * force);// moce right by force
            //}
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        transform.localScale += scaleChange;
    }
}

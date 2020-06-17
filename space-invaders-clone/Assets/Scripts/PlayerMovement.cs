using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    public float speed = 10f;
    Rigidbody2D rigidbody;

    // Start is called before the first frame update
    void Start()
    {
        rigidbody = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate() {

        //Get value from axis

        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");


        Vector2 direction = new Vector2(h, v);

        rigidbody.velocity = direction.normalized * speed;

        // Set Animation if paramete isFlyingLeft is true // SetBool(string name, bool value);

        GetComponent<Animator>().SetBool("isFlyingLeft", h < 0);
        GetComponent<Animator>().SetBool("isFlyingRight", h > 0);
        GetComponent<Animator>().SetBool("isFlyingTop", v > 0);
    }
}

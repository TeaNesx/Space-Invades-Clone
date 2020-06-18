using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToPlayer : MonoBehaviour
{

    public float speed = 1;

    // Start is called before the first frame update
    void Start()
    {

        // Find Gamobject by Tag
        GameObject gameObject = GameObject.FindWithTag("Player");

        // Get the distance between object1 to object2 and nomalized the distance between them (a² + b² = c²)
        Vector3 v3 = (gameObject.transform.position - transform.position).normalized;

        // Create new Vector 2d to get the distance between to object in 2D
        Vector2 v2 = new Vector2(v3.x, v3.y);

        // Move Rigidbody from the gameobject which this script is attached to. 
        // The velocity from this from ridgidbody2d is create by multiply the speed with the vector2 (v = a · t + v)
        GetComponent<Rigidbody2D>().velocity = v2 * speed;

    }
}

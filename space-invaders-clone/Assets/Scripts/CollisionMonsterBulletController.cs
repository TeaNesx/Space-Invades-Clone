using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionPlayerController : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Monster" || collision.gameObject.tag == "Bullet")
        {
            // 1. collider ist das object, mit dem collidiert wurde
            // 2. collider von dem object selbst, welches das Skript besitzt

            Physics2D.IgnoreCollision(collision.gameObject.transform.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }

        else
        {
            Destroy(gameObject);

            if (collision.gameObject.tag != "Wall")
            {
                Destroy(collision.gameObject);
            }
        }
    }
}

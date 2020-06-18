using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderCollision : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {

        // if the gamobject has tag player and bulletplayer will not be affected from destroy
        if(collision.gameObject.tag != "Player" && collision.gameObject.tag != "BulletPlayer")
        {

            // Destroy the gemObject which is not attached to the script.
            Destroy(collision.gameObject);
        }
    }
}

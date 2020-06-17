using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBulletController : MonoBehaviour
{

    public GameObject bullet;
    public float interval = 1f;
    public float statingInvoke = 1f;

    // Start is called before the first frame update
    void Start()
    {
        //Method Invoke is called after startingInvoke and then every Interval
        InvokeRepeating("ShootBullet", statingInvoke, interval);
    }

    void ShootBullet()
    {

        //New Bullet is Instantiate everytime ShootBullet Method is called
        GameObject g = Instantiate(bullet, transform.position, Quaternion.identity);
    }
}

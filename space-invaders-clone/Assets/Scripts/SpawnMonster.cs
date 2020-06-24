using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMonster : MonoBehaviour
{

    public GameObject monster1;
    public GameObject monster2;

    float intervall = 3f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnMonster", intervall, intervall);
    }

    void spawnMonster()
    {
        float v = Random.value;

        if (v < 0.2)
        {
            GameObject g = GameObject.Instantiate(monster1, transform.position, Quaternion.identity);
        } 
        else if (v < 0.4)
        {
            GameObject g = GameObject.Instantiate(monster2, transform.position, Quaternion.identity);

        }
    }

}

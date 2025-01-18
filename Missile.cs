using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missile : MonoBehaviour
{
    public int speed = 10;
    void Start()
        {
            Destroy(gameObject, 3);
        }
    

    // Update is called once per frame
    void Update()
    {
        transform.position += transform.forward * speed * Time.deltaTime;
    }

    void OnTriggerEnter(Collider other)
    {
        Enemy enemy = other.GetComponent<Enemy>();
        Destroy(enemy.gameObject);
        Destroy(gameObject);
        print("��� �����"); 
    }

     
}

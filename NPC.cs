using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public int health = 5;
    //здоровье
    public int level = 1;
    //уровень
    public float speed = 1.8f;
    //скорость
    

    // Start is called before the first frame update
    void Start()
    {
        print(health);
    }

    // Update is called once per frame
    void Update()
    {
    Vector3 newPosition = transform.position;
    newPosition.z += speed* Time.deltaTime;
    transform.position = newPosition;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trampline : MonoBehaviour
{
    public float jumpStrength = 2.2f;

    // Start is called before the first frame update
    void OnTriggerEnter(Collider other)
    {
        //увелечение скорости бега игрока
        other.GetComponent<Jump>().jumpStrength = 10;
    }

    // Update is called once per frame
    void OnTriggerExit(Collider other)
    {
        //понижение скорости бега игрока
        other.GetComponent<Jump>().jumpStrength = 2 ;
    }
}
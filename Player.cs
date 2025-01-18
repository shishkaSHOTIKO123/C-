using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public int coins;
    private int health = 10;
    public GameObject fireballPrefab;
    public Transform attackPoint;

    public void CollectCoins()
    {
        coins++;
        print("��������� ������" + coins);
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        print("�������� ������:" + health);
    }
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(fireballPrefab, attackPoint.position, attackPoint.rotation);
        }
    }

}

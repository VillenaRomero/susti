using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class createenemy : MonoBehaviour
{
    public GameObject prefabEnemy;
    public float minXposition;
    public float maxXposition;
    public float yPosition;
    private void Start()
    {
        Createenemy();
    }
    void Createenemy()
    {
        float xposition = Random.Range(minXposition, maxXposition);
        Vector2 positioncreate = new Vector2(xposition, yPosition);
        Instantiate(prefabEnemy, positioncreate, transform.rotation);
        Invoke("Createenemy", 1.0f);
    }
}

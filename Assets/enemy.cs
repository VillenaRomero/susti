using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private Rigidbody2D _rigibody2d;
    public float speedy;
    // Start is called before the first frame update
    void Awake()
    {
        _rigibody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void FixedUpdate()
    {
        _rigibody2d.velocity = new Vector2(0, -speedy);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "bullet")
        {
            Destroy(this.gameObject, 2);
        }
    }
}

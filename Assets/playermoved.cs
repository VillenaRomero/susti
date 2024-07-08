using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playermoved : MonoBehaviour
{
    public int life;
    public float speedx;
    public float speedy;
    private Rigidbody2D _compRigidbody2D;
    // Start is called before the first frame update
    private void Awake()
    {
        _compRigidbody2D = GetComponent<Rigidbody2D>();
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");
        _compRigidbody2D.velocity = new Vector2(speedx * horizontal, speedy * vertical);
    }
    public void OnCollisionStay2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "enemigo")
        {
            life = life - 1;

            if (life == 0)
            {
                Destroy(this.gameObject);
            }
        }
    }
}

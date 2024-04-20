using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float jumpForce = 5;
    Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.bodyType = RigidbodyType2D.Kinematic;
    }

    // Update is called once per frame
    void Update()
    {
        //mobil
        if(Input.touchCount > 0)
        {
            Touch parmak = (Touch)Input.GetTouch(0);
            if(parmak.phase == TouchPhase.Began)
            {
                rb.bodyType = RigidbodyType2D.Dynamic;
                rb.velocity = Vector2.up * jumpForce;
            }
        }
        //pc
        if (Input.GetButtonDown("Fire1"))
        {
            rb.bodyType = RigidbodyType2D.Dynamic;
            rb.velocity = Vector2.up * jumpForce;
        }
        
        // ekram taþma
        if(transform.position.y > 3.3)
        {
            transform.position = new Vector3(-9.49f, 3.3f);
        }

        // oyum bitti
        if (transform.position.y < -3.3)
        {
            Time.timeScale = 0f;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {   
        //temas oyum bitti 

        Time.timeScale = 0f;
    }

}

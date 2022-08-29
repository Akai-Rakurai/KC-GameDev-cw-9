using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Enemy_Script : MonoBehaviour
{
    Rigidbody2D Rb;
    public int speed;

    public Transform GroundCheck;
    public LayerMask ground; 
    // Start is called before the first frame update
    void Start()
    {
        Rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        patrol();
    }
    void patrol()
    {
        Rb.velocity = Vector2.right * speed;
        bool IsGrounded = Physics2D.OverlapCircle(GroundCheck.position, 1f, ground);
        if (!IsGrounded)
        {
            transform.localScale = new Vector2(-transform.localScale.x, transform.localScale.y);
            speed *= -1;
        }
    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(2);
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public bool gotHit;
    public float lives = 3;
    public bool Grounded = true;
    public float jumpForce = 100;
    public float speed = 5;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        PlayerMove();
        PlayerHit();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            lives = lives - 1;
            gotHit = true;
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            Grounded = true;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Spike"))
        {
            gotHit = false;
        }
        if (other.gameObject.CompareTag("Ground"))
        {
            Grounded = false;
        }
    }
    public void PlayerMove()
    {
        float xPos = Input.GetAxis("Horizontal");
        _playerRb.velocity = new Vector2(xPos * speed * Time.deltaTime, _playerRb.velocity.y);

        if (Input.GetKeyDown(KeyCode.UpArrow) && Grounded)
        {
            _playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
    public void PlayerHit()
    {

    }
}

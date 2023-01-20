using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public float lives = 3;
    public bool Grounded = true;
    public float jumpForce = 100;
    public float speed = 5;
    public bool CollisionHapp = false;
    public float Timer = 1f;


    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }


    void Update()
    { 
        PlayerMove();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Grounded = true;
        }
    }
    public void OnCollisionExit2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Ground"))
        {
            Grounded = false;
        }
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy") && CollisionHapp == false)
        {
            StartCoroutine(SecondsTimer());
            lives = lives - 1;
            _playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
            _playerRb.AddForce(Vector2.right * jumpForce, ForceMode2D.Impulse);
            CollisionHapp = true;
        }
        if (other.gameObject.CompareTag("Heart"))
        {
            lives = lives + 1;
            other.gameObject.SetActive(false);
        }
    }
    public void PlayerMove()
    {
        float xPos = Input.GetAxis("Horizontal");
        _playerRb.velocity = new Vector2(xPos * speed * Time.deltaTime, _playerRb.velocity.y);

        if (Input.GetKeyDown(KeyCode.W) && Grounded)
        {
            _playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    } 
    IEnumerator SecondsTimer()
    {
        yield return new WaitForSeconds(Timer);
        CollisionHapp = false;
    }
}

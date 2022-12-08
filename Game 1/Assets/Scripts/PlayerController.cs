using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public float jumpForce;
    public bool gotHit;
    public float lives = 3;
    public bool Grounded = true;
    public bool CollisionOccured = false;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        PlayerBounce();
        PlayerHit();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
        if(CollisionOccured)
        return;
        if (other.gameObject.CompareTag("Ground"))
        {
            CollisionOccured = true;
            Grounded = true;
        }
        if (other.gameObject.CompareTag("Spike"))
        {
            lives = lives - 1;
            gotHit = true;
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
            CollisionOccured = false;
        }
    }
    public void PlayerBounce()
    {
        if (Grounded)
        {
        _playerRb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
 
    }
    public void PlayerHit()
    {

    }
}

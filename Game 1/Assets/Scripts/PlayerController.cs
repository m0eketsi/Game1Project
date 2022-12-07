using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public float speed;
    public Animator charAnim;
    public bool gotHit;
    public float lives = 3;
    public float yPos = 0;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    { 
        PlayerFly();
        PlayerHit();
    }
    public void OnCollisionEnter2D(Collision2D other)
    {
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
    }
    public void PlayerFly()
    {
        yPos = Input.GetAxis("Vertical") * speed;
        transform.position = new Vector2(transform.position.x, yPos);
    }
    public void PlayerHit()
    {

    }
}

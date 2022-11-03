using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D _playerRb;
    public bool Grounded = true;
    public float jumpForce;
    public Animator charAnim;
    // Start is called before the first frame update
    void Start()
    {
        _playerRb = gameObject.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && Grounded)
        {
             _playerRb.AddForce(new Vector2(0, jumpForce));
             Grounded = false;
            charAnim.SetBool("Jumping", true);
        }
    }
}

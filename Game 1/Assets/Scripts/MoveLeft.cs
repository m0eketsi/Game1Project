using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveLeft : MonoBehaviour
{
    public float speed = 20;
    public float xPos = 12;
    public float yPos = -1;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
      transform.Translate(Vector3.left * Time.deltaTime * speed);
    }
    void FixedUpdate()
    {
      if (transform.position.x < -xPos)
      {
        transform.position = new Vector2(xPos, yPos);
      }
    }
}

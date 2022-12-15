using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
public Transform target;
public float speed = 3f;
 
 
void Start () {
         
}
void Update(){
     transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
}
}

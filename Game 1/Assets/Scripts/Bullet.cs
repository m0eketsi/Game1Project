using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float bulletSpeed = 10f;
    public float bounce = 20;
    public FollowPlayer enemyScript;

    void Update()
    {
        Rigidbody2D bulletRb;
        bulletRb = GetComponent<Rigidbody2D>();
        bulletRb.velocity = transform.up * bulletSpeed * Time.deltaTime;
        StartCoroutine(deleteBullet());
    }
    IEnumerator deleteBullet()
    {
        yield return new WaitForSeconds(3);
    }
    public void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Enemy"))
        {
            StartCoroutine(lockTimer());
                /*hitFX.SetActive(true);
                StartCoroutine(disableFX());*/
        }
    }
    IEnumerator lockTimer()
    {
        FollowPlayer enemyScript;
        enemyScript = GameObject.Find("Enemy").GetComponent<FollowPlayer>();
        enemyScript.enabled = false;
        yield return new WaitForSeconds(0.5f);
        enemyScript.enabled = true;
    }
}

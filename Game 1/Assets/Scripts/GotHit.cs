using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GotHit : MonoBehaviour
{
    public GameObject hitFX;
    public float Timer = 0.5f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Enemy"))
        {
        hitFX.SetActive(true);
        StartCoroutine(disableFX());
        }
    }
     IEnumerator disableFX()
    {
        yield return new WaitForSeconds(Timer);
        hitFX.SetActive(false);
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shooter : MonoBehaviour
{
    public float rotateSpeed = 5;
    public GameObject bullet;
    public GameObject player;
    public bool reloaded = true;
    public Slider ammoIcon;
    public float fillTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Shoot();
        mousePos();
        FillSlider();
    }
    public void Shoot()
    {
        if(Input.GetMouseButtonDown(0) && reloaded)
        {
            Instantiate(bullet, transform.position, transform.rotation);
            StartCoroutine(checkAmmo());
            ammoIcon.value = 0;
        }
    }
    public void mousePos()
    {
        Vector3 mousePosition;
        mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        Vector2 direction = mousePosition - transform.position;
        transform.up = direction;
        Cursor.visible = false;
    }
    public void FillSlider()
    {
        if (reloaded == false)
        {
        ammoIcon.value = Mathf.Lerp(0, 1, fillTime);
        fillTime += 0.375f * Time.deltaTime;
        }
    }
    IEnumerator checkAmmo()
    {
        reloaded = false;
        yield return new WaitForSeconds(5);
        reloaded = true;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Playershoot : MonoBehaviour
{
    public GameObject prefab;
    public float bulletspeed = 10.0f;
    public float bulletLifetime = 2.0f;
    public AudioClip shootSound;
    // Update is called once per frame
    void Update()
    {
        //when the mouse is clicked
        if (Input.GetButtonDown("Fire1"))
        {
            GameObject bullet = Instantiate(prefab, transform.position, Quaternion.identity);
            Vector3 mousePostition = Input.mousePosition;
            mousePostition = Camera.main.ScreenToWorldPoint(mousePostition);
            Vector3 shootDir = mousePostition - transform.position;
            shootDir.Normalize();
            bullet.GetComponent<Rigidbody2D>().velocity = shootDir * bulletspeed;
            Destroy(bullet, bulletLifetime);
            Camera.main.GetComponent<AudioSource>().PlayOneShot(shootSound);
        }
    }
}

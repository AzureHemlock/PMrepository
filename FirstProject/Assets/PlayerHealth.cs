using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealth : MonoBehaviour
{
    public int health = 10;
    public Text healthText;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        healthText.text = "Health: " + health;
    }
    void OnCollisionEnter2D(Collision2D collision) 
    {
        string otherName = collision.gameObject.name; 
        if(otherName == "Spikes")
        {
            health--; 
        }
    }
}

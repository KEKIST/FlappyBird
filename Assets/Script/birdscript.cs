using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class birdscript : MonoBehaviour
{
    [SerializeField] private float flapStrenghth;
    [SerializeField] private Rigidbody2D myrigidbody;
    [SerializeField] private Logic logic;
    [SerializeField] private AudioSource flySound;
    [SerializeField] private AudioSource hitSound;




    private void Start()
    {
        myrigidbody = GetComponent<Rigidbody2D>();
        Time.timeScale = 1;
        logic = GameObject.FindGameObjectWithTag("logic").GetComponent<Logic>();
    }

    private void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            myrigidbody.velocity = new Vector2(myrigidbody.velocity.x, flapStrenghth);
            flySound.Play();
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.collider.tag == "Enemy")
        {

            logic.GameOver();
            hitSound.Play();
            Time.timeScale = 0;
        }
       
    } 
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class NIGHTPlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public FeatherManager score;
    public AudioSource pickfeather;
    public GameObject panelpause;
    void Start()
    {
        panelpause.SetActive(false);
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (panelpause.activeInHierarchy == false )
        {
            if(Input.GetKeyDown("space"))
            {
                rb.velocity = Vector2.up * 8;
            }
        }
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag=="wall")
        {
            //SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            panelpause.SetActive(true);
        }

        if(collision.gameObject.tag=="feather")
        {
            
                score.score++;
                pickfeather.Play();
            
        }
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerMovement : MonoBehaviour
{
    Rigidbody2D rb;
    public FeatherManager score;
    public AudioSource pickfeather;
    public GameObject panelpause;
    public GameObject panelwin;
    void Start()
    {
        panelwin.SetActive(false);
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
            if(score.score == 19)
            {
                panelwin.SetActive(true);
            }
            else
            {
                score.score++;
                pickfeather.Play();
            }
            
        }
    }
}

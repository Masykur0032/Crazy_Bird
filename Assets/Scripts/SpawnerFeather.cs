using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerFeather : MonoBehaviour
{
    public GameObject coin;
    void Start()
    {
        InvokeRepeating("spawn", 3, 2);
    }

    // Update is called once per frame
    void spawn()
    {
        coin.SetActive(true);
        Instantiate(coin, new Vector2(transform.position.x,Random.Range(1.5f, -1.5f)), Quaternion.identity);
    }
}

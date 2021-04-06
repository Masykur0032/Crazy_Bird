﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelSpawnerWall : MonoBehaviour
{
    public GameObject wall;
    public GameObject feather;
    void Start()
    {
        InvokeRepeating("spawn", 2.7f, 0.9f);
    }

    // Update is called once per frame
    void spawn()
    {
		feather.SetActive(true);
        Instantiate(wall, new Vector2(transform.position.x,Random.Range(3, -2)), Quaternion.identity);
    }
}

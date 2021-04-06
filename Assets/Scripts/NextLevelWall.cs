using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextLevelWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, transform.right * 100, Time.deltaTime * -4.5f);
    }
}

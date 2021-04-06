using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown2 : MonoBehaviour
{
    float currentTime = 0f;
    float startingTime = 3f;
    public GameObject panel;

    [SerializeField] Text countdownText;

    void Start()
    {
        panel.SetActive(true);
        //Time.timeScale = 0f;
        currentTime = startingTime;
    }

    void Update()
    {
        currentTime -= 1 * Time.deltaTime;
        countdownText.text = currentTime.ToString ("0");

        if (currentTime <= 0)
        {
            currentTime = 0;
            panel.SetActive(false);
            Application.LoadLevel(4);
        }
    }
}

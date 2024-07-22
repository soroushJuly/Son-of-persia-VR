using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Chest : MonoBehaviour
{
    public GameObject GameObject;
    public GameObject score;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Text text = score.GetComponent<Text>();
        string scoreText = text.text.Substring(7);
        int scoreNum = Int32.Parse(scoreText);

            Debug.Log("above 100");
        if (scoreNum > 100)
        {
            GameObject.SetActive(true);
        }
    }
}

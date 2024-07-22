using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
//using static System.Net.Mime.MediaTypeNames;

public class TargetProjectile : MonoBehaviour
{
    // How much players get from hitting the target
    public int value;
    // Player score to add
    public GameObject score;
    // Start is called before the first frame update
    void Start() { }

    // Update is called once per frame
    void Update() { }
    private void OnTriggerEnter(Collider other)
    {
        // Collision detection between arrow and target
        if (other.gameObject.name == "ColliderArrowProjectile")
        {
            Text text = score.GetComponent<Text>();
            string scoreText = text.text.Substring(7);
            int scoreNum = Int32.Parse(scoreText);
            scoreNum += value;
            text.text = "score: " + scoreNum;
        }
    }
}

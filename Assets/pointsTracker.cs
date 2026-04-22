using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using TMPro;

public class pointsTracker : MonoBehaviour
{
    public static pointsTracker Instance;
    public TextMeshProUGUI scoreText;

    void Awake()
    {
        Instance = this;
        scoreText.text = "Points: 500";
    }

    public void AddScore(int amount)
    {
        GameObject player = GameObject.FindWithTag("Player");
        int points = Variables.Object(player).Get<int>("Points");

        points += amount;

        Variables.Object(player).Set("Points", points);
        scoreText.text = "Score: " + points;
    }

    public void subtractScore(int amount)
    {
        GameObject player = GameObject.FindWithTag("Player");
        int points = Variables.Object(player).Get<int>("Points");

        points -= amount;

        Variables.Object(player).Set("Points", points);
        scoreText.text = "Score: " + points;
    }
}

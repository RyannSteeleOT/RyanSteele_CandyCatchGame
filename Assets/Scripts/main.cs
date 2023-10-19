using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class main : MonoBehaviour
{

    [SerializeField] private Rigidbody2D candyPrefab;//Candy Object

    private float candyTimer;
    private int candyCount = 0;
    private int score = 0;

    [SerializeField] private TextMeshProUGUI scoreBoard;

    void Start()
    {
        candyTimer = Random.RandomRange(1, 4);
    }

    // Update is called once per frame
    void Update()
    {
        if (Time.time > candyTimer && candyCount < 15)
        {
            candyTimer = Time.time + Random.RandomRange(1, 4);
            Candy();
        }
    }

    void Candy()
    {
        candyCount++;
        Vector2 spawn = new Vector2 (Random.Range(-8f, 8f), 5.5f);
        Rigidbody2D newCandy = Instantiate(candyPrefab, spawn, Quaternion.identity);//Spawn object rigidbody
    }

    public void addScore(int amount)//Add points to the score
    {
        score += amount;
        scoreBoard.text = score.ToString();
    }

    public void reset()
    {
        candyCount = 0;
        score = 0;
        scoreBoard.text = score.ToString();
        candyTimer = Time.time + Random.RandomRange(1, 4);
    }

}

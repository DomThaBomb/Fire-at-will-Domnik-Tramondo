using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;

    public int asteroidCount = 1;

    public int lives = 1;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void PrintHello()
    {
        Debug.Log("Hello");
    }

    public void ReduceLivesByOne()
    {
       lives--;
       if (lives <= 0)
       {
           PrintGameOver();
       }
    }
    public void ReduceAsteroidCountByOne()
    {
        asteroidCount--;
        if (asteroidCount <= 0)
        {
            PrintVictory();
        }
    }
    public void PrintVictory()
    {
        Debug.Log("You Win!");
    }
    public void PrintGameOver()
    {
        Debug.Log("You lose!");
    }
}

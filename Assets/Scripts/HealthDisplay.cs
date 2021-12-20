using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private int lives = 5;
    private Text livesText;
    [SerializeField] private Text loserText;
    private LevelLoader levelLoader;
    
    
    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        levelLoader = FindObjectOfType<LevelLoader>();
        loserText.enabled = false;
        UpdateLives();
    }

    private void UpdateLives()
    {
        livesText.text = $"{lives} lives";
    }

    public void LoseLife()
    {
        lives -= 1;
        if (lives <= 0)
        {
            GameOver();
        }
        UpdateLives();
    }

    public void GameOver()
    {
        livesText.enabled = false;
        loserText.enabled = true;
        StartCoroutine(FindObjectOfType<LevelLoader>().LoadStartScreen());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

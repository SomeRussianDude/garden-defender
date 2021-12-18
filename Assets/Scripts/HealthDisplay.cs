using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthDisplay : MonoBehaviour
{
    private int lives = 5;
    private Text livesText;
    private LevelLoader levelLoader;
    
    
    // Start is called before the first frame update
    void Start()
    {
        livesText = GetComponent<Text>();
        levelLoader = FindObjectOfType<LevelLoader>();
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
            
        }
        UpdateLives();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

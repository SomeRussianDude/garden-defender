using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameTimer : MonoBehaviour
{
    [Tooltip("Duration of level in SECONDS")] [SerializeField]
    private float levelDuration = 10f;

    private bool timerFinishedTriggered = false;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (timerFinishedTriggered)
        {
            return;
        }
        GetComponent<Slider>().value = Time.timeSinceLevelLoad / levelDuration;

        bool timerFinished = (Time.timeSinceLevelLoad >= levelDuration);
        if (timerFinished)
        {
            FindObjectOfType<LevelController>().LevelTimerFinished();
            timerFinishedTriggered = true;
        }
    }
}
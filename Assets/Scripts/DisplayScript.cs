using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayScript : MonoBehaviour
{
    private TMPro.TextMeshProUGUI clock;

    private float gameTime = 0;

    void Start()
    {
        clock =
            GameObject.Find("ClockTMP").GetComponent<TMPro.TextMeshProUGUI>();
        gameTime = 0;
    }

    // Update is called once per frame
    void Update()
    {
        gameTime += Time.deltaTime;
    }

    private void LateUpdate()
    {
        int time = (int) gameTime;
        int hours = time / 3600;
        int minutes = (time % 3600) / 60;
        int seconds = time % 60;
        int deciseconds = (int)(gameTime * 10) % 10;
        clock.text = $"{hours:00}:{minutes:00}:{seconds:00}.{deciseconds:0}";
    }

    private void OnTriggerExit2D(Collider2D other)
    {
    }
}

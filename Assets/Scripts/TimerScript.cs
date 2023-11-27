using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour
{

    private TMPro.TextMeshProUGUI clock;

    [SerializeField]
    private Image vitalityIndicator;

    private float gameTime;

    void Start()
    {

        clock = GameObject.Find("ClockTMP").GetComponent<TMPro.TextMeshProUGUI>();

        vitalityIndicator.fillAmount = 1f;

        gameTime = 0;
    }

    void Update()
    {
        gameTime += Time.deltaTime;
    }

    private void LateUpdate()
    {
        int time = (int)gameTime;
        int hour = time / 3600;
        int minute = (time % 3600) / 60;
        int second = time % 60;
        int decisecond = (int)((gameTime - time) * 10);
        clock.text = $"{hour:00}:{minute:00}:{second:00}.{decisecond:0}";
    }
}

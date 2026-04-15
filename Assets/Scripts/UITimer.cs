using TMPro;
using UnityEngine;

public class UITimer : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float timeElapsed = 0f;
    private bool isRunning = false;

    public void StartTimer()
    {
        isRunning = true;
    }

    void Update()
    {
        if (isRunning)
        {
            timeElapsed += Time.deltaTime;
            timerText.text = "Tiempo: " + timeElapsed.ToString("F2");
        }
    }
}

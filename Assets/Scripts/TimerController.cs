using TMPro;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    public TextMeshProUGUI timerText;
    private float tiempo = 0.00f;

    void Update()
    {
        tiempo += Time.deltaTime;

        int minutos = Mathf.FloorToInt(tiempo / 60F);
        int segundos = Mathf.FloorToInt(tiempo % 60F);

        timerText.text = string.Format("{0:00}:{1:00}", minutos, segundos);
    }
    
}

using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEngine;

public class CinematicController : MonoBehaviour
{
    public CinemachineCamera[] cameras;
    public float timeForCamera = 8.0f;

    public MonoBehaviour playerMovementScript;

    private int currentIndex;
    private float timer;
    private bool isCameraFinished = false;

    void Start()
    {
        // Desactiva el scrip del players
        if (playerMovementScript != null)
        {
            playerMovementScript.enabled = false;
        }

        // Aseguramos que solo la primera cámara tenga prioridad alta
        for (int i = 0; i < cameras.Length; i++)
        {
            cameras[i].Priority = (i == 0) ? 20 : 10;
        }
    }
    void Update()
    {
        if (isCameraFinished) return;

        timer += Time.deltaTime;

        if (timer >= timeForCamera)
        {
            timer = 0f;
            ChangeCamera();
        }
    }
    [Button]
    public void ChangeCamera()
    {
        // Apaga la camara actual
        cameras[currentIndex].Priority = 10;
        currentIndex++;

        if (currentIndex < cameras.Length)
        {
            // Enciende la siguiente camara
            cameras[currentIndex].Priority = 20;
        }
        else
        {
            // Acaba la secuencia
            isCameraFinished = true;

            //Activa el script del FirstPersonPerson
            FinishCinematic();
        }

    }

    public void FinishCinematic()
    {
        isCameraFinished = true;

        // Habilita el movimiento del Player
        if (playerMovementScript != null)
        {
            playerMovementScript.enabled = true;
            Debug.Log("Cinemática terminada, control entregado al Player");
        }
    }
}

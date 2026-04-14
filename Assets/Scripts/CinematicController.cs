using Sirenix.OdinInspector;
using Unity.Cinemachine;
using UnityEngine;

public class CinematicController : MonoBehaviour
{
    public CinemachineCamera camA;
    public CinemachineCamera camB;
    void Start()
    {
        
    }

    [Button]
    public void SwitchCamara()
    {
        if(camB.Priority > camA.Priority)
        {
            camB.Priority = 10;
            camA.Priority = 20;
        }
        else
        {
            camB.Priority = 20;
            camA.Priority = 10;
        }
        
    }
}

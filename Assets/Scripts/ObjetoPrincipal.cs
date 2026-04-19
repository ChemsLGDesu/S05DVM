using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoPrincipal : MonoBehaviour
{
    public GameObject winText;

    private void OnTriggerEnter(Collider other)
    {       
        if (other.CompareTag("Player"))
        {
            Debug.Log("Meta alcanzada");
            if (winText != null)
            {
                winText.SetActive(true);
            }
        }

    }
}


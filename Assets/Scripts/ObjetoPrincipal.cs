using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ObjetoPrincipal : MonoBehaviour
{
    public GameObject objeto;
    public GameObject winText;
    public RawImage image;
    private void OnTriggerEnter(Collider other)
    {       
        if (other.CompareTag("Player"))
        {
            Debug.Log("Meta alcanzada");
            if (winText != null)
            {
                winText.SetActive(true);
                image.gameObject.SetActive(false);
                Destroy(objeto);
            }
        }

    }
}


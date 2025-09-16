using UnityEngine;
// Voeg de Input System namespace toe
using UnityEngine.InputSystem;

public class Candle1 : MonoBehaviour
{
    public bool KaarsIsAan = false;
    public GameObject Kaars;

    void Start()
    {
        // Zet de kaars uit bij de start.
        Kaars.SetActive(false);
    }
    void Update()
    {
        if (KaarsIsAan == true)
        {
            Kaars.SetActive(true);
            Debug.Log("Kaars is aan!");
        }
        else
        {
            Kaars.SetActive(false);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        // Voeg de knop-check toe aan je voorwaarde.
        // We controleren of de tag overeenkomt EN of de knop is ingedrukt.
        if (other.CompareTag("Fakkel"))
        {
            KaarsIsAan = true;
        }
    }
}
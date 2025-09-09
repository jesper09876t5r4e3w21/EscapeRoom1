using UnityEngine;

public class Candle4 : MonoBehaviour
{
    public bool KaarsIsAan = false;
    public GameObject Kaars4;

    void Start()
    {
        Kaars4.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Aansteker"))
        {
            KaarsIsAan = true;
            Kaars4.SetActive(true);
            Debug.Log("kaars Is aan!!");
        }
    }
}

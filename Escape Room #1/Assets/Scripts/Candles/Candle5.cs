using UnityEngine;

public class Candle5 : MonoBehaviour
{
    public bool KaarsIsAan = false;
    public GameObject Kaars5;

    void Start()
    {
        Kaars5.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Aansteker"))
        {
            KaarsIsAan = true;
            Kaars5.SetActive(true);
            Debug.Log("kaars Is aan!!");
        }
    }
}

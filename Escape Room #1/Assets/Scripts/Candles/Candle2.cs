using UnityEngine;

public class Candle2 : MonoBehaviour
{
    public bool KaarsIsAan = false;
    public GameObject Kaars2;

    void Start()
    {
        Kaars2.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Aansteker"))
        {
            KaarsIsAan = true;
            Kaars2.SetActive(true);
            Debug.Log("kaars Is aan!!");
        }
    }
}

using UnityEngine;

public class Candle1 : MonoBehaviour
{
    public bool KaarsIsAan = false;
    public GameObject Kaars1;

    void Start()
    {
        Kaars1.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Aansteker"))
        {
            KaarsIsAan = true;
            Kaars1.SetActive(true);
            Debug.Log("kaars Is aan!!");
        }
    }
}

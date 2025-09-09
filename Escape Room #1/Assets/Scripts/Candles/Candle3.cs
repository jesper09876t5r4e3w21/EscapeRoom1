using UnityEngine;

public class Candle3 : MonoBehaviour
{
    public bool KaarsIsAan = false;
    public GameObject Kaars3;

    void Start()
    {
        Kaars3.SetActive(false);
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Aansteker"))
        {
            KaarsIsAan = true;
            Kaars3.SetActive(true);
            Debug.Log("kaars Is aan!!");
        }
    }
}

using UnityEngine;

public class RodeBarrel : MonoBehaviour
{
    private int Zwaarden = 0;
    public GameObject Light;
    void Start()
    {
        Light.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Zwaarden == 2)
        { 
            Light.SetActive(true);
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZwaartRood"))
        {
            Zwaarden = +1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZwaartRood"))
        {
            Zwaarden = -1;
        }
    }
}

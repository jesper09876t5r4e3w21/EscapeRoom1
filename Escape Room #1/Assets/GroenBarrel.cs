using UnityEngine;

public class GroenBarrel : MonoBehaviour
{
    public int Zwaarden = 0;
    public bool GroenKlaar;
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
            GroenKlaar = true;
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZwaartGroen"))
        {
            Debug.Log("+1 zwaart");
            Zwaarden +=1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZwaartGroen"))
        {
            Debug.Log("-1 zwaart");
            Zwaarden -=1;
        }
    }
}

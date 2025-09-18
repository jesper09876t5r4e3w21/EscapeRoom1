using UnityEngine;

public class BlauwBarrel : MonoBehaviour
{
    public int Zwaarden = 0;
    public bool BlauwKlaar;
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
            BlauwKlaar = true;
        }  
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("ZwaartBlauw"))
        {
            Debug.Log("+1 zwaart");
            Zwaarden +=1;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("ZwaartBlauw"))
        {
            Debug.Log("-1 zwaart");
            Zwaarden -=1;
        }
    }
}

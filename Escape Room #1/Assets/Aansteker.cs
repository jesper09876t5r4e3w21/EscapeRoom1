using UnityEngine;

public class Aansteker : MonoBehaviour
{
    public GameObject Flam;
    public GameObject AanstekerModel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Flam.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void FlamAan()
    {
        Flam.SetActive(true);
    }
    public void FlamUit()
    {
        Flam.SetActive(false);
    }
}

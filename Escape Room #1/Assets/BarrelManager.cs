using UnityEngine;

public class BarrelManager : MonoBehaviour
{
    public RodeBarrel BarrelRood;
    public GroenBarrel BarrelGroen;
    public BlauwBarrel BarrelBlauw;
    public bool TasksFinishedBarrel = false;
    public GameObject Fakkel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Fakkel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (BarrelRood.RoodKlaar == true && BarrelGroen.GroenKlaar == true && BarrelBlauw == true)
        {
            TasksFinishedBarrel = true;
            Fakkel.SetActive(true);
        }
    }
    
}

using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.Interactables;

public class VentilatieRooster : MonoBehaviour
{
    public Schroef1 schroef1Script;
    public Schroef2 schroef2Script;
    public Schroef3 schroef3Script;
    public Schroef5 schroef5Script;

    public bool VentTaskFinished = false;

    private Rigidbody ventRoosterRb;
    private XRGrabInteractable ventRoosterGrab;

    void Start()
    {
        ventRoosterRb = GetComponent<Rigidbody>();
        ventRoosterGrab = GetComponent<XRGrabInteractable>();

        // Zet de grab-component uit en de Rigidbody op kinematic aan het begin.
        if (ventRoosterRb != null)
        {
            ventRoosterRb.isKinematic = true;
        }
        if (ventRoosterGrab != null)
        {
            ventRoosterGrab.enabled = false;
        }
    }

    void Update()
    {
        if (!VentTaskFinished)
        {
            CheckVoorAlleSchroevenLos();
        }
    }

    private void CheckVoorAlleSchroevenLos()
    {
        if (schroef1Script != null && schroef1Script.isLosgedraaid &&
            schroef2Script != null && schroef2Script.isLosgedraaid &&
            schroef3Script != null && schroef3Script.isLosgedraaid &&
            schroef5Script != null && schroef5Script.isLosgedraaid)
        {
            VentTaskFinished = true;
            Debug.Log("Alle schroeven zijn losgedraaid!");

            // Zodra alle schroeven los zijn, maak het object grabable.
            if (ventRoosterRb != null)
            {
                ventRoosterRb.isKinematic = false;
            }
            if (ventRoosterGrab != null)
            {
                ventRoosterGrab.enabled = true;
            }
        }
    }
}
using UnityEngine;

public class Schroef3 : MonoBehaviour
{
    // Deze booleaanse variabele wordt ingesteld als de schroef losgedraaid is.
    public bool isLosgedraaid = false;
    
    // Je hebt hier mogelijk een methode om de schroef los te draaien.
    // Bijvoorbeeld, als je met een gereedschap interacteert.
    private void OnTriggerEnter(Collider other)
    {
        // Controleer of het object dat de trigger binnengaat
        // de tag "schroevendraaier" heeft.
        if (other.CompareTag("schroevendraaier"))
        {
            // Als de tag overeenkomt, zet de boolean op 'true'.
            isLosgedraaid = true;
            Debug.Log("Schroef losgedraaid!");

            // Optioneel: verberg de schroef of maak hem kapot,
            // zodat hij niet meer zichtbaar is in de scène.
            gameObject.SetActive(false);
        }
    }
}
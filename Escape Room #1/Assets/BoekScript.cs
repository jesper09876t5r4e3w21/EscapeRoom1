using System.Collections;
using UnityEngine;

public class BoekScript : MonoBehaviour
{
    public AudioClip Schrijven;
    public AudioSource AudioSource;
    public GameObject StartText;
    public GameObject Hint1;
    public GameObject Hint2;
    public GameObject Hint3;
    public GameObject Hint4;
    public GameObject Hint5;
    public GameObject Hint6;

    public BarrelManager BarrelManagerScript;
    public CandleManager CandleManagerScript;
    public VentilatieRooster VentManagerScript;

    void Start()
    {
        StartCoroutine(Hints());
    }

    IEnumerator Hints()
    {
        // Toon de starttekst
        StartText.SetActive(true);
        AudioSource.PlayOneShot(Schrijven); // Speel het geluid eenmalig af bij de start
        yield return new WaitForSeconds(10);
        StartText.SetActive(false);

        // Wacht tot de Barrel taak is voltooid voordat je verder gaat
        while (BarrelManagerScript.TasksFinishedBarrel == false)
        {
            Hint1.SetActive(true);
            AudioSource.PlayOneShot(Schrijven);
            yield return new WaitForSeconds(120);
            Hint1.SetActive(false);

            if (BarrelManagerScript.TasksFinishedBarrel == false)
            {
                Hint2.SetActive(true);
                AudioSource.PlayOneShot(Schrijven);
                yield return new WaitForSeconds(120);
                Hint2.SetActive(false);
            }
        }
        
        // Wacht tot de Candle taak is voltooid voordat je verder gaat
        while (CandleManagerScript.CandleTaskFinished == false)
        {
            Hint3.SetActive(true);
            AudioSource.PlayOneShot(Schrijven);
            yield return new WaitForSeconds(120);
            Hint3.SetActive(false);

            if (CandleManagerScript.CandleTaskFinished == false)
            {
                Hint4.SetActive(true);
                AudioSource.PlayOneShot(Schrijven);
                yield return new WaitForSeconds(120);
                Hint4.SetActive(false);
            }
        }

        // Wacht tot de Vent taak is voltooid voordat je verder gaat
        while (VentManagerScript.VentTaskFinished == false)
        {
            Hint5.SetActive(true);
            AudioSource.PlayOneShot(Schrijven);
            yield return new WaitForSeconds(120);
            Hint5.SetActive(false);

            if (VentManagerScript.VentTaskFinished == false)
            {
                Hint6.SetActive(true);
                AudioSource.PlayOneShot(Schrijven);
                yield return new WaitForSeconds(120);
                Hint6.SetActive(false);
            }
        }
    }
}
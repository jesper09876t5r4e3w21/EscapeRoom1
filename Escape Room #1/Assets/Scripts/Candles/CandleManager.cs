using UnityEngine;

public class CandleManager : MonoBehaviour
{
    public Candle1 Candle1Script;
    public Candle2 Candle2Script;
    public Candle3 Candle3Script;
    public Candle4 Candle4Script;
    public Candle5 Candle5Script;

    public bool CandleTaskFinished = false;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        // Optioneel: Je kunt hier initialisatiecode toevoegen als dat nodig is.
    }

    // Update is called once per frame
    void Update()
    {
        // Roep de methode aan met de juiste naam en hoofdletter.
        CheckForLitCandles();
    }

    private void CheckForLitCandles()
    {
        // Controleer of alle kaars-scripts bestaan en of hun 'KaarsIsAan' variabele waar is.
        if (Candle1Script != null && Candle1Script.KaarsIsAan &&
            Candle2Script != null && Candle2Script.KaarsIsAan &&
            Candle3Script != null && Candle3Script.KaarsIsAan &&
            Candle4Script != null && Candle4Script.KaarsIsAan &&
            Candle5Script != null && Candle5Script.KaarsIsAan)
        {
            // Als alle voorwaarden voldaan zijn, zet de taak op voltooid.
            CandleTaskFinished = true;
            Debug.Log("Alle kaarsen zijn aangestoken! Taak voltooid.");
        }
        
    }
}
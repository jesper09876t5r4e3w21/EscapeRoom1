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

    }

    // Update is called once per frame
    void Update()
    {

    }
    private void CheckVoorAlleSchroevenLos()
    {
        if (Candle1Script != null && Candle1Script.KaarsIsAan &&
            Candle2Script != null && Candle2Script.KaarsIsAan &&
            Candle3Script != null && Candle3Script.KaarsIsAan &&
            Candle4Script != null && Candle4Script.KaarsIsAan &&
            Candle5Script != null && Candle5Script.KaarsIsAan)
        {
            CandleTaskFinished = true;
            Debug.Log("Alle schroeven zijn losgedraaid!");
        }
    }
}

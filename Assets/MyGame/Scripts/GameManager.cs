using TMPro;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int min = 1;
    [SerializeField] private int max = 1000;

    private int guess;

    [SerializeField] private TextMeshProUGUI guessText; 

    void Start()
    {
        
        CalculateNextGuess();
    }
    public void OnHigherPressed()
    {
        // Da die Zahl höher ist, wird das Minimum angehoben
        min = guess + 1;

        // Neuen Rateversuch berechnen und UI updaten
        CalculateNextGuess();
    }

    public void OnLowerPressed()
    {
        // Da die Zahl niedriger ist, wird das Maximum abgesenkt
        max = guess - 1;

        // Neuen Rateversuch berechnen und UI updaten
        CalculateNextGuess();
    }

    void CalculateNextGuess()
    {
        if (max < min)
        {
            max = min;
        }

        guess = (min + max) / 2;
        UpdateUI();
    }

    void UpdateUI()
    {
        if (guessText != null)
        {
            guessText.text = guess + "" + "?";
        }
    }
}

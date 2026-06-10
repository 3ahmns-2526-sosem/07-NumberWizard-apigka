using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int min = 1;
    [SerializeField] private int max = 1000;

    private int guess;

    [SerializeField] private TextMeshProUGUI guessText;

    [SerializeField] private Button higherButton;
    [SerializeField] private Button lowerButton;
    [SerializeField] private Button correctButton;

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

    public void OnCorrectPressed()
    {
        // Erfolgsmeldung in der UI anzeigen (der finale Guess bleibt im Text sichtbar)
        if (guessText != null)
        {
            guessText.text = $"Your number {guess}!";
        }

        // Buttons optional deaktivieren, damit kein weiterer Input möglich ist
        SetButtonsInteractable(false);
    }

    private void SetButtonsInteractable(bool state)
    {
        if (higherButton != null) higherButton.interactable = state;
        if (lowerButton != null) lowerButton.interactable = state;
        if (correctButton != null) correctButton.interactable = state;
    }

    void CalculateNextGuess()
    {
        if (max < min) max = min;
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

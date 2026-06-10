using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int min = 1;
    [SerializeField] private int max = 1000;

    private int initialMin;
    private int initialMax;
    private int guess;

    [SerializeField] private TextMeshProUGUI guessText;

    [SerializeField] private Button higherButton;
    [SerializeField] private Button lowerButton;
    [SerializeField] private Button correctButton;
    [SerializeField] private Button restartButton;

    void Start()
    {

        initialMin = min;
        initialMax = max;

        StartGame();
    }

    void StartGame()
    {
        
        min = initialMin;
        max = initialMax;

        
        SetButtonsInteractable(true);

      
        CalculateNextGuess();
    }

    public void OnRestartPressed()
    {
       
        StartGame();
    }

    public void OnHigherPressed()
    {
        
        min = guess + 1;

       
        CalculateNextGuess();
    }

    public void OnLowerPressed()
    {
       
        max = guess - 1;

       
        CalculateNextGuess();
    }

    public void OnCorrectPressed()
    {
        
        if (guessText != null)
        {
            guessText.text = $"Your number {guess}!";
        }

      
        SetButtonsInteractable(false);
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

    private void SetButtonsInteractable(bool state)
    {
        if (higherButton != null) higherButton.interactable = state;
        if (lowerButton != null) lowerButton.interactable = state;
        if (correctButton != null) correctButton.interactable = state;
    }
}

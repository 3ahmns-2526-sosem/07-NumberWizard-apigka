using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    [SerializeField] private int min;
    [SerializeField] private int max;

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

        if (guess < initialMax)
        {
            min = guess + 1;
        }

        CalculateNextGuess();
    }

    public void OnLowerPressed()
    {

        if (guess > initialMin)
        {
            max = guess - 1;
        }

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
        min = Mathf.Clamp(min, initialMin, initialMax);
        max = Mathf.Clamp(max, initialMin, initialMax);

        
        if (min > max)
        {
            min = max;
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

    private void SetButtonsInteractable(bool state)
    {
        if (higherButton != null) higherButton.interactable = state;
        if (lowerButton != null) lowerButton.interactable = state;
        if (correctButton != null) correctButton.interactable = state;
    }
}

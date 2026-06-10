using TMPro;
using UnityEngine;

public class Calculate : MonoBehaviour
{

    [SerializeField] private int min = 1;
    [SerializeField] private int max = 1000;

    private int guess;

    [SerializeField] private TextMeshProUGUI guessText; 

    void Start()
    {
        
        CalculateNextGuess();
    }

    void CalculateNextGuess()
    {
        
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

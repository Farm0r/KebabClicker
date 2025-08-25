using UnityEngine;
using TMPro;

public class Clicker : MonoBehaviour
{
    public float score = 0f;               // Dina kebabs
    public float kebabsPerClick = 1f;      // Poäng per klick
    public float kebabsPerSecond = 0f;     // Passiv poäng per sekund

    public TextMeshProUGUI scoreText;      // Text som visar poängen

    void Start()
    {
        UpdateUI();
        // Kör AddPassive varje sekund
        InvokeRepeating(nameof(AddPassive), 1f, 1f);
    }

    // Klick på kebab-knappen
    public void AddScore()
    {
        score += kebabsPerClick;
        UpdateUI();
    }

    // Köp grill som ger passiva kebabs
    public void BuyGrill()
    {
        float cost = 10f;
        if (score >= cost)
        {
            score -= cost;
            kebabsPerSecond += 0.1f; // Nu ger den 0.1 kebab/s
            UpdateUI();
        }
    }

    // Passiv inkomst
    void AddPassive()
    {
        score += kebabsPerSecond;
        UpdateUI();
    }

    void UpdateUI()
    {
        // Visar 1 decimal, t.ex. 12.3
        scoreText.text = "Kebabs: " + score.ToString("F1");
    }
}


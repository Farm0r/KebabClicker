using UnityEngine;

[System.Serializable]
public class Upgrade
{
    public string name;
    public float cost;
    public float bonusPerSec;

    [HideInInspector] public int owned = 0;       // Hur m�nga du har k�pt
    public int unlockNextTier = 10;               // Antal som beh�vs f�r n�sta boost
    public bool tierBoostPurchased = false;       // Om boosten redan k�pts
    public float tierMultiplier = 2f;             // Hur mycket bonus �kar
}


using UnityEngine;

[System.Serializable]
public class Upgrade
{
    public string name;
    public float cost;
    public float bonusPerSec;

    [HideInInspector] public int owned = 0;       // Hur många du har köpt
    public int unlockNextTier = 10;               // Antal som behövs för nästa boost
    public bool tierBoostPurchased = false;       // Om boosten redan köpts
    public float tierMultiplier = 2f;             // Hur mycket bonus ökar
}


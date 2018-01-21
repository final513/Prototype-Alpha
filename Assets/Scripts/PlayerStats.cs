using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

    public int currentLevel;
    public int currentXP;
    public int[] xpQuota; //Array containing how much xp is needed to level up
    public int currentHP;
    public int currentEP;
    public int currentAttack;
    public int currentDefense;
    public int currentAgility;
    public int[] hpLevels;
    public int[] epLevels;
    public int[] attackLevels;
    public int[] defLevels;
    public int[] agilityLevels;
    private PlayerHealthManager thePlayerHealth;
    
    
    // Use this for initialization
	void Start () {
        currentHP = hpLevels[currentLevel]; //Sets the current HP to the first index in HP array
        currentEP = epLevels[currentLevel]; //Sets the current EP to the first index in the EP array
        currentAttack = attackLevels[currentLevel]; //Sets the current attack to the first index in Attack array
        currentDefense = defLevels[currentLevel]; //Sets the current defense to the first index in the Defense array
        currentAgility = agilityLevels[currentLevel]; //Sets the current agility to the first index in the Agility array

        thePlayerHealth = FindObjectOfType<PlayerHealthManager>();
    }

    // Update is called once per frame
    void Update()
    {
        if (currentXP >= xpQuota[currentLevel]) //Check to see if the XP gained meets the array quota to level up
        {
            levelUp();
        }
    }
    public void AddXP (int xpToAdd) //When player gains XP, adds onto current XP (called from enemy scripts)
        {
            currentXP += xpToAdd;
        }

    public void levelUp()
    {
        currentLevel++;
        currentHP = hpLevels[currentLevel];
        currentEP = epLevels[currentLevel];

        thePlayerHealth.playerMaxHP = currentHP;
        thePlayerHealth.playerCurrentHP += currentHP - hpLevels[currentLevel - 1];

        currentAttack = attackLevels[currentLevel];
        currentDefense = defLevels[currentLevel];
        currentAgility = agilityLevels[currentLevel];
    }
	
}

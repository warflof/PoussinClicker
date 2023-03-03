using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Upgrades : MonoBehaviour
{
    private float Cost = 10.0f;
    private float Reward = 1f;
    public bool isPerClick;
    public bool isIdle;
    
    // Update is called once per frame
    public void UpgradeButton()
    {
        if (isPerClick)
        {
            if(GameManager.eggs >= Cost)
            {
                GameManager.eggs -= Cost;
                GameManager.multiplier += Reward;
            }
            else
            {
                var notEnoughEggs = GameObject.FindGameObjectWithTag("NotEnough");
                notEnoughEggs.GetComponent<Text>().enabled = true;
                Invoke("ResetText", 1);

            }
        }
        else if (isIdle)
        {
            if(GameManager.eggs >= Cost) // Vérifie si l'on a assez d'oeufs pour acheter l'amélio
            {
                GameManager.eggs -= Cost; // Retire le coût de l'amélioration au nombre d'oeufs
                GameManager.idleIncrement += Reward; // Ajoute la reward au Eggs/seconds
            }
            else
            {
                var notEnoughEggs = GameObject.FindGameObjectWithTag("NotEnough");
                notEnoughEggs.GetComponent<Text>().enabled = true;
                Invoke("ResetText", 1);

            }
        }
    }

    
}

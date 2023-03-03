using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static bool upBarBool;
    public static double eggs;
    public static float multiplier;
    public static float idleIncrement;
    
    // Variable Boost 1
    public static float costBoostOne;
    public static float countBoostOne;
    public static float countIdleOne;
    
    // Variable Boost 2
    public static float boostTwo;
    public static float countBoostTwo;
    public static float countIdleTwo;
    
    // Variable Boost 3
    public static float boostThree;
    public static float countBoostThree;
    public static float countIdleThree;
    
    // Variable Boost 4
    public static float boostFour;
    public static float countBoostFour;
    public static float countIdleFour;

    // Variable Boost 5
    public static float boostFive;
    public static float countBoostFive;
    public static float countIdleFive;

    // Upgrades EPC --------------------------------------------------------------------------------------

    public static float upEPCone;
    public static float upEPCtwo;
    public static float upEPCthree;
    public static float upEPCfour;
    public static float upEPCfive;

    //UP EPC ONE
    public static GameObject upgradeEPCone;
    public static bool upEPCinterractoneBool;
    public static bool upEPConeSetActiveBool;
    public static GameObject upEPConeSetActive;
    
    
    //UP EPC TWO
    public static GameObject upgradeEPCtwo;
    public static bool upEPCtwoBool;
    
    //UP EPC THREE
    public static GameObject upgradeEPCthree;
    public static bool upEPCthreeBool;
    
    
    // UP EPC FOUR
    public static GameObject upgradeEPCfour;
    public static bool upEPCfourBool;

    // UP EPC FIVE
    public static GameObject upgradeEPCfive;
    public static bool upEPCfiveBool;


    // Start is called before the first frame update
    
    
    
    void Start()
    {
        
        eggs = 10000f;
        multiplier = 1f; // Sert uniquement pour la valeur du clique
        idleIncrement = 0f;
        InvokeRepeating("IncrementIdle", 1, 1);
       
       // Variable Boost 1
        costBoostOne = 25f;
        countBoostOne = 0f;
        countIdleOne = 0.0f;

       // Variable Boost 2 
        boostTwo = 150f;
        countBoostTwo = 0f;
        countIdleTwo = 0f;
       
       // Variable Boost 3
        boostThree = 1500f;
        countBoostThree = 0f;
        countIdleThree = 0f;

       // Variable Boost 4 
        boostFour = 3000f;
        countBoostFour = 0f;
        countIdleFour = 0f;

        // Variable Boost 5 
        boostFive = 10000f;
        countBoostFive = 0f;
        countIdleFive = 0f;

        // UPGRADE EPC -------------------------------------------------------
        upEPCone = 100f;
        upEPCtwo = 300f;
        upEPCthree = 900f;
        upEPCfour = 2700f;
        upEPCfive = 23400f;
        
        
        
       

    }

    public void IncrementIdle()
    {
        eggs += idleIncrement;
    }

      public void Increment()
    {
        eggs += multiplier;
    }
    
}

     

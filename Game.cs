using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class Game : MonoBehaviour
{
    public static GameObject upgradeBar;
    public Text eggs;
   
   // Variable Boost 1
    public Text costBoostOne;
    public Text countBoostOne;
    public Text countIdleOne;
    
    // Variable Boost 2
    public Text boostTwo;
    public Text countBoostTwo;
    public Text countIdleTwo;
    
    // Variable Boost 3
    public Text boostThree;
    public Text countBoostThree;
    public Text countIdleThree;
   
    // Variable Boost 4
    public Text boostFour;
    public Text countBoostFour;
    public Text countIdleFour;

      // Variable Boost 5
    public Text boostFive;
    public Text countBoostFive;
    public Text countIdleFive;

    // Variable Boost EPC 1
    public Text countEPCone;

    // Variable Boost EPC 2
    public Text countEPCtwo;

    // Variable Boost EPC 3
    public Text countEPCthree;

    //Variable Boost EPC 4
    public Text countEPCfour;

    //Variable Boost EPC 5
    public Text countEPCfive;
    
    
    
    public Text eggsPerSeconds;
    public Text eggsPerClick;

    
   
   
    public void Increment() // Permet de cliquer sur le poussin pour gagner des oeufs
    {
        GameManager.eggs += GameManager.multiplier;
    }

    // -------------------------- LES BOOST (ACTIONS DES BOUTONS D'AMELIORATION) ----------------------------


    
  
    
    public void UpgradeEPSFive()
    {
        if(GameManager.boostFive >= 1500f && GameManager.boostFive <= GameManager.boostFive * 5)
        {
            GameManager.boostFive *= 1.1f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 5 && GameManager.boostFive <= GameManager.boostFive * 10)
        {
            GameManager.boostFive *= 1.2f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 10 && GameManager.boostFive <= GameManager.boostFive * 20)
        {
            GameManager.boostFive *= 1.3f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 20 && GameManager.boostFive <= GameManager.boostFive * 30)
        {
            GameManager.boostFive *= 1.4f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 30 && GameManager.boostFive <= GameManager.boostFive * 40)
        {
            GameManager.boostFive *= 1.5f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 40 && GameManager.boostFive <= GameManager.boostFive * 50)
        {
            GameManager.boostFive *= 1.6f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 50 && GameManager.boostFive <= GameManager.boostFive * 60)
        {
            GameManager.boostFive *= 1.7f;
        } 
    }

// Bouton Max --------------------------------------    
/*    public void UpgradeEPSOneMax()
    
    { 
        
        
        //Boost Max 1
        
        float eggsF = GameManager.eggs;
        
        float boostOneF = GameManager.costBoostOne;
        
        float buyMaxOne;
        
        float increment = 1.05f;

        var dividendeOne = increment * GameManager.costBoostOne;
        
        buyMaxOne = eggsF * boostOneF;
        
        buyMaxOne = GameManager.eggs / GameManager.costBoostOne;

        if(GameManager.countBoostOne >= 0f && GameManager.countBoostOne <= 1000f)
        {
           dividendeOne *= buyMaxOne;
        }
        if(GameManager.costBoostOne >= 1000f && GameManager.costBoostOne <= 10000f)
        {
            buyMaxOne *= (GameManager.costBoostOne *= 1.06f);
        }
        if(GameManager.costBoostOne >= 100000f && GameManager.costBoostOne <= 1000000f)
        {
            buyMaxOne *= (GameManager.costBoostOne *= 1.07f);
        }
        if(GameManager.costBoostOne >= 10000000f && GameManager.costBoostOne <= 100000000f)
        {
            buyMaxOne *= (GameManager.costBoostOne *= 1.08f);
        }
        if(GameManager.costBoostOne >= 1000000000f)
        {
            buyMaxOne *= (GameManager.costBoostOne *= 1.09f);
        }
        Debug.Log(buyMaxOne.ToString() + " Achat Max de la fonction");
    }
    public void UpgradeEPSTwoMax()
    
    { 
        float buyMaxTwo;
        float eggsF = GameManager.eggs;
        float boostTwoF = GameManager.boostTwo;
        
        buyMaxTwo = GameManager.eggs / GameManager.boostTwo;

        if(GameManager.countBoostTwo >= 0f && GameManager.countBoostOne <= 1000f)
        {
            buyMaxTwo *= (GameManager.boostTwo *= 1.05f);
        }
        if(GameManager.boostTwo >= 1000f && GameManager.boostTwo <= 10000f)
        {
            buyMaxTwo *= (GameManager.boostTwo *= 1.06f);
        }
        if(GameManager.boostTwo >= 100000f && GameManager.boostTwo <= 1000000f)
        {
            buyMaxTwo *= (GameManager.boostTwo *= 1.07f);
        }
        if(GameManager.boostTwo >= 10000000f && GameManager.boostTwo <= 100000000f)
        {
            buyMaxTwo *= (GameManager.boostTwo *= 1.08f);
        }
        if(GameManager.boostTwo >= 1000000000f)
        {
            buyMaxTwo *= (GameManager.boostTwo *= 1.09f);
        }
    }
    public void UpgradeEPSThreeMax()
    {
        float buyMaxThree;
        float eggsF = GameManager.eggs;
        float boostThreeF = GameManager.boostThree;

         buyMaxThree = GameManager.eggs / GameManager.boostThree;

        if(GameManager.boostThree >= 1500f && GameManager.boostThree <= GameManager.boostThree * 5)
        {
            buyMaxThree *= GameManager.boostThree *= 1.1f;
        }
        if(GameManager.boostThree >= GameManager.boostThree * 5 && GameManager.boostThree <= GameManager.boostThree * 10)
        {
            buyMaxThree *= GameManager.boostThree *= 1.2f;
        }
        if(GameManager.boostThree >= GameManager.boostThree * 10 && GameManager.boostThree <= GameManager.boostThree * 20)
        {
            buyMaxThree *= GameManager.boostThree *= 1.3f;
        }
        if(GameManager.boostThree >= GameManager.boostThree * 20 && GameManager.boostThree <= GameManager.boostThree * 30)
        {
            buyMaxThree *= GameManager.boostThree *= 1.4f;
        }
        if(GameManager.boostThree >= GameManager.boostThree * 30 && GameManager.boostThree <= GameManager.boostThree * 40)
        {
            buyMaxThree *= GameManager.boostThree *= 1.5f;
        }
        if(GameManager.boostThree >= GameManager.boostThree * 40 && GameManager.boostThree <= GameManager.boostThree * 50)
        {
            buyMaxThree *= GameManager.boostThree *= 1.6f;
        }
        if(GameManager.boostThree >= GameManager.boostThree * 50 && GameManager.boostThree <= GameManager.boostThree * 60)
        {
            buyMaxThree *= GameManager.boostThree *= 1.7f;
        }
    }
    public void UpgradeEPSFourMax()
    {
        float buyMaxFour;
        float eggsF = GameManager.eggs;
        float boostFourF = GameManager.boostFour;

         buyMaxFour = GameManager.eggs / GameManager.boostFour;

        if(GameManager.boostFour >= 3000f && GameManager.boostFour <= GameManager.boostFour * 5)
        {
            buyMaxFour *= GameManager.boostFour *= 1.1f;
        }
        if(GameManager.boostFour >= GameManager.boostFour * 5 && GameManager.boostFour <= GameManager.boostFour * 10)
        {
            buyMaxFour *= GameManager.boostFour *= 1.2f;
        }
        if(GameManager.boostFour >= GameManager.boostFour * 10 && GameManager.boostFour <= GameManager.boostFour * 20)
        {
            buyMaxFour *= GameManager.boostFour *= 1.3f;
        }
        if(GameManager.boostFour >= GameManager.boostFour * 20 && GameManager.boostFour <= GameManager.boostFour * 30)
        {
            buyMaxFour *= GameManager.boostFour *= 1.4f;
        }
        if(GameManager.boostFour >= GameManager.boostFour * 30 && GameManager.boostFour <= GameManager.boostFour * 40)
        {
            buyMaxFour *= GameManager.boostFour *= 1.5f;
        }
        if(GameManager.boostFour >= GameManager.boostFour * 40 && GameManager.boostFour <= GameManager.boostFour * 50)
        {
            buyMaxFour *= GameManager.boostFour *= 1.6f;
        }
        if(GameManager.boostFour >= GameManager.boostFour * 50 && GameManager.boostFour <= GameManager.boostFour * 60)
        {
            buyMaxFour *= GameManager.boostFour *= 1.7f;
        }
    }
    public void UpgradeEPSFiveMax()
    {
        float buyMaxFive;
        float eggsF = GameManager.eggs;
        float boostFiveF = GameManager.boostFive;

        buyMaxFive = GameManager.eggs / GameManager.boostFive;

        if(GameManager.boostFive >= 1500f && GameManager.boostFive <= GameManager.boostFive * 5)
        {
            buyMaxFive *= GameManager.boostFive *= 1.1f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 5 && GameManager.boostFive <= GameManager.boostFive * 10)
        {
            buyMaxFive *= GameManager.boostFive *= 1.2f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 10 && GameManager.boostFive <= GameManager.boostFive * 20)
        {
            buyMaxFive *= GameManager.boostFive *= 1.3f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 20 && GameManager.boostFive <= GameManager.boostFive * 30)
        {
            buyMaxFive *= GameManager.boostFive *= 1.4f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 30 && GameManager.boostFive <= GameManager.boostFive * 40)
        {
            buyMaxFive *= GameManager.boostFive *= 1.5f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 40 && GameManager.boostFive <= GameManager.boostFive * 50)
        {
            buyMaxFive *= GameManager.boostFive *= 1.6f;
        }
        if(GameManager.boostFive >= GameManager.boostFive * 50 && GameManager.boostFive <= GameManager.boostFive * 60)
        {
            buyMaxFive *= GameManager.boostFive *= 1.7f;
        } 
    } */
    
    private void Start()
    {
        upgradeBar = GameObject.FindGameObjectWithTag("UpgradeBar");
        GameManager.upBarBool = false;
        upgradeBar.SetActive(GameManager.upBarBool);
        var notEnoughEggs = GameObject.FindGameObjectWithTag("NotEnough");
        notEnoughEggs.GetComponent<Text>().enabled = false;
    }
        void ResetText()
    {
        var notEnoughEggs = GameObject.FindGameObjectWithTag("NotEnough");
        notEnoughEggs.GetComponent<Text>().enabled = false;
    }
    

    public void BuyUpgrade()
    {
       int rangeExpOne = (int)GameManager.countBoostOne % 20;
       
            if(rangeExpOne == 0)
            {
                GameManager.multiplier += 0.1f;
            } 
    }



// Simplificateur de valeur ------------------------------------------


    string SimplifiedValue(double value)
    {
        if(value < 1000)
        {
            // en dessous de 1000, on affiche la valeur originale
            return value.ToString("f0");
        }
        else if(value < 1000000)
        {
            // en dessous de 1 million, on affiche les milliers (K -> Kilo)
            return (value / 1000).ToString("f2")+"K";
        }
        else if(value < 1000000000)
        {
            // en dessous du milliard, on affiche les millions (M -> Mega)
            return (value / 1000000).ToString("f2") + "M";
        }
        else
        {
            // sinon, on affiche les milliards (G -> Giga)
            return (value / 1000000000).ToString("f2") + "G";
        }
    }
    string SimplifiedValueEPS(double value)
    {
        if(value < 0.1)
        {
            //En dessous de 0.1, n'affiche aucune lettre
            return value.ToString("f0");
        }
        if(value < 1000)
        {
            // en dessous de 1000, on affiche la valeur originale
            return value.ToString("f1");
        }
        else if(value < 1000000)
        {
            // en dessous de 1 million, on affiche les milliers (K -> Kilo)
            return (value / 1000).ToString("f1")+"K";
        }
        else if(value < 1000000000)
        {
            // en dessous du milliard, on affiche les millions (M -> Mega)
            return (value / 1000000).ToString("f1") + "M";
        }
        else
        {
            // sinon, on affiche les milliards (G -> Giga)
            return (value / 1000000000).ToString("f1") + "G";
        }
    }
    string SimplifiedValueEPC(double value)
    {
        if(value <= 1)
        {
            //En dessous de 1, n'affiche aucune lettre
            return value.ToString("f0");
        }
        if(value < 1000)
        {
            // en dessous de 1000, on affiche la valeur originale
            return value.ToString("f1");
        }
        else if(value < 1000000)
        {
            // en dessous de 1 million, on affiche les milliers (K -> Kilo)
            return (value / 1000).ToString("f1")+"K";
        }
        else if(value < 1000000000)
        {
            // en dessous du milliard, on affiche les millions (M -> Mega)
            return (value / 1000000).ToString("f1") + "M";
        }
        else
        {
            // sinon, on affiche les milliards (G -> Giga)
            return (value / 1000000000).ToString("f1") + "G";
        }
    }
    
    public void NotEnough()
    {
        Invoke("ResetText", 1);
    }
    // Bouton d'achat ------------------------------------------------
   /* public void BuyMaxOne(int maxbuy)
    {
        float eggsF = GameManager.eggs;
        int eggsInt = (int) eggsF;
        
        //Boost Max 1
        
        int priceMaxToBuyOne;
        int buyMaxOne;
        float boostOneF = GameManager.costBoostOne;
        int boostOneInt = (int) boostOneF;
        UpgradeEPSOneMax();
        
      /*  //Boost Max 2 

        int maxToBuyTwo;
        int buyMaxTwo;
        float boostTwoF = GameManager.boostTwo;
        int boostTwoInt = (int) boostTwoF;

        //Boost Max 3 

        int maxToBuyThree;
        int buyMaxThree;
        float boostThreeF = GameManager.boostThree;
        int boostThreeInt = (int) boostThreeF;

        //Boost Max 4

        int maxToBuyFour;
        int buyMaxFour;
        float boostFourF = GameManager.boostFour;
        int boostFourInt = (int) boostFourF;

        //Boost Max 5 

        int maxToBuyFive;
        int buyMaxFive;
        float boostFiveF = GameManager.boostFive;
        int boostFiveInt = (int) boostFiveF; 

        buyMaxOne = eggsInt / boostOneInt;
        priceMaxToBuyOne = (boostOneInt * buyMaxOne);
        Debug.Log(buyMaxOne.ToString() + " BuyMaxOne");
        Debug.Log(priceMaxToBuyOne.ToString() + "PriceMaxToBuyOne");
        Debug.Log(GameManager.eggs.ToString() + " oeuf");
        Debug.Log(boostOneInt.ToString() + " Prix du boost");
       
        if (maxbuy == 1 && GameManager.eggs >= priceMaxToBuyOne && priceMaxToBuyOne >= 1)
        {
            if(GameManager.boostOne == 0)
            {
                // Mettre le bouton en SetActive(False)
            }
            GameManager.idleIncrement += (0.1f * buyMaxOne);
            GameManager.countBoostOne += (1f * buyMaxOne);
            GameManager.countIdleOne += (0.1f * buyMaxOne);
            GameManager.eggs -= (GameManager.costBoostOne * buyMaxOne);
            UpgradeEPSOneMax();
        }
/*
        buyMaxTwo = eggsInt / boostTwoInt;
        maxToBuyTwo = (boostTwoInt * buyMaxTwo / 10);

        if(maxbuy == 2 && GameManager.eggs >= maxToBuyTwo)
        {
            if(GameManager.boostTwo == 0)
            {
                // Mettre le bouton en SetActive(False)
            }
            GameManager.idleIncrement += (0.1f * buyMaxTwo);
            GameManager.countBoostTwo += buyMaxTwo;
            GameManager.countIdleTwo += (0.1f * buyMaxTwo);
            GameManager.eggs -= (GameManager.boostTwo * buyMaxTwo);
            UpgradeEPSTwoMax();
        }

        buyMaxThree = eggsInt / boostThreeInt;
        maxToBuyThree = (boostThreeInt * buyMaxThree / 10);

        if(maxbuy == 3 && GameManager.eggs >= maxToBuyThree)
        {
            if(GameManager.boostThree == 0)
            {
                // Mettre le bouton en SetActive(False)
            }
            GameManager.idleIncrement += (0.1f * buyMaxThree);
            GameManager.countBoostThree += buyMaxThree;
            GameManager.countIdleThree += (0.1f * buyMaxThree);
            GameManager.eggs -= (GameManager.boostThree * buyMaxThree);
            UpgradeEPSThreeMax();
        }

        buyMaxFour = eggsInt / boostFourInt;
        maxToBuyFour = (boostFourInt * buyMaxFour / 10);

        if(maxbuy == 4 && GameManager.eggs >= maxToBuyFour)
        {
            if(GameManager.boostFour == 0)
            {
                // Mettre le bouton en SetActive(False)
            }
            GameManager.idleIncrement += (0.1f * buyMaxFour);
            GameManager.countBoostFour += buyMaxFour;
            GameManager.countIdleFour += (0.1f * buyMaxFour);
            GameManager.eggs -= (GameManager.boostFour * buyMaxFour);
            UpgradeEPSFourMax();
        }

        buyMaxFive = eggsInt / boostFiveInt;
        maxToBuyFive = (boostFiveInt * buyMaxFive / 10);

        if(maxbuy == 5 && GameManager.eggs >= maxToBuyFive)
        {
            if(GameManager.boostFive == 0)
            {
                // Mettre le bouton en SetActive(False)
            }
            GameManager.idleIncrement += (0.1f * buyMaxFive);
            GameManager.countBoostFive += buyMaxFive;
            GameManager.countIdleFive += (0.1f * buyMaxFive);
            GameManager.eggs -= (GameManager.boostFive * buyMaxFive);
            UpgradeEPSFiveMax();
        }
        
    }*/
public void Buy(int power)
    

    {
        if(power == 1 && GameManager.eggs >= GameManager.costBoostOne)
        {
            GameManager.idleIncrement += 0.1f;
            GameManager.countBoostOne += 1f;
            GameManager.countIdleOne += 0.1f;
            GameManager.eggs -= GameManager.costBoostOne;
            GameManager.costBoostOne *= 1.07f;
            
            // Lance les améliorations 
            
            int rangeExp = (int)GameManager.countBoostOne % 20;
            if(rangeExp == 0)
            {
                GameManager.upBarBool = true;
            }
            
        }

        if(power == 2 && GameManager.eggs >= GameManager.boostTwo)
        {
            GameManager.idleIncrement += 2.0f;
            GameManager.countBoostTwo += 1f;
            GameManager.countIdleTwo += 2f;
            GameManager.eggs -= GameManager.boostTwo;
            GameManager.boostTwo *= 1.07f;
        }
        
        if(power == 3 && GameManager.eggs >= GameManager.boostThree)
        {
            GameManager.idleIncrement += 10.0f;
            GameManager.countBoostThree += 1f;
            GameManager.countIdleThree += 10f;
            GameManager.eggs -= GameManager.boostThree;
            GameManager.boostThree *= 1.07f;
        }
       
        if(power == 4 && GameManager.eggs >= GameManager.boostFour)
        {
            GameManager.idleIncrement += 50.0f;
            GameManager.countBoostFour += 1f;
            GameManager.countIdleFour += 50f;
            GameManager.eggs -= GameManager.boostFour;
            GameManager.boostFour *= 1.07f;
        }
        
        if(power == 5 && GameManager.eggs >= GameManager.boostFive)
        {
            GameManager.idleIncrement += 250.0f;
            GameManager.countBoostFive += 1f;
            GameManager.countIdleFive += 250f;
            GameManager.eggs -= GameManager.boostFive;
            GameManager.boostFive *= 1.07f;
        }

        else
        {
            Invoke("ResetText", 1);
        }
        
    }  

    // ---------------------------- LES SORTIES DE TEXTE (APPARAIT A L'ECRAN) --------------------------------------------
void Update()
    {
           
        // Texte Boost EPS 1
        costBoostOne.text = "Cost : " + SimplifiedValue(GameManager.costBoostOne) + " Eggs";
        countBoostOne.text = "x " + SimplifiedValue(GameManager.countBoostOne);
        countIdleOne.text = "Add + 0.1 ePc / Total : " + SimplifiedValueEPS(GameManager.countIdleOne) + " ePc";
       
       // Texte Boost EPS 2
        boostTwo.text = "Cost : " + SimplifiedValue(GameManager.boostTwo) + " Eggs";
        countBoostTwo.text = "x " + GameManager.countBoostTwo;
        countIdleTwo.text = "Add + 2 ePc / Total : " + SimplifiedValue(GameManager.countIdleTwo) + " ePc";
        
        // Texte Boost EPS 3
        boostThree.text = "Cost : " + SimplifiedValue(GameManager.boostThree) + " Eggs";
        countBoostThree.text = "x " + GameManager.countBoostThree;
        countIdleThree.text = "Add + 10 ePc / Total : " + SimplifiedValue(GameManager.countIdleThree) + " ePc";
       
       // Texte Boost EPS 4
        boostFour.text = "Cost : " + SimplifiedValue(GameManager.boostFour) + " Eggs";
        countBoostFour.text = "x " + GameManager.countBoostFour;
        countIdleFour.text = "Add + 50 ePc / Total : " + SimplifiedValue(GameManager.countIdleFour) + " ePc";

        // Texte Boost EPS 5
        boostFive.text = "Cost : " + SimplifiedValue(GameManager.boostFive) + " Eggs";
        countBoostFive.text = "x " + SimplifiedValue(GameManager.countBoostFive);
        countIdleFive.text = "Add + 250 ePc / Total : " + SimplifiedValue(GameManager.countIdleFive) + " ePc";

        // Texte Boost EPC 1
        countEPCone.text = SimplifiedValue(GameManager.upEPCone) + " eggs";
        
        // Texte Boost EPC 2
        countEPCtwo.text = SimplifiedValue(GameManager.upEPCtwo) + " eggs";
        
        // Texte Boost EPC 3
        countEPCthree.text = SimplifiedValue(GameManager.upEPCthree) + " eggs";
        
        // Texte Boost EPC 4
        countEPCfour.text = SimplifiedValue(GameManager.upEPCfour) + " eggs";
        
        // Texte Boost EPC 5
        countEPCfive.text = SimplifiedValue(GameManager.upEPCfive) + " eggs";


        eggsPerClick.text = "Per Click : " + SimplifiedValueEPC(GameManager.multiplier);
        eggsPerSeconds.text = "Per Seconds : " + SimplifiedValueEPS(GameManager.idleIncrement);
        eggs.text = "Eggs : " + SimplifiedValueEPS(GameManager.eggs);



        upgradeBar.SetActive(GameManager.upBarBool);
        
       
        
    
        
    }   
}

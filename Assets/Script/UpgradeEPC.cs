using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UpgradeEPC : MonoBehaviour
{
    
    

    // Start is called before the first frame update
   
   public void Start()
   {
       GameManager.upgradeEPCone = GameObject.FindWithTag("upEPCone");
      // GameManager.upEPCinterractoneBool 
       GameManager.upgradeEPCone.SetActive(true);
       
      
       GameManager.upgradeEPCtwo = GameObject.Find("UpgradeEPC2");
       GameManager.upEPCtwoBool = GameManager.upgradeEPCtwo.GetComponent<Button>();
       GameManager.upEPCtwoBool = false;

       GameManager.upgradeEPCthree = GameObject.Find("UpgradeEPC3");
       GameManager.upEPCthreeBool = GameManager.upgradeEPCthree.GetComponent<Button>().interactable;
       GameManager.upEPCthreeBool = false;

       GameManager.upgradeEPCfour = GameObject.Find("UpgradeEPC4");
       GameManager.upEPCfourBool = GameManager.upgradeEPCfour.GetComponent<Button>().interactable;
       GameManager.upEPCfourBool = false;

       GameManager.upgradeEPCfive = GameObject.Find("UpgradeEPC5");
       GameManager.upEPCfiveBool = GameManager.upgradeEPCfive.GetComponent<Button>().interactable;
       GameManager.upEPCfiveBool = false;
       
   }
    public void BuyUpgradeEPC(int upEPC)
    {
        
        int rangeExpOne = (int)GameManager.countBoostOne % 20;
        if(upEPC == 1 && GameManager.eggs >= GameManager.upEPCone)
        
            {
                    GameManager.multiplier += 0.1f;
                    GameManager.eggs -= GameManager.upEPCone;
                    GameManager.upEPCone *= 3f;
                    Debug.Log("Achetable");   
            }
                    

        if(upEPC == 2 && GameManager.eggs >= GameManager.upEPCtwo)
            
            {
                    GameManager.multiplier += 1f;
                    GameManager.eggs -= GameManager.upEPCtwo;
                    GameManager.upEPCtwo *= 3f;  
            }

        if(upEPC == 3 && GameManager.eggs >= GameManager.upEPCthree)
            
            {
                    GameManager.multiplier += 10f;
                    GameManager.eggs -= GameManager.upEPCthree;
                    GameManager.upEPCthree *= 3f;  
            } 

        if(upEPC == 4 && GameManager.eggs >= GameManager.upEPCfour)
            
            {
                    GameManager.multiplier += 100f;
                    GameManager.eggs -= GameManager.upEPCfour;
                    GameManager.upEPCfour *= 3f;  
            } 
        
        if(upEPC == 5 && GameManager.eggs >= GameManager.upEPCfive)
            
            {
                    GameManager.multiplier += 1000f;
                    GameManager.eggs -= GameManager.upEPCfive;
                    GameManager.upEPCfive *= 3f;  
            }  
    }

    private void Update() 
    {
        // Am??lioration EPC 1 ----- D??bloqu?? apr??s 20 achat de l'am??lio EPS 1

        int rangeExpOne = (int)GameManager.countBoostOne % 20;
        if(GameManager.eggs >= GameManager.upEPCone && rangeExpOne == 0)
        {
            GameManager.upEPCinterractoneBool = true; 
            Debug.Log("Achetable");
        }
        else
        {
            GameManager.upEPCinterractoneBool = true;
            Debug.Log("Pas Achetable");
        }
        
        // Am??lioration EPC 2 ----- D??bloqu?? apr??s 20 achat de l'am??lio EPS 2

        int rangeExpTwo = (int)GameManager.countBoostTwo % 20;

         GameManager.upgradeEPCtwo.SetActive(false);
        if(GameManager.countBoostTwo >= 20 && rangeExpTwo == 0) 
        {
            GameManager.upgradeEPCtwo.SetActive(true);
            if(GameManager.eggs >= GameManager.upEPCtwo)
                {
                    GameManager.upEPCtwoBool = true;
                }
        
        }

        // Am??lioration EPC 3 ----- D??bloqu?? apr??s 20 achat de l'am??lio EPS 3

        int rangeExpThree = (int)GameManager.countBoostThree % 20;
        GameManager.upgradeEPCthree.SetActive(false);

        if(GameManager.countBoostTwo >= 20 && rangeExpThree == 0)
        {
            GameManager.upgradeEPCthree.SetActive(true);
            if(GameManager.eggs >= GameManager.upEPCthree)
                {
                    GameManager.upEPCthreeBool = true;
                }
        
        }
        
        // Am??lioration EPC 4 ----- D??bloqu?? apr??s 20 achat de l'am??lio EPS 4

        int rangeExpFour = (int)GameManager.countBoostFour % 20;
        GameManager.upgradeEPCfour.SetActive(false);

        if(GameManager.countBoostThree >= 20 && rangeExpThree ==0)
        {
            GameManager.upgradeEPCfour.SetActive(true);
            if(GameManager.eggs >= GameManager.upEPCfour)
                {
                    GameManager.upEPCfourBool = true;
                }
        
        }

        // Am??lioration EPC 5 ----- D??bloqu?? apr??s 20 achat de l'am??lio EPS 5

        int rangeExpFive = (int)GameManager.countBoostFive % 20;
        GameManager.upgradeEPCfive.SetActive(false);

        if(GameManager.countBoostFive >= 20 && rangeExpFive == 0)
        {
            GameManager.upgradeEPCfour.SetActive(true);
            if(GameManager.eggs >= GameManager.upEPCfour)
                {
                    GameManager.upEPCfiveBool = true;
                }
        
        }
    }
}

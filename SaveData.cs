using System.IO;
using UnityEngine;

public class SaveData : MonoBehaviour
{
    private string saveSeparator = "%VALUE%";
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.S))
        {
            Save();
        }

        if(Input.GetKeyDown(KeyCode.C))
        {
           Load();
        }
    }

    void Save()
    {
        string[] content = new string[]
        {
            GameManager.eggs.ToString(),
            GameManager.idleIncrement.ToString(),
            GameManager.multiplier.ToString(),
            GameManager.costBoostOne.ToString(),
            GameManager.countBoostOne.ToString(),
            GameManager.countIdleOne.ToString(),
            GameManager.boostTwo.ToString(),
            GameManager.countBoostTwo.ToString(),
            GameManager.countIdleTwo.ToString(),
            GameManager.boostThree.ToString(),
            GameManager.countBoostThree.ToString(),
            GameManager.countIdleThree.ToString(),
            GameManager.boostFour.ToString(),
            GameManager.countBoostFour.ToString(),
            GameManager.countIdleFour.ToString(),
            GameManager.boostFive.ToString(),
            GameManager.countBoostFive.ToString(),
            GameManager.countIdleFive.ToString(),
            GameManager.upBarBool.ToString(),
            GameManager.upEPCinterractoneBool.ToString(),
            GameManager.upEPCtwoBool.ToString(),
            GameManager.upEPCthreeBool.ToString(),
            GameManager.upEPCfourBool.ToString(),
            

        };

        string saveString = string.Join(saveSeparator, content);
        File.WriteAllText(Application.dataPath + "/data.txt", saveString);
        Debug.Log("Sauvegarde OK");

    }
    
    void Load()
    {
        string saveString = File.ReadAllText(Application.dataPath + "/data.txt"); 
        
        string[] content = saveString.Split(new[] { saveSeparator }, System.StringSplitOptions.None);

        GameManager.eggs = float.Parse(content[0]);
        GameManager.idleIncrement = float.Parse(content[1]);
        GameManager.multiplier = float.Parse(content[2]);
        GameManager.costBoostOne = float.Parse(content[3]);
        GameManager.countBoostOne = float.Parse(content[4]);
        GameManager.countIdleOne = float.Parse(content[5]);
        GameManager.boostTwo = float.Parse(content[6]);
        GameManager.countBoostTwo = float.Parse(content[7]);
        GameManager.countIdleTwo = float.Parse(content[8]);
        GameManager.boostThree = float.Parse(content[9]);
        GameManager.countBoostThree = float.Parse(content[10]);
        GameManager.countIdleThree = float.Parse(content[11]);
        GameManager.boostFour = float.Parse(content[12]);
        GameManager.countBoostFour = float.Parse(content[13]);
        GameManager.countIdleFour = float.Parse(content[14]);
        GameManager.boostFive = float.Parse(content[15]);
        GameManager.countBoostFive = float.Parse(content[16]);
        GameManager.countIdleFive = float.Parse(content[17]);
        GameManager.upBarBool = bool.Parse(content[18]);
        GameManager.upEPCinterractoneBool = bool.Parse(content[19]);
        GameManager.upEPCtwoBool = bool.Parse(content[20]);
        GameManager.upEPCthreeBool = bool.Parse(content[21]);
        GameManager.upEPCfourBool = bool.Parse(content[22]);
        

        Debug.Log("Ficher Chargé");
        

    }    
}

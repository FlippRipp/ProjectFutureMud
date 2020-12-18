using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class JsonTest : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        WeaponTest weaponTest = new WeaponTest("lol", 10);
        string[] dialog = new [] {"1", "2", "3", "4", "5"};
        float[] weights = new [] {1f, 2f, 3f, 4f, 5f};
        
        RandomDialogAdvanced rand = new RandomDialogAdvanced(dialog, weights);
        string json = JsonUtility.ToJson(rand);
        
        Debug.Log(json);
        //File.WriteAllText(Application.dataPath + "/weapondata.json", json);
        
        
    }
    
    public class WeaponTest
    {
        public string name;
        public float damage;

        public WeaponTest(string name, float damage)
        {
            this.name = name;
            this.damage = damage;
        }
    }
}

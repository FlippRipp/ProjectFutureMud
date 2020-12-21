using System.Collections;
using System.Collections.Generic;
using FutureMud.Actor;
using UnityEngine;

public class CombatManager : MonoBehaviour
{
    public static CombatManager instance;
    private Actor[] playerTeam;
    private Actor[] enemyTeam;
    
    

    private void Awake()
    {
        if (!instance)
        {
            instance = this;
        }
        else
        {
            Destroy(this);
        }
    }

    public void InitCombat(Actor[] playerTeam, Actor[] enemyTeam)
    {
        this.playerTeam = playerTeam;
        this.enemyTeam = enemyTeam;
        
        
    }

    private void RollTurnOrder()
    {
        
    }
    
    

    public void EndCombat()
    {
        
    }
}
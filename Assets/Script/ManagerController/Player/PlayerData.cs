using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerData : Player
{

    private void Start() {

        // Charaters  
        Level = 1;
        Gold = 1000;
        Diamind = 100;
        Health = 500f;
        Defense = 50f;
        Attack = 50f;
        
        UpdateData();
    }

    private void UpdateData() {

        // Updates Charaters a new level
        Health += (Level - 1) * 100f;
        Defense += (Level - 1) * 50f;
        Attack += (Level - 1) * 30f;
        
        Debug.Log("Level" + Level);
        Debug.Log("Gold" + Gold);
        Debug.Log("Diamind" + Diamind);
        Debug.Log("Health" + Health);
        Debug.Log("Defense" + Defense);
        Debug.Log("Attack" + Attack);

    }

    public void LevelUp() {
        
        // Charaters level Up
        Level++;
        UpdateData();
    }

    public void GoldMob(int amonut) {

        Gold += amonut;

        Debug.Log("Gold" + amonut + Gold);

        UpdateData();

    }

    public void TakeDamage(int damage) {
        Health -= damage;
        if (Health <= 0) {
            Die();
            
        }
         Debug.Log("Took " + damage + " damage. Remaining health: " + Health);
      
      UpdateData();
    }

    private void Die() {
    //     Player.PlayerDie;
    }
}


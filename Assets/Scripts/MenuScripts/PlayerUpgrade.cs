using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting.Antlr3.Runtime.Misc;
using UnityEngine;

public class PlayerUpgrade : MonoBehaviour
{
    public Player player;
    public TextMeshProUGUI statsText;

    private void Update()
    {
        statsText.text = "Health: " + player.health + "\nDamage: " + player.damage +
            "\nSpeed: " + player.speed + "\nAttack Rate: " + player.attackRate;
    }
    public void HealthUpgrade()
    {
        if(player.availablePoints > 0)
        {
            player.health += 10;
            player.availablePoints -= 1;
        }
        
    }

    public void DamageUpgrade()
    {
        if (player.availablePoints > 0)
        {
            player.damage += 5;
            player.availablePoints -= 1;
        }
        
    }
    public void SpeedUpgrade()
    {
        
        if (player.availablePoints > 0)
        {
            player.speed += 1;
            player.availablePoints -= 1;
        }
    }
    public void AttackRateUpgrade()
    {
        
        if (player.availablePoints > 0)
        {
            player.attackRate += 1;
            player.availablePoints -= 1;
        }
    }
}

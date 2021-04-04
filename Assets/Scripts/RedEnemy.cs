using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedEnemy : MonoBehaviour
{
    
    public string myName;
    public int attack;
    public int health;
    public int pierce;
    private int healthTemp;
    
    public RedPayer player;
    public SpriteRenderer SpriteRenderer;
    public TextMesh textMeshName;
    public TextMesh textMeshHp;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }

    private void StartGame()
    {
        print(message: "Hello I'm Enemy");
        textMeshName.text = "My name is " + myName;  
        healthTemp  = health; 
        textMeshHp.text = "Health = " + healthTemp; 
        
    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            player.GetDamage(attack);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }

    public void GetDamage(int damageValue)
    {
        if (damageValue < 0)
        {
            damageValue = 0;
        }
        healthTemp -= damageValue;
        print(message: "The player attacked the enemy");
        print(message: $"Enemy health = {healthTemp}");
        print(message: $"Damage dealt = {damageValue}");
        textMeshHp.text = "Health = " + healthTemp;
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RedPayer : MonoBehaviour
{

    public string myName;
    public int attack;
    public int health;
    public int defense;
    private int healthTemp;
    
    public RedEnemy enemy;
    public SpriteRenderer SpriteRenderer;
    public TextMesh textMeshName;
    public TextMesh textMeshHp;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
        healthTemp= health;
    }
    
    private void StartGame()
    {
        print(message: "Hello I'm Player");
        textMeshName.text = "My name is " + myName;  
        healthTemp  = health; 
        textMeshHp.text = "Health = " + healthTemp; 
        
    }
        

    // Update is called once per frame
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            enemy.GetDamage(attack);
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            StartGame();
        }
    }
    public void GetDamage(int damageValue)
    {
        damageValue = (enemy.attack + enemy.pierce) - defense;
        if (damageValue < 0)
        {
            damageValue = 0;
        }
        healthTemp -= damageValue;
        print(message: "The enemy attacked the player");
        print(message: $"Player health = {healthTemp}");
        print(message: $"Damage dealt = {damageValue}");
        textMeshHp.text = "Health = " + healthTemp;
        
    }
}

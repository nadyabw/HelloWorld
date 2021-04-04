using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenEnemy : MonoBehaviour
{
    
    public string myName;
    public int attack;
    public int health;
    public int pierce;
    private int healthTemp;

   
    public GreenPlayer player;
    public SpriteRenderer SpriteRenderer;
    public TextMesh textMeshName;
    public TextMesh textMeshHp;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    public void startNewGame()
    {
        textMeshHp.text = "Новая игра"; 
    }

    private void StartGame()
    {
        print(message: "Hello I'm Enemy");
        textMeshName.text = "My name is " + myName;  
        healthTemp  = health; 
        textMeshHp.text = "Health = " + healthTemp; 
        
    }

    public void printHealth()
    {
        textMeshHp.text = "Health = " + healthTemp; 
    }
    
    public int updateHealth(int damageValue)
    {
        healthTemp -= damageValue;
        if(healthTemp < 0)
        {
            healthTemp = 0;
        }

        printHealth();
        return healthTemp;
    }

    // Update is called once per frame
    void Update()
    {
     
    }

  
}
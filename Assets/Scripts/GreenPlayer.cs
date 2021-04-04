using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GreenPlayer  : MonoBehaviour
{

    public string myName;
    public int attack;
    public int health;
    public int defense;
    private int healthTemp;
    
   
    public SpriteRenderer SpriteRenderer;
    public TextMesh textMeshName;
    public TextMesh textMeshHp;
    
    
    private bool isGameFinished;
    
    // Start is called before the first frame update
    void Start()
    {
        StartGame();
    }
    
    private void StartGame()
    {
        print(message: "Hello I'm Player");
        isGameFinished = false;
        textMeshName.text = "My mane is " + myName;  
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
    private void Update()
    {
        

    }
    
   
}
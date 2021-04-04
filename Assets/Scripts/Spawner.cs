using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GreenEnemy[] enemy;
    private GreenEnemy currentEnemy;
    private GreenPlayer currentPlayer;
    public GreenPlayer player;
    private int currentEnemyIndex;
    public int attackE;
    public int healthE;
    public int pierceE;
    public int attackP;
    public int healthP;
    private bool isGameFinished;

    
    // Start is called before the first frame update
    void Start()
    {
        instantiateEnemy();
        attackE = enemy[currentEnemyIndex].attack;
        healthE = enemy[currentEnemyIndex].health;
        pierceE = enemy[currentEnemyIndex].pierce;
        attackP = player.attack;
        healthP = player.health;
    }
    void CheckKey()
   {
        if (!isGameFinished)
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                Attack(attackP);
            }
            else if (Input.GetKeyDown(KeyCode.L))
            {
                GetDamage(attackE);
            }
            if (Input.GetKeyDown(KeyCode.Space))
            {
                RastartGame();
            }
        } 
   }
    public void GetDamage(int damageValue)
    {
        print(message: $"Меня атаковали"); 
        damageValue = ( attackE + pierceE) - player.defense;
        healthP =- damageValue;
        print(message: "Враг " + enemy[currentEnemyIndex].myName + " атакует игрока");
        print(message: $"Player health = {healthP}");
        print(message: $"Damage dealt = {damageValue}");
        int healthLeft = currentPlayer.updateHealth(damageValue);
        if (healthLeft == 0)
        {
            print("Игрок умер.");
        }
    }
    public void Attack(int damageValue)
    {
        print(message: "Я аттакую");
        healthE -= damageValue;

        print(message: "Игрок атакует врага " + enemy[currentEnemyIndex].myName);
        print(message: $"{enemy[currentEnemyIndex].myName} health = {healthE}");
        print(message: $"Damage dealt = {damageValue}");
        int healthLeft = currentEnemy.updateHealth(damageValue);
        if (healthLeft == 0)
        {
            print("Враг умер.");
            nextEnemy();
        }
    }
    private void nextEnemy()
    {
        currentEnemyIndex++;
        Destroy(currentEnemy.gameObject);
        
        if (currentEnemyIndex < enemy.Length)
        {
            instantiateEnemy();
        }
        else
        {
            print("Победа!");

            isGameFinished = true;
        }
    }
    void  RastartGame()
   {
       startNewGame();
   }
   void startNewGame()
   {
       isGameFinished = false;
       for (int i = 0; i < enemy.Length; i++)
       {
           enemy[i].startNewGame();
           print(message:$"i=" +i);
           currentEnemyIndex = i;
       }
      
   }
   void instantiateEnemy()
   {
       currentEnemy = Instantiate(enemy[currentEnemyIndex]);
       attackE = enemy[currentEnemyIndex].attack;
       healthE = enemy[currentEnemyIndex].health;
       pierceE = enemy[currentEnemyIndex].pierce;
    }
   
    // Update is called once per frame
    void Update()
    { 
        CheckKey();
    }
}

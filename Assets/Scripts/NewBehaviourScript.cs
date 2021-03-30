using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NewBehaviourScript : MonoBehaviour
{
	  private int result, turnsNumber, gameOverValue = 50;
      public Text text, textEnd, textStart;
      
    // Start is called before the first frame update
    void Start()
    {
        result = 0;
        turnsNumber = 0;
        print("Введите число от 0 до 9.");
        textStart.text = "Введите число от 0 до 9.";

    }

    // Update is called once per frame
    void Update()
    {
        CheckPressedKeys();
    }

  

  

    private void ShowGameOverMessage() 
    {
        print("Игра окончена. Результат - " + result + ". Количество ходов - " + turnsNumber + ".");
        textEnd.text = "Игра окончена. Результат - " + result + ". Количество ходов - " + turnsNumber + ".";
    }

    private void CheckPressedKeys()
    {
        int keyValue = 0;

        if (Input.GetKeyDown (KeyCode.Keypad1) || Input.GetKeyDown (KeyCode.Alpha1))
        {
            keyValue = 1;
            result = keyValue + result;
        }
        
        if (Input.GetKeyDown (KeyCode.Keypad2) || Input.GetKeyDown (KeyCode.Alpha2))
        {
            keyValue = 2;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad3) || Input.GetKeyDown (KeyCode.Alpha3))
        {
            keyValue = 3;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad4) || Input.GetKeyDown (KeyCode.Alpha4))
        {
            keyValue = 4; 
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad5) || Input.GetKeyDown (KeyCode.Alpha5))
        {
            keyValue = 5;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad6) || Input.GetKeyDown (KeyCode.Alpha6))
        {
            keyValue = 6;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad7) || Input.GetKeyDown (KeyCode.Alpha7))
        {
            keyValue = 7;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad8) || Input.GetKeyDown (KeyCode.Alpha8))
        {
            keyValue = 8;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Keypad9) || Input.GetKeyDown (KeyCode.Alpha9))
        {
            keyValue = 9;
            result = keyValue + result;
        }
        if (Input.GetKeyDown (KeyCode.Space))
        {
             result = 0;
             turnsNumber = 0;
             print("Введите число от 0 до 9.");
        }


        if (keyValue > 0)
        {
            turnsNumber++;
            CheckGameState();
        }
    }

    private void CheckGameState()
    {
        if (result >= gameOverValue)
        {
            ShowGameOverMessage();
           
        }
        else
        {
            print("Результат - " + result + ".");
            text.text = "Результат - " + result + ".";
            print("Введите число от 0 до 9.");
            textStart.text = "Введите число от 0 до 9.";
                       
            
        }
    }
}

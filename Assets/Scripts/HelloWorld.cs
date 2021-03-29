using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HelloWorld : MonoBehaviour
{
    public Text text, textEnd, textStart;
    private int min = 1;
    private int max = 1000;
    private int minTemp = 1;
    private int maxTemp = 1000;
    private int number;
    private int guess;
    
    // Start is called before the first frame update
    private void Start()
    
   
    {
        print( message: "Загадай число от " + min + " до " + max);
        textStart.text = "Загадай число от " + min + " до " + max;
        UpdateGuess();
    }

    // Update is called once per frame
   public void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            minTemp = guess;
            UpdateGuess();
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            maxTemp = guess;
            UpdateGuess();
        }
        
        if (Input.GetKeyDown(KeyCode.KeypadEnter) || Input.GetKeyDown(KeyCode.Return))
        {
            textEnd.text = "Конец Игры. Количество шагов =" + number;
        }
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            minTemp = min;
            maxTemp = max;
            UpdateGuess();

        }
        
    }
   
   private void UpdateGuess()
   {
       guess = (minTemp + maxTemp) / 2;
       text.text = "Твое число равно " + guess + "?";
       number = number + 1;
   }
}

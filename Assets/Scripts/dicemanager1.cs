using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class dicemanager1: MonoBehaviour
{
    public TextMeshProUGUI numberText;

    public void GenerateNumber()
    {
        int randomNumber = Random.Range(1, 7);
        numberText.text = "Zahl: " + randomNumber.ToString(); // Aktualisiere den Text mit der generierten Zahl





        if (randomNumber == 1)
        {
            numberText.text = "Weiss";
        }
        if (randomNumber == 2)
        {
            numberText.text = "Gelb";
        }
        if (randomNumber == 3)
        {
            numberText.text = "Rot";
        }
        if (randomNumber == 4)
        {
            numberText.text = "Blau";
        }
        if (randomNumber == 5)
        {
            numberText.text = "Schwarz";
        }
        if (randomNumber == 6)
        {
            numberText.text = "Klee";
        }

    }
}

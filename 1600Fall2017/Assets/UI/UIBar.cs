using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

    public Image bar;
    public Text coinNum;
    public int totalCoinValue;
    public int coinValue = 10;
    public GameObject gameOverUI;

    public float powerLevel = 0.1f;
    public float amountToAdd = 0.0f;

    public enum PowerUpType
    {
        PowerUp,
        PowerDown,
        CollectCoin
    }

    public PowerUpType powerUp;

    public float fillAmount { get; internal set; }

    void OnTriggerEnter () {
        switch (powerUp)
        {
            case PowerUpType.PowerUp:
                StartCoroutine(PowerUpBar());
            break;

            case PowerUpType.PowerDown:
                StartCoroutine(PowerDownBar());
            break;

            case PowerUpType.CollectCoin:
                //start the coroutine "CollectCoin"
                StartCoroutine(CollectCoin());
            break;
        }
	}
	IEnumerator CollectCoin ()
    {
        print("Coin Collected");
        totalCoinValue = int.Parse(coinNum.text);
        //coinNum.text = (totalCoinValue + coinValue).ToString();
        //coin ui with numbers
        //this function will add coin value to the coin UI
        //need while loop to add numbers to the ui
        //ui text is a string so we need to convert a number to a string
        int tempAmount = totalCoinValue + coinValue;
        while (totalCoinValue <= tempAmount)
        {
            coinNum.text = (totalCoinValue++).ToString();
            yield return new WaitForFixedUpdate();
        }
    }



    IEnumerator PowerUpBar ()
    {
        float tempAmount = bar.fillAmount + powerLevel;
        if (tempAmount > 1)
        {
            tempAmount = 1;
        }

        while (bar.fillAmount < tempAmount)
        {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(amountToAdd);
        }
    }
    IEnumerator PowerDownBar()
    {
        float tempAmount = bar.fillAmount - powerLevel;
        if(tempAmount < 0)
        {
            tempAmount = 0;
        }
        while (bar.fillAmount > tempAmount)
        {
            bar.fillAmount += amountToAdd;
            yield return new WaitForSeconds(amountToAdd);

            if(bar.fillAmount == 0)
            {
                gameOverUI.SetActive(true);
                characterControl.gameOver = true;
            }
        }
    }
}
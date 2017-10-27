using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIBar : MonoBehaviour {

    public Image bar;
    public GameObject gameOverUI;

    public float powerLevel = 0.1f;
    public float amountToAdd = 0.0f;

    public enum PowerUpType
    {
        PowerUp,
        PowerDown
    }

    public PowerUpType powerUp;

	void OnTriggerEnter () {
        switch (powerUp)
        {
            case PowerUpType.PowerUp:
                StartCoroutine(PowerUpBar());
            break;

            case PowerUpType.PowerDown:
                StartCoroutine(PowerDownBar());
                break;
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
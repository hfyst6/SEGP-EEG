using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsCollected : MonoBehaviour
{
    private int coinscollected;

    public int getCoinsCollected(){
        return this.coinscollected;
    }

    public void setCoinsCollected(int newCoins){
        coinscollected = newCoins;
    }
}

using System.Collections;
using System.Numerics;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ERC721BalanceOfExample : MonoBehaviour
{
    public Text txt;

    private async void Start()
    {
        string chain = "polygon";
        string network = "mainnet";
        string contract = "0x30748e684ebD20aee9E4c4dfA75C0dA6a9C623d1";
        string account = PlayerPrefs.GetString("Account");

        int balance = await ERC721.BalanceOf(chain, network, contract, account);
        print(balance);

        if (balance > 0)
        {
            txt.text = "NFT Detected";
        }
        else
        {
            txt.text = "Nothing Detected";
        }
    }
}
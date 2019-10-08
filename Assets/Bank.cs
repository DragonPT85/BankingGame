using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bank 
{
    private float cash;


    private float image;
    private float marketingSpending;

    private float profit;
    private float revenue;
    private float totalExpenditure;

// All Credit related: Spread, Amount and supply.
    private float spread;
    private float consumerSpread;
    private float consumerCredit;
    private float consumerCreditSupply;
    private float businessSpread;
    private float businessCredit;
    private float businessCreditSupply;
    private float mortageSpread;
    private float mortageCredit;
    private float mortageCreditSupply;


    public Bank(float cash, float image)
    {
        Cash = cash;
        Image = image;
        MarketingSpending = 0;
    }

    // Se calhar nao e preciso cash ser publico visto que é mudado dentro da class
    public float Cash { get => cash; set => cash = value; }
    public float Image { get => image; set => image = value; }
    public float MarketingSpending { get => marketingSpending; set => marketingSpending = value; }
    public float ConsumerCreditSupply { get => consumerCreditSupply; set => consumerCreditSupply = value; }
    public float BusinessCreditSupply { get => businessCreditSupply; set => businessCreditSupply = value; }
    public float MortageCreditSupply { get => mortageCreditSupply; set => mortageCreditSupply = value; }

    public float calcCash()
    {
        return 0;
    }
    public float calcRevenue()
    {
        return 0;
    }
    public float calcProfit(float taxes)
    {
        return 0;
    }
    public void calcTurn(float taxes)
    {
        calcRevenue();
        calcProfit(taxes);
        calcCash();

    }
}

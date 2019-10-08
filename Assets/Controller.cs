using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Controller : MonoBehaviour
{
    private float waitTime = 5.0f;
    [SerializeField] private float timer = 0f;
    // Start is called before the first frame update
    public TextMeshProUGUI creditDemand;
    private World world;

    
    void Start()
    {
        world = new World();
        float cd = world.playerBank.Cash;
        creditDemand.SetText(cd.ToString());
    }

    // Update is called once per frame
    void Update()
    {
        timer += Time.deltaTime;

        // Check if we have reached beyond 2 seconds.
        // Subtracting two is more accurate over time than resetting to zero.
        if (timer > waitTime)
        {
            world.playerBank.Cash += 100;
            creditDemand.SetText(world.playerBank.Cash.ToString());


            // Remove the recorded 2 seconds.
            timer = timer - waitTime;
        }
    }
}

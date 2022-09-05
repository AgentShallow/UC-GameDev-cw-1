using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class car : MonoBehaviour
{
    string heroName = "Rashed";
    int heroHeight = 5;
    int heroAge = 20;
    string heroSuperPower = "None";

    string villainName = "dehsaR";
    int villainHeight = 18;
    int villainAge = 20;
    string villainSuperPower = "None";

     
    // Start is called before the first frame update
    void Start()
    {
        float ageDifference = heroAge - villainAge;
        print( "hello my name is" + heroName + "and i am" + heroAge + "years old");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hp : MonoBehaviour {
    public InputField HealthPoint;
    private int hp;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (HealthPoint.text == "")
            hp = 0;
        else
            hp = System.Convert.ToInt32(HealthPoint.text);

    }
}

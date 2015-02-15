using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class GameMainCemera : MonoBehaviour {
    private ConfigScheduling cfgManager = ConfigScheduling.getInstance();
	// Use this for initialization
    void Start()
    {
        Hero h = cfgManager.getHero(2);

        Debug.Log("(" + h.cfgId + ")名称：" + h.Name);
        Debug.Log(" " + h.Content);
        Debug.Log(" " + h.Dialog);
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;

public class ConfigScheduling {
    private static ConfigScheduling cfg;
    private ConfigScheduling() { 
        //初始化
        initHero();
        initEquip();
        initHeroSkill();
        initItem();
    }

    public static ConfigScheduling getInstance()
    {
        if (cfg == null)
            cfg = new ConfigScheduling();
        return cfg;
    }

    private List<Hero> heroList;
    private void initHero()
    {
        if (heroList == null)
            heroList = new List<Hero>();

        List<Dictionary<string, string>> datas = ConfigReader.ReadConfigFile("Configs/GameHero");

        foreach (Dictionary<string, string> data in datas)
        {
            Hero hero = new Hero();
            hero.cfgId = Convert.ToInt32(data["cfgId"]);
            hero.Name = data["Name"];
            hero.Content = data["Content"];
            hero.Dialog = data["Dialog"];
            
            heroList.Add(hero);
        }
    }
    public Hero getHero(int cfgId)
    {
        Hero h = null;
        foreach (Hero hero in heroList)
        {
            if (hero.cfgId == cfgId)
            {
                h = hero;
                break;
            }
            else {
                h = null;
            }
        }
        return h;
    }

    
    private void initHeroSkill() { }
    private void initEquip() { }
    private void initItem() { }
}

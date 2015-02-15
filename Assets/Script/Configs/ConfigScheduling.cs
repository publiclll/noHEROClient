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

    private List<HeroInfo> heroList;
    private void initHero()
    {
        if (heroList == null)
            heroList = new List<HeroInfo>();

        List<Dictionary<string, string>> datas = ConfigReader.ReadConfigFile("Configs/GameHero");

        foreach (Dictionary<string, string> data in datas)
        {
            HeroInfo hero = new HeroInfo();
            hero.cfgId = Convert.ToInt32(data["cfgId"]);
            hero.Name = data["Name"];
            hero.Content = data["Content"];
            hero.Dialog = data["Dialog"];
            hero.resMaterials = data["resMaterials"];
            hero.resDataAsset = data["resDataAsset"];
            hero.resHeadPic = data["resHeadPic"];
            heroList.Add(hero);
        }
    }
    public HeroInfo getHero(int cfgId)
    {
        HeroInfo h = null;
        foreach (HeroInfo hero in heroList)
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

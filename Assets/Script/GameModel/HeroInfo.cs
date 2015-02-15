using UnityEngine;
using System.Collections;
using Assets.Script.GameModel;

/// <summary>
/// 英雄类，集成GameObjectBase
/// </summary>
public class HeroInfo : GameObjectBase{
    public HeroInfo() {
        heroAction = new HeroAction();
    }
    /// <summary>
    /// 种族
    /// </summary>
    public HeroRace race { get; set; }
    /// <summary>
    /// 兵种
    /// </summary>
    public HeroSoldiersAre soldiersAre { get; set; }
    /// <summary>
    /// 站位
    /// </summary>
    public HeroLocation location { get; set; }

    public HeroAction heroAction { get; set; }
}

/// <summary>
/// 英雄动作
/// </summary>
public class HeroAction {
    /// <summary>
    /// 被攻击
    /// </summary>
    public string beating;
    /// <summary>
    /// 待机
    /// </summary>
    public string standby;
    /// <summary>
    /// 攻击
    /// </summary>
    public string attacked;
    /// <summary>
    /// 技能1
    /// </summary>
    public string skill_1;
    /// <summary>
    /// 技能2
    /// </summary>
    public string skill_2;
    /// <summary>
    /// 技能3
    /// </summary>
    public static string skill_3;
    /// <summary>
    /// 奔跑
    /// </summary>
    public string run;
    /// <summary>
    /// 死亡
    /// </summary>
    public string death;
    /// <summary>
    /// 胜利
    /// </summary>
    public string win = "win";

}

/// <summary>
/// 英雄兵种
/// </summary>
public enum HeroSoldiersAre {
    INVALID,
    /**
     * 刀
     */
    knife,
    /**
     * 工
     */
    bow,
    /**
     * 法师
     */
    magic,
    /**
     * 斧
     */
    axe,
}
/// <summary>
/// 英雄站位
/// </summary>
public enum HeroLocation {
    INVALID,
    /**
     * 前排
     */
    front,
    /**
     * 中间
     */
    middle,
    /**
     * 后排
     */
    back,
}
/// <summary>
/// 英雄种族
/// </summary>
public enum HeroRace {
    INVALID,
    /**
     * 人类
     */
    human,
    /**
     * 亡灵
     */
    undead,
    /**
     * 野兽
     */
    beast,
    /**
     * 鱼人
     */
    fishmen, 
}
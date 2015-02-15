using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script.GameModel
{
    public class NumericalAttribute
    {
        /// <summary>
        /// 力量
        /// </summary>
        public double power { get; set; }
        /// <summary>
        /// 力量系数
        /// </summary>
        public double i_power { get; set; }
        /// <summary>
        /// 智力
        /// </summary>
        public double intelligence { get; set; }
        /// <summary>
        /// 智力系数
        /// </summary>
        public double i_intelligence { get; set; }
        /// <summary>
        /// 敏捷
        /// </summary>
        public double agile { get; set; }
        /// <summary>
        /// 敏捷系数
        /// </summary>
        public double i_agile { get; set; }
        /// <summary>
        /// 物理攻击
        /// </summary>
        public double p_attack { get; set; }
        /// <summary>
        /// 物理防御
        /// </summary>
        public double p_defense { get; set; }
        /// <summary>
        /// 魔法攻击
        /// </summary>
        public double m_attack { get; set; }
        /// <summary>
        /// 魔法防御
        /// </summary>
        public double m_defense { get; set; }
        /// <summary>
        /// 物理暴击
        /// </summary>
        public double p_crit { get; set; }
        /// <summary>
        /// HP恢复
        /// </summary>
        public double r_hp { get; set; }
        /// <summary>
        /// MP恢复
        /// </summary>
        public double r_mp { get; set; }
        /// <summary>
        /// 最大HP
        /// </summary>
        public double hp { get; set; }
    }
}

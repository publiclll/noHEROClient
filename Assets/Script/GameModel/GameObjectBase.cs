using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Assets.Script.GameModel
{
    /// <summary>
    /// 游戏对象基础类
    /// </summary>
    public class GameObjectBase
    {
        /// <summary>
        /// 名称
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 简介
        /// </summary>
        public string Content { get; set; }
        /// <summary>
        /// 配置ID
        /// </summary>
        public int cfgId { get; set; }
        /// <summary>
        /// 对话信息
        /// </summary>
        public string Dialog { get; set; }
        /// <summary>
        /// 头像资源
        /// </summary>
        public string resHeadPic { get; set; }
        /// <summary>
        /// 贴图资源
        /// </summary>
        public string resMaterials { get; set; }
        /// <summary>
        /// 动画数据
        /// </summary>
        public string resDataAsset { get; set; }

    }
}

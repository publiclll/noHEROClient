using UnityEngine;
using System.Collections;

public class TestSkeleton : MonoBehaviour {

    // 骨骼动画
    public SkeletonAnimation animation;
	// Use this for initialization

    void Awake() {
        HeroInfo hero = ConfigScheduling.getInstance().getHero(1);
        //设置材质
        animation.renderer.materials[0] = (Material)Resources.Load("Hero/" + hero.resMaterials);
        //设置动画数据
        animation.skeletonDataAsset = (SkeletonDataAsset)Resources.Load("Hero/" + hero.resDataAsset);
        //是否循环播放动画
        animation.loop = true;
        //设置动画名称
        animation.AnimationName = hero.heroAction.win;
        //重新运行动画
        animation.Reset();
    }

	void Start () {
        //Debug.Log();
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}
}

using UnityEngine;
using System.Collections;

public class TestSkeleton : MonoBehaviour {

    // 骨骼动画
    public SkeletonAnimation animation;
	// Use this for initialization

    void Awake() {
        //设置材质
        animation.renderer.materials[0] = (Material)Resources.Load("Hero/heishishangren/heishishangren-act_Material");
        //设置动画数据
        animation.skeletonDataAsset = (SkeletonDataAsset)Resources.Load("Hero/heishishangren/heishishangren_Data");
        //是否循环播放动画
        animation.loop = true;
        //设置动画名称
        animation.AnimationName = "animation";
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

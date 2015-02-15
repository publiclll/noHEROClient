using UnityEngine;
using System.Collections;

public class HeroControll : MonoBehaviour {
    public static int clickcount = 1;
    public SkeletonAnimation anim;
	// Use this for initialization
	void Start () {
        anim.AnimationName = "daiji";
        anim.Reset();
	}
	
	// Update is called once per frame
	void Update () {
	    
	}

    private void execAnimation(string AnimationName) {
        anim.AnimationName = AnimationName;
        anim.Reset();
    }

    public void OnButtonPlay()
    {
        Debug.Log("button is click");
        switch (clickcount)
        {
            case 1:
                execAnimation("daiji");
                break;
            case 2:
                execAnimation("beiji");
                break;
            case 3:
                execAnimation("gongji");
                break;
            case 4:
                execAnimation("jineng1");
                break;
            case 5:
                execAnimation("jineng2");
                break;
            case 6:
                execAnimation("jineng3");
                break;
            case 7:
                execAnimation("rush");
                break;
            case 8:
                execAnimation("siwang");
                break;
            case 9:
                execAnimation("win");
                break;
        }
        clickcount++;
        if (clickcount == 10)
            clickcount = 1;
    }
}

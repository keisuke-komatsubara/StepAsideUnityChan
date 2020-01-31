using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectController : MonoBehaviour {
    //カメラを入れる
    public GameObject MainCamObj;
    //ゴール地点
    private int goalPos = 120;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        //カメラを取得
        MainCamObj = Camera.main.gameObject;

        if (transform.position.z - MainCamObj.transform.position.z < 0)
        {
            Destroy(gameObject);
        }
        else if (transform.position.z > this.goalPos)
        {
            Destroy(gameObject);
        }

    }
}

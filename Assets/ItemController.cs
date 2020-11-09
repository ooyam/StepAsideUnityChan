using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemController : MonoBehaviour
{
    //メインカメラを入れる
    public GameObject mainCamObj;

    // Start is called before the first frame update
    void Start()
    {
        //メインカメラの取得
        mainCamObj = Camera.main.gameObject;
    }

    // Update is called once per frame
    void Update()
    {
        //メインカメラがオブジェクトを通過した場合
        if (mainCamObj.transform.position.z > this.transform.position.z)
        {
            //通過したオブジェクトを破棄
            Destroy(this.gameObject);
        }
    }
}

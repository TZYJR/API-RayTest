using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayTest : MonoBehaviour {

    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            Debug.Log("xxxxxxxxxxx");

            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);    //从摄像机发出到点击坐标的射线

            RaycastHit hit;

            if (Physics.Raycast(ray,out hit))
            {
                Debug.DrawLine(ray.origin, hit.point);      //划出射线，在scene视图中能看到由摄像机发射出的射线

                GameObject game = hit.collider.gameObject;  

                if (game.name.StartsWith("Cube") == true)     //当射线碰撞目标的name包含Cube，执行拾取操作
                {
                    Debug.Log(game.name);
                }
            }
        }
    }
}

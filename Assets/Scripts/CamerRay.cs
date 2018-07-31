using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamerRay : MonoBehaviour {


    /// <summary>
    /// 坐标系
    /// </summary>
    public Transform Cube;      //接口
    private Vector3 mous_global;        //鼠标的世界坐标
    public Vector3 Cube_screen;     //Cube的世界坐标
    float cubeScreen_z;         //Cube的屏幕坐标


    void Update()
    {
        Cube_screen = Camera.main.WorldToScreenPoint(Cube.position);        //将Cube的世界坐标转化为屏幕坐标
                                //世界 转 屏幕       Cube的位置
        cubeScreen_z = Cube_screen.z;       //将Cube的屏幕坐标的z轴储存起来
        Cube_screen = Input.mousePosition;      //将Cube的屏幕坐标换成鼠标的屏幕坐标
        Cube_screen.z = cubeScreen_z;       //将Cube的屏幕坐标中的z轴，转换为Cube之前储存的z轴
        Cube.position = Camera.main.ScreenToWorldPoint(Cube_screen);        //将转换后的Cube的屏幕坐标转换为世界坐标，并赋给Cube
    }
}

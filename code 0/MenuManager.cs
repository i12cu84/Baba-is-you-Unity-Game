using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
//Scenes场景 Menu菜单
public class MenuManager : MonoBehaviour
{
    //调用选择 打开相应名称的关卡
    public void Select(string levelName)
    {
        //加载相应关卡的场景
        SceneManager.LoadScene(levelName);
    }
}

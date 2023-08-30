using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//地图内容设计
//枚举
public enum ElementTypes
{
    //over 表示已经完成
    //carrier载具
    //空 over
    Empty = 0,
    //baba巴巴 over
    Baba,
    //wall墙 over
    Wall,
    //falg旗 over
    Flag,
    //box箱子 over
    Box,
    //key钥匙 over
    Key,
    //rock岩石 over
    Rock,
    //water水 over
    Water,
    //skull骷髅头 over
    Skull,
    //door门 over
    Door,
    //belt滑动梯子
    Belt,



    //special特殊
    //text载具赋词属性
    TextString,
    //empty空
    EmptyString,
    //group群组
    GroupString,
    //level关卡所有物体
    LevelString,
    //all所有载具
    AllString,
    /*
        //lava岩浆
        //grass草丛
        //jelly水母
        //star海星
        //crab螃蟹
        //love爱心
        //keke可可
        //algae水藻
        //pillar柱子
        //hedge树篱
        //rose玫瑰
        //violet紫罗兰
        //cog齿轮
        //robot机器人
        //pipe管子
        //bog沼泽
        //ice冰
        //tree树
        //fungus真菌
        //fence栅栏
        //bug昆虫
        //reed芦苇
        //cloud云朵
        //rocket
        //moon月亮
        //dust尘土
        //UFO外星飞船
        //hand手
        //fruit水果
        //cilff悬崖
        //bat蝙蝠
        //fire火
        //tile瓦片
        //bird鸟
        //sun太阳
        //rubble碎砖
        //orb球体
        //cursor进入关卡的光标
    */



    //载具名字
    //baba巴巴 over
    BabaString,
    //wall墙 over
    WallString,
    //falg旗 over
    FlagString,
    //box箱子 over
    BoxString,
    //key钥匙 over
    KeyString,
    //rock岩石 over
    RockString,
    //water水 over
    WaterString,
    //skull骷髅头 over
    SkullString,
    //door门 over
    DoorString,
    //belt滑动梯子 over
    BeltString,
    //feeling(?)
    FeelingString,
    //group2(?)
    Group2String,
    //group3(?)
    Group3String,
    //idle(?)
    IdleString,
    //mimic(?)
    MimicString,
    //often(?)
    OftenString,
    //powered(?)
    PoweredString,
    //seldom(?)
    SeldomString,
    //without(?)
    WithoutString,
    /*
        //lava岩浆
        //grass草丛
        //jelly水母
        //star海星
        //crab螃蟹
        //love爱心
        //keke可可
        //algae水藻
        //pillar柱子
        //hedge树篱
        //rose玫瑰
        //violet紫罗兰
        //cog齿轮
        //robot机器人
        //pipe管子
        //bog沼泽
        //ice冰
        //tree树
        //fungus真菌
        //fence栅栏
        //bug昆虫
        //reed芦苇
        //cloud云朵
        //rocket
        //moon月亮
        //dust尘土
        //UFO外星飞船
        //hand手
        //fruit水果
        //cilff悬崖
        //bat蝙蝠
        //fire火
        //tile瓦片
        //bird鸟
        //sun太阳
        //rubble碎砖
        //orb球体
        //cursor进入关卡的光标
    */



    //put赋词
    //is 是/能够 over
    Is,
    //以下 ---未完待续篇---
    //not 非 不是/不能
    Not, 
    //has 变/含 摧毁/变成
    Has, 
    //and 和 和/与
    And,
    //on 在...上方
    On,
    //make 出现/做成
    Make, 
    //facing前一格
    Facing, 
    //lonely只有
    Lonely,
    //near周围
    Near, 
    //fear上下左右
    Fear, 
    //follow 跟着(?)
    Follow, 
    //eat 吃(?)
    Eat,



    //属性
    //you 操控移动 over
    You,
    //win 游戏结束 over
    Win,
    //stop 禁止穿过 over
    Stop, 
    //push 推动 over
    Push,
    //sink 重叠摧毁 over
    Sink,
    //weak 被碰碎 over
    Weak,
    //defeat 失败 游戏结束 over
    Defeat,
    //hot 滚烫 over
    Hot,
    //melt 软化 over
    Melt,
    //tele 传送 over
    Tele,
    //float 漂浮 在空中 over
    Float,
    //open 开启 能开启shut over
    Open,
    //shut 被开启 能被open开启 over
    Shut,
    //move 移动 随player移动 over
    Move,
    //pull 拉走 over
    Pull,
    //shift 驱动 over
    Shift,
    //up 上 over
    Up,
    //right 右 over
    Right,
    //down 下 over
    Down,
    //left 左 over
    Left,
    //swap 互换 over
    Swap,
    //end 结束 over
    End,
    //fall 下落 over
    Fall,
    //more 更多 over
    More,
    //word 单词 over
    Word,
    //hide 隐藏 over
    Hide,
    //bonus 奖励 over
    Bonus,
    //done 消失 over
    Done,
    //以下 ---未完待续篇---
    //best (?)
    Best,
    //sad 哭(?)
    Sad, 
    //safe 保护(?)
    Safe,
    //sleep 睡(?)
    Sleep,
    //wonder 精彩(?)
    Wonder,
    //auto
    Auto,
    //blue
    Blue, 
    //broken
    Broken,
    //chill
    Chill,
    //falldown
    Falldown,
    //fallleft
    Fallleft, 
    //fallright
    Fallright, 
    //fallup
    Fallup, 
    //nudgedown
    Nudgedown,
    //nudgeleft
    Nudgeleft,
    //nudgeright
    Nudgeright,
    //nudgeup
    Nudgeup, 
    //party
    Party, 
    //pet
    Pet, 
    //phamtom
    Phamtom, 
    //pink
    Pink, 
    //power
    Power,
    //red
    Red, 
    //reverse
    Reverse, 
    //rosy
    Rosy,
    //still
    Still, 
    //turnleft
    Turnleft, 
    //turnright
    Turnright, 
    //you2
    You2
}

//关卡创造设定
[CreateAssetMenu()]
[System.Serializable]
public class LevelCreator : ScriptableObject
{
    [SerializeField]
    //关卡level中列表的枚举方式
    public List<ElementTypes> level = new List<ElementTypes>();
}

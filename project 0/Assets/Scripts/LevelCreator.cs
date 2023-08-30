using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ElementTypes
{
    Empty = 0,
    Baba,
    Wall,
    Flag,
    BabaString,
    WallString,
    Is,
    You,
    Stop,
    Win,
    FlagString,
    Push
}

// 맵 쉽게 만들기 위해 정보 저장용으로 만듬.
[CreateAssetMenu()][System.Serializable]
public class LevelCreator : ScriptableObject
{
    [SerializeField]
    public List<ElementTypes> level = new List<ElementTypes>();
}

using System.Collections.Generic;
using Assets.Scripts.Data;
using UnityEngine;

namespace Assets.Scripts.ScriptableObjects
{
    [CreateAssetMenu(fileName = "New Level Data", menuName = "LevelData")]
    public class LevelData : ScriptableObject
    {
        [SerializeField] public string LevelName;
        [SerializeField] public int NumberOfTaps;
        [SerializeField] public Sprite ClickImage;
        [SerializeField] public Sprite Background;
        [SerializeField][Range(0,5)] public int Difficulty;
        [SerializeField] public PlayerData[] Leaders;
    }
}

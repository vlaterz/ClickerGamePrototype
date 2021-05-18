using System.Collections.Generic;
using Assets.Scripts.ScriptableObjects;
using UnityEngine;

namespace Assets.Scripts
{
    public class LevelList : MonoBehaviour
    {
        private static LevelList _instance;
        public static LevelList Instance => _instance;
        void Awake() => _instance = this;

        public List<LevelData> Levels;
    }
}

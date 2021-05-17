using System.Collections.Generic;
using Assets.Scripts.Data;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class LeaderboardListView : MonoBehaviour
    {
        [SerializeField] private LeaderboardEntryView _entryRef;

        public void BuildLeaderboard(PlayerData[] datas)
        {
            foreach (var playerData in datas)
            {
                var newEntry = Instantiate(_entryRef, transform);
                newEntry.GetComponent<LeaderboardEntryView>().SetEntry(playerData.name, playerData.time.ToString());
            }
        }
    }
}

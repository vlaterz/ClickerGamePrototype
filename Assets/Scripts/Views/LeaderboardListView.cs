using System.Linq;
using Assets.Scripts.Data;
using UnityEngine;

namespace Assets.Scripts.Views
{
    public class LeaderboardListView : MonoBehaviour
    {
        [SerializeField] private LeaderboardEntryView _entryRef;

        public void RebuildLeaderboard(PlayerData[] datas)
        {
            foreach (Transform child in transform)
                Destroy(child.gameObject);

            foreach (var playerData in datas.OrderByDescending(a=>a.Time))
            {
                var newEntry = Instantiate(_entryRef, transform);
                newEntry.GetComponent<LeaderboardEntryView>().SetEntry(playerData.Name, playerData.Time.ToString());
            }
        }
    }
}

using System.Collections;
using Assets.Scripts.Data;
using Newtonsoft.Json;
using UnityEngine;
using UnityEngine.Networking;

namespace Assets.Scripts.Managers
{
    public class LeaderboardLoadManager : MonoBehaviour
    {
        [SerializeField] public string URL;

        private GameDATAFromURL _gameData;

        void Start()
        {
            StartCoroutine(RetrieveLeaderboards(URL));
        }

        private IEnumerator RetrieveLeaderboards(string uri)
        {
            using (UnityWebRequest request = UnityWebRequest.Get(uri))
            {
                yield return request.SendWebRequest();

                if (request.result != UnityWebRequest.Result.Success)
                {
                    Debug.Log("Error: " + request.error);
                    yield break;
                }
                _gameData = JsonConvert.DeserializeObject<GameDATAFromURL>(request.downloadHandler.text);
            }

            
            LevelList.Instance.Levels[0].Leaders = _gameData.Level1.Leaderboard;
            LevelList.Instance.Levels[1].Leaders = _gameData.Level2.Leaderboard;
        }
    }
}

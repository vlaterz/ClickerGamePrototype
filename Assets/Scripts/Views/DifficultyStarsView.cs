using UnityEngine;

namespace Assets.Scripts.Views
{
    public class DifficultyStarsView : MonoBehaviour
    {
        public void SetDifficulty(int difficultyLevel)
        {
            for (int i = 0; i < 5; i++)
            {
                var star = transform.GetChild(i).GetComponent<StarView>();
                star.SetStarActive(i < difficultyLevel);
            }
        }
    }
}

using UnityEngine;
using UnityGameFramework.Runtime;

namespace Flower
{
    /// <summary>
    /// 游戏入口。
    /// </summary>
    public partial class GameEntry : MonoBehaviour
    {
        public static DataComponent Data
        {
            get;
            private set;
        }

        public static ItemComponent Item
        {
            get;
            private set;
        }

        private static void InitCustomComponents()
        {
            Item = UnityGameFramework.Runtime.GameEntry.GetComponent<ItemComponent>();
            Data = UnityGameFramework.Runtime.GameEntry.GetComponent<DataComponent>();
        }

        public void Update()
        {
            if(Input.GetKeyDown(KeyCode.C))
            {
                GameEntry.Sound.PlayMusic(EnumSound.GameBGM);
            }
        }

    }
}

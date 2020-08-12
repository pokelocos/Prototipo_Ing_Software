using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DataBase
{
    public class InfoDataBase : MonoBehaviour
    {
        private InfoDataBase instance;

        public List<PieceInfo> piecesInfo = new List<PieceInfo>();
        public List<MuseumInfo> museumsInfo = new List<MuseumInfo>();
        public List<UserInfo> usersInfo = new List<UserInfo>();
        public List<TropyInfo> tropiesInfo = new List<TropyInfo>();
        public List<TutorialInfo> tutorialsInfo = new List<TutorialInfo>();

        public void Awake()
        {
            if (instance == null)
            {
                instance = this;
                DontDestroyOnLoad(this.gameObject );
            }
            else
            {
                Destroy(this.gameObject);
            }
        }

        /*
        public bool AddUser(UserInfo userInfo)
        {
            if(usersInfo)
            {

            }
        }
        */

    }
}

using System;

namespace Game.Data
{
    [Serializable]
    public class PlayerProgress
    {
        public PlayerData PlayerData;
        public PlayerProgress()
        {
            PlayerData = new PlayerData();
        }
    
    }


    [Serializable]
    public class PlayerData
    {
        public int Health;
        public int Level;
    }

}

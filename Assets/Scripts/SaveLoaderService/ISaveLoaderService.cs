using UnityEngine;

namespace Game.SaveLoadService
{
    public interface ISaveLoaderService
    {
        void Save();
        void Load();
        void Reset();
    }

}

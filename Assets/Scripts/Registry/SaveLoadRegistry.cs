using Game.Abstractions;

using System.Collections.Generic;

namespace Game.Registry
{
    public class SaveLoadRegistry : ISaveLoadRegistry
    {

        private List<ISaveLoad> _loadList = new List<ISaveLoad>();
         
        public void Add(ISaveLoad saveLoad)
        {
            _loadList.Add(saveLoad);
        }
        private void CleanUp()
        {
            _loadList.Clear();
        }

        public IEnumerable<ISaveLoad> GetSaveLoadServices()
        {
            return _loadList;
        }
    }

}

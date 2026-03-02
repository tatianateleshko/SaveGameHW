using Game.Abstractions;
using Game.DI;
using System.Collections.Generic;

namespace Game.Registry
{
    public class SaveLoadRegistry : ISaveLoadRegistry
    {
        private readonly IDIService _di;
        private List<ISaveLoad> _loadList = new List<ISaveLoad>();
         
        public SaveLoadRegistry(IDIService di)
        {
            _di = di;
        }

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

using Game.Abstractions;
using Game.Progress;
using Game.Registry;
using System.Linq;
using UnityEngine;
using Zenject;

namespace Game.SaveLoadService
{
    public class SaveLoaderService : ISaveLoaderService, IInitializable
    {
        private readonly IProgressService _progressService;
        private readonly ISaveLoadRegistry _saveLoadRegistry; 
        
        public SaveLoaderService(ISaveLoadRegistry saveLoadRegistry, IProgressService progressService)
        {
            _progressService = progressService;
            _saveLoadRegistry = saveLoadRegistry;
        }

        public void Initialize()
        {
            //Load();
        }

        public void Load()
        {
            if(_progressService.HasLoadProgress)
            {
                foreach(ISaveLoad saveLoad in _saveLoadRegistry.GetSaveLoadServices())
                {
                    saveLoad.Load(_progressService.Progress);
                }
            }
            else
            {
                Debug.Log("No Actual Progress Data");
            }
        }

        public void Reset()
        {
            foreach (ISaveLoad saveLoad in _saveLoadRegistry.GetSaveLoadServices())
            {
                saveLoad.Reset(_progressService.Progress);
            }
            _progressService.ResetProgress();   
        }

        public void Save()
        {
            var saves = _saveLoadRegistry.GetSaveLoadServices();
            Debug.Log("Loaders:" + saves.Count());
            foreach(ISaveLoad saveLoad in _saveLoadRegistry.GetSaveLoadServices())
            {
                saveLoad.Save(_progressService.Progress);
            }
            _progressService.SaveProgress();
        }
    }

}

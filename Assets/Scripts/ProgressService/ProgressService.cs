using Game.Data;
using UnityEngine;
using Zenject;

namespace Game.Progress
{
    public class ProgressService : IProgressService, IInitializable
    {
        public const string ProgressKey = "Progress";
        public PlayerProgress Progress { get; private set; }

        public bool HasLoadProgress {  get; private set; }


        public PlayerProgress CreateNewProgres()
        {
            HasLoadProgress = false;
            return Progress =  new PlayerProgress();
        }

        public void Initialize()
        {
            LoadProgressOrInitNew();
        }

        public PlayerProgress LoadProgressOrInitNew()
        {
            string json = PlayerPrefs.GetString(ProgressKey);
            Debug.Log($"Loading json: '{json}'");
            if (string.IsNullOrEmpty(json))
            {
                Debug.Log("New New ProgressCreated");
                return CreateNewProgres();
            }
            else
            {
                Debug.Log("New ProgressCreated");
                HasLoadProgress = true;
                Progress = JsonUtility.FromJson<PlayerProgress>(json);
                return Progress;
            }
        }

        public void ResetProgress()
        {
            PlayerPrefs.DeleteAll();
        }

        public void SaveProgress()
        {
            var json = JsonUtility.ToJson(Progress);
            Debug.Log($"Saving: {json}");
            PlayerPrefs.SetString(ProgressKey, json);
            PlayerPrefs.Save();
        }
    }

}

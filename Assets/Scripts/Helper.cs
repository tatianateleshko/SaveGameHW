using Game.Progress;
using Game.SaveLoadService;
using Sirenix.OdinInspector;
using UnityEngine;
using Zenject;

public class Helper : MonoBehaviour
{
    [SerializeField] private int _health;
    private ISaveLoaderService _saveLoaderService;
    private IPlayerTest _playerTest;

    [Inject]
    private void Construct(ISaveLoaderService saveLoaderService, IPlayerTest playerTest)
    {
        _saveLoaderService = saveLoaderService; 
        _playerTest = playerTest;
    }


    [Button] 
    public void Load()
    {
       _saveLoaderService.Load();
    }

    [Button]
    public void ResetSaves()
    {
        _saveLoaderService.Reset();
    }


    [Button]
    public void PrintPlayerHealth()
    {
        Debug.Log(_playerTest.Health);
    }


    [Button]
    public void Save()
    {
        _saveLoaderService.Save();
        Debug.Log("Save pressed");
    }

    [Button]
    public void SetHealth()
    {
        _playerTest.Health += _health;
        Debug.Log($"Health {_playerTest.Health}");
    }
}

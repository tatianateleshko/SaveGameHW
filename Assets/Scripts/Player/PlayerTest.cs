using Game.Abstractions;
using Game.Data;
using Game.Registry;
using UnityEngine;
using Zenject;


public class PlayerTest : IPlayerTest, ISaveLoad, IInitializable
{
    public int Health { get => _health; set => _health = value; }

    private int _health = 10;

    private readonly ISaveLoadRegistry _registry;

    public PlayerTest(ISaveLoadRegistry saveLoadRegistry) 
    { 
        _registry = saveLoadRegistry;    
    }

    public void Initialize()
    {
        _registry.Add(this);
        Debug.Log("Added player load");
    }

    public void Load(PlayerProgress playerProgress)
    {
       _health = playerProgress.PlayerData.Health;
       Debug.Log("Loaded health value" + _health);
    }

    public void Reset(PlayerProgress playerProgress)
    {
       _health = 0;
        Debug.Log(_health);
    }

    public void Save(PlayerProgress playerProgress)
    {
        playerProgress.PlayerData.Health = _health;
        Debug.Log("Player" + _health );
    }

}

using Game.Abstractions;
using System.Collections.Generic;

namespace Game.Registry
{
    public interface ISaveLoadRegistry
    {
        IEnumerable<ISaveLoad> GetSaveLoadServices();
        void Add(ISaveLoad saveLoad);
    }

}

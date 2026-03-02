using Game.Data;

namespace Game.Abstractions
{
    public interface ISaveLoad
    {
        void Save(PlayerProgress playerProgress);
        void Load(PlayerProgress playerProgress);
        void Reset(PlayerProgress playerProgress);
    }

}

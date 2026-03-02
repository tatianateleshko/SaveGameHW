using Game.Data;

namespace Game.Progress
{
    public interface IProgressService
    {
        PlayerProgress Progress { get; }
        bool HasLoadProgress { get; }
        PlayerProgress CreateNewProgres();
        void SaveProgress();
        void ResetProgress();
        PlayerProgress LoadProgressOrInitNew();
    }

}

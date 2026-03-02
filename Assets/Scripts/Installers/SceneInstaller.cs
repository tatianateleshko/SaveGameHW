using Game.DI;
using Game.Progress;
using Game.Registry;
using Game.SaveLoadService;
using UnityEngine;
using Zenject;
using Zenject.SpaceFighter;


namespace Game.Installers
{
    public class SceneInstaller : MonoInstaller
    {
        [SerializeField] private Helper _helper;
        public override void InstallBindings()
        {
            Container.Bind<IDIService>().To<DIService>().AsSingle();
            Container.BindInterfacesTo<SaveLoaderService>().AsSingle();
            Container.BindInterfacesTo<SaveLoadRegistry>().AsSingle();
            Container.BindInterfacesTo<ProgressService>().AsSingle();
            Container.BindInterfacesTo<PlayerTest>().AsSingle();
            Container.Bind<Helper>().FromInstance(_helper).AsSingle();
        }
    }

}

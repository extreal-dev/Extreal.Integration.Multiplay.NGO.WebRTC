﻿using System.Linq;
using Cysharp.Threading.Tasks;
using Extreal.Core.Common.System;
using Extreal.Core.StageNavigation;
using Extreal.Integration.Multiplay.NGO.WebRTC.MVS.App;
using UniRx;
using VContainer.Unity;

namespace Extreal.Integration.Multiplay.NGO.WebRTC.MVS.Controls.MultiplyControl.Client
{
    public class MultiplayClientPresenter : DisposableBase, IInitializable
    {
        private readonly NgoClient ngoClient;
        private readonly AppState appState;
        private readonly StageNavigator<StageName, SceneName> stageNavigator;
        private MultiplayClient multiplayClient;

        private readonly CompositeDisposable disposables = new CompositeDisposable();

        public MultiplayClientPresenter
        (
            NgoClient ngoClient,
            AppState appState,
            StageNavigator<StageName, SceneName> stageNavigator
        )
        {
            this.ngoClient = ngoClient;
            this.appState = appState;
            this.stageNavigator = stageNavigator;
        }

        public void Initialize()
        {
            multiplayClient = new MultiplayClient(ngoClient);
            disposables.Add(multiplayClient);

            appState.P2PReady
                .Where(ready => ready && appState.IsClient)
                .Subscribe(_ => multiplayClient.JoinAsync().Forget())
                .AddTo(disposables);

            stageNavigator.OnStageTransitioning
                .Subscribe(_ => multiplayClient.LeaveAsync().Forget())
                .AddTo(disposables);
        }

        protected override void ReleaseManagedResources()
            => disposables.Dispose();
    }
}

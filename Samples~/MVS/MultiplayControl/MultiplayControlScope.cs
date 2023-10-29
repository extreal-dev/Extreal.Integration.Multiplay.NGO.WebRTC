using Extreal.Integration.Multiplay.NGO.WebRTC.MVS.Controls.MultiplayControl.Host;
using Extreal.Integration.Multiplay.NGO.WebRTC.MVS.Controls.MultiplyControl.Client;
using UnityEngine;
using VContainer;
using VContainer.Unity;

namespace Extreal.Integration.Multiplay.NGO.WebRTC.MVS.Controls.MultiplyClientControl
{
    public class MultiplayControlScope : LifetimeScope
    {
        [SerializeField] private GameObject playerPrefab;

        protected override void Configure(IContainerBuilder builder)
        {
            builder.RegisterEntryPoint<MultiplayHostPresenter>().WithParameter(playerPrefab);
            builder.RegisterEntryPoint<MultiplayClientPresenter>();
        }
    }
}

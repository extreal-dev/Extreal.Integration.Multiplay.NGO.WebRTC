using Extreal.Core.StageNavigation;
using UnityEngine;

namespace Extreal.Integration.Multiplay.NGO.WebRTC.MVS.App
{
    [CreateAssetMenu(
        menuName = "Multiplay.NGO.WebRTC.MVS/" + nameof(StageConfig),
        fileName = nameof(StageConfig))]
    public class StageConfig : StageConfigBase<StageName, SceneName>
    {
    }
}

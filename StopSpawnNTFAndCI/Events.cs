using LabApi.Events.Arguments.ServerEvents;
using LabApi.Events.CustomHandlers;

namespace StopSpawnNTFAndCI
{
    public class EventsHandler : CustomEventsHandler
    {
        public override void OnServerWaveRespawning(WaveRespawningEventArgs ev)
        {
            ev.IsAllowed = false;
        }
    }
}

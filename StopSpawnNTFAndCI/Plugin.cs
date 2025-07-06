using LabApi.Events.CustomHandlers;
using LabApi.Features;
using LabApi.Loader.Features.Plugins;
using Version = System.Version;

namespace StopSpawnNTFAndCI
{
    internal class StopSpawnNTFAndCI : Plugin
    {
        public override string Name { get; } = "StopSpawnNTFAndCI";
        public override string Description { get; } = "Simple plugin that stops spawn NTF and CI Waves.";
        public override string Author { get; } = "Sans";
        public override Version Version { get; } = new Version(1, 0, 0);
        public override Version RequiredApiVersion { get; } = new Version(LabApiProperties.CompiledVersion);
        public EventsHandler Events { get; } = new();

        public override void Enable()
        {
            CustomHandlersManager.RegisterEventsHandler(Events);
        }
        public override void Disable()
        {
            CustomHandlersManager.UnregisterEventsHandler(Events);
        }
    }
}
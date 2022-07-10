namespace Maple2.Trigger._02000064_tw_triatown02_cn {
    public static class _stagetrigger_01 {
        public class StateKickMusicAudience : TriggerState {
            internal StateKickMusicAudience(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.KickMusicAudience(boxId: 101, portalId: 802);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKickMusicAudience(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

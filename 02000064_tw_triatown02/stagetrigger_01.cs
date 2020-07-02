namespace Maple2.Trigger._02000064_tw_triatown02 {
    public static class _stagetrigger_01 {
        public class StateKickMusicAudience : TriggerState {
            internal StateKickMusicAudience(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.KickMusicAudience(targetBoxId: 101, targetPortalId: 802);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKickMusicAudience(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
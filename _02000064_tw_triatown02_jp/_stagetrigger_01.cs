namespace Maple2.Trigger._02000064_tw_triatown02_jp {
    public static class _stagetrigger_01 {
        public class StateKickMusicAudience : TriggerState {
            internal StateKickMusicAudience(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.KickMusicAudience(targetBoxId: 101, targetPortalId: 802);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateKickMusicAudience(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
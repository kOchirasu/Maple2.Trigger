using System;

namespace Maple2.Trigger._02000064_tw_triatown02_cn {
    public static class _stagetrigger_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context =>
            new StateKickMusicAudience(context);

        private class StateKickMusicAudience : TriggerState {
            internal StateKickMusicAudience(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.KickMusicAudience(targetBoxID: 101, targetPortalID: 802);
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
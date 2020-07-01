namespace Maple2.Trigger._52010028_qd {
    public static class _view {
        public class State진동설정 : TriggerState {
            internal State진동설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 301, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 401, enable: false, path: @"BG/sound/Eff_ShakeLand_01.xml");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    context.State = new State흔들흔들(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {2006})) {
                    context.State = new State흔들흔들(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {2007})) {
                    context.State = new State흔들흔들(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State흔들흔들 : TriggerState {
            internal State흔들흔들(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 301, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 401, enable: true, path: @"BG/sound/Eff_ShakeLand_01.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State진동설정(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._52010028_qd {
    public static class _view {
        public class State진동설정 : TriggerState {
            internal State진동설정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 301, enable: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 401, enable: false, path: @"BG/sound/Eff_ShakeLand_01.xml");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    return new State흔들흔들(context);
                }

                if (context.UserDetected(arg1: new[] {2006})) {
                    return new State흔들흔들(context);
                }

                if (context.UserDetected(arg1: new[] {2007})) {
                    return new State흔들흔들(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State흔들흔들 : TriggerState {
            internal State흔들흔들(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 301, enable: true, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetOnetimeEffect(id: 401, enable: true, path: @"BG/sound/Eff_ShakeLand_01.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State진동설정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
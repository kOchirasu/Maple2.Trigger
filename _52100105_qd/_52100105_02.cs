namespace Maple2.Trigger._52100105_qd {
    public static class _52100105_02 {
        public class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {50101030}, arg3: new byte[] {3})) {
                    return new Statewait_03(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {50101020}, arg3: new byte[] {2})) {
                    return new Statewait_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statewait_03 : TriggerState {
            internal Statewait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State연출보러(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출보러 : TriggerState {
            internal State연출보러(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100105, arg2: 4);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
using System;

namespace Maple2.Trigger._52100105_qd {
    public static class _52100105_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {50101030},
                    arg3: new byte[] {3})) {
                    context.State = new Statewait_03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2002}, arg2: new int[] {50101020},
                    arg3: new byte[] {2})) {
                    context.State = new Statewait_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_03 : TriggerState {
            internal Statewait_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출보러(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출보러 : TriggerState {
            internal State연출보러(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52100105, arg2: 4);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
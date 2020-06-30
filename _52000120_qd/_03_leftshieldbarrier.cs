using System;

namespace Maple2.Trigger._52000120_qd {
    public static class _03_leftshieldbarrier {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3201}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {990, 991, 992, 993, 994, 995});
                context.SetSkill(arg1: new int[] {7001}, arg2: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateActivateShiled01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActivateShiled01 : TriggerState {
            internal StateActivateShiled01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {990, 991, 992, 993, 994, 995}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9201")) {
                    context.State = new StatePush01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePush01 : TriggerState {
            internal StatePush01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 990, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 991, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 992, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 993, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 994, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 995, arg2: "Attack_01_A");
                context.SetSkill(arg1: new int[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1333)) {
                    context.State = new StateReset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset01 : TriggerState {
            internal StateReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9201")) {
                    context.State = new StatePush01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
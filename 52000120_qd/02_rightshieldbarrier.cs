namespace Maple2.Trigger._52000120_qd {
    public static class _02_rightshieldbarrier {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {980, 981, 982, 983, 984, 985});
                context.SetSkill(arg1: new[] {7000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateActivateShiled01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActivateShiled01 : TriggerState {
            internal StateActivateShiled01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {980, 981, 982, 983, 984, 985}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new StatePush01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePush01 : TriggerState {
            internal StatePush01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 980, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 981, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 982, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 983, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 984, arg2: "Attack_01_A");
                context.SetNpcEmotionSequence(arg1: 985, arg2: "Attack_01_A");
                context.SetSkill(arg1: new[] {7000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1333)) {
                    return new StateReset01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset01 : TriggerState {
            internal StateReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    return new StatePush01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
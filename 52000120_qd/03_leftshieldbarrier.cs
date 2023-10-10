namespace Maple2.Trigger._52000120_qd {
    public static class _03_leftshieldbarrier {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3201}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{990, 991, 992, 993, 994, 995});
                context.SetSkill(triggerIds: new []{7001}, enabled: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{990, 991, 992, 993, 994, 995}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9201})) {
                    return new StatePush01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePush01 : TriggerState {
            internal StatePush01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 990, sequenceName: "Attack_01_A");
                context.SetNpcEmotionSequence(spawnId: 991, sequenceName: "Attack_01_A");
                context.SetNpcEmotionSequence(spawnId: 992, sequenceName: "Attack_01_A");
                context.SetNpcEmotionSequence(spawnId: 993, sequenceName: "Attack_01_A");
                context.SetNpcEmotionSequence(spawnId: 994, sequenceName: "Attack_01_A");
                context.SetNpcEmotionSequence(spawnId: 995, sequenceName: "Attack_01_A");
                context.SetSkill(triggerIds: new []{7001}, enabled: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9201})) {
                    return new StatePush01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._52000066_qd {
    public static class _train03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001072}, arg2: 1);
                context.SetUserValue(key: "TrainMove", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TrainMove") == 1) {
                    return new State4thPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200663, textId: 25200663);
            }
        }

        private class State4thPhaseChase01 : TriggerState {
            internal State4thPhaseChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001072}, arg2: 0)) {
                    return new State4thPhaseChase02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thPhaseChase02 : TriggerState {
            internal State4thPhaseChase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200663);
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_200");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateGetInTheTrain01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain01 : TriggerState {
            internal StateGetInTheTrain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200664, textId: 25200664);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9700})) {
                    return new StateGetInTheTrain02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain02 : TriggerState {
            internal StateGetInTheTrain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 700, enable: true);
                context.HideGuideSummary(entityId: 25200664);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200665, textId: 25200665, duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateGetInTheTrain03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain03 : TriggerState {
            internal StateGetInTheTrain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateGetInTheTrain04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain04 : TriggerState {
            internal StateGetInTheTrain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 700, enable: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetInteractObject(arg1: new[] {10001072}, arg2: 1);
            }
        }
    }
}
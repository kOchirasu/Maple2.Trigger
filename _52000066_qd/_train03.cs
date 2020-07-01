using System;

namespace Maple2.Trigger._52000066_qd {
    public static class _train03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10001072}, arg2: 1);
                context.SetUserValue(key: "TrainMove", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "TrainMove", value: 1)) {
                    context.State = new State4thPhaseChase01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 25200663, textID: 25200663);
            }
        }

        private class State4thPhaseChase01 : TriggerState {
            internal State4thPhaseChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001072}, arg2: 0)) {
                    context.State = new State4thPhaseChase02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thPhaseChase02 : TriggerState {
            internal State4thPhaseChase02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25200663);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_200");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGetInTheTrain01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain01 : TriggerState {
            internal StateGetInTheTrain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 25200664, textID: 25200664);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9700})) {
                    context.State = new StateGetInTheTrain02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain02 : TriggerState {
            internal StateGetInTheTrain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 700, enable: true);
                context.HideGuideSummary(entityID: 25200664);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 25200665, textID: 25200665, duration: 2000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateGetInTheTrain03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain03 : TriggerState {
            internal StateGetInTheTrain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateGetInTheTrain04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain04 : TriggerState {
            internal StateGetInTheTrain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 700, enable: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateReset(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {201});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thPhaseChase01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10001072}, arg2: 1);
            }
        }
    }
}
namespace Maple2.Trigger._52000066_qd {
    public static class _train03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetInteractObject(interactIds: new []{10001072}, state: 1);
                context.SetUserValue(key: "TrainMove", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TrainMove") == 1) {
                    return new State4thPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200663, textId: 25200663);
            }
        }

        private class State4thPhaseChase01 : TriggerState {
            internal State4thPhaseChase01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001072}, arg2: 0)) {
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
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_200");
            }

            public override TriggerState? Execute() {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200664, textId: 25200664);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9700})) {
                    return new StateGetInTheTrain02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGetInTheTrain02 : TriggerState {
            internal StateGetInTheTrain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 700, enabled: true);
                context.HideGuideSummary(entityId: 25200664);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 25200665, textId: 25200665, duration: 2000);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
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
                context.SetLocalCamera(cameraId: 700, enabled: false);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thPhaseChase01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetInteractObject(interactIds: new []{10001072}, state: 1);
            }
        }
    }
}

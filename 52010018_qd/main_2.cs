namespace Maple2.Trigger._52010018_qd {
    public static class _main_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002, 3003}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Eff_MassiveEvent_Door_Vanished");
                context.SetActor(triggerId: 202, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 203, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 204, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 205, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 206, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 207, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 208, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 209, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 210, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                context.SetActor(triggerId: 211, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{100}, questIds: new []{10002853}, questStates: new byte[]{1})) {
                    return new State미카이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카이동02 : TriggerState {
            internal State미카이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 302, enabled: true);
                context.DestroyMonster(spawnIds: new []{1005});
                context.CreateMonster(spawnIds: new []{1007}, arg2: false);
                context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007_A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 104, spawnIds: new []{1007})) {
                    return new State다리CreationWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리CreationWait : TriggerState {
            internal State다리CreationWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new State다리Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리Creation : TriggerState {
            internal State다리Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetActor(triggerId: 201, visible: true, initialSequence: "Eff_MassiveEvent_Door_Opened");
                    context.SetActor(triggerId: 202, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 203, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 204, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 205, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 206, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 207, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 208, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 209, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 210, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    context.SetActor(triggerId: 211, visible: true, initialSequence: "Eff_MassiveEvent_Stair_Opened");
                    return new State미카Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script02 : TriggerState {
            internal State미카Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010018_QD__MAIN_2__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State에레브Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에레브Script02 : TriggerState {
            internal State에레브Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010018_QD__MAIN_2__1$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State미카Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카Script03 : TriggerState {
            internal State미카Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010018_QD__MAIN_2__2$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.MoveNpc(spawnId: 1007, patrolName: "MS2PatrolData_1007_B");
                    return new State미카소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State미카소멸 : TriggerState {
            internal State미카소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    context.CameraSelect(triggerId: 302, enabled: false);
                    context.DestroyMonster(spawnIds: new []{1007});
                    context.SetAchievement(triggerId: 100, type: "trigger", code: "BacktoDrakenheim");
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetActor(triggerId: 201, visible: false, initialSequence: "Eff_MassiveEvent_Door_Vanished");
                    context.SetActor(triggerId: 202, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 203, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 204, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 205, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 206, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 207, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 208, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 209, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 210, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    context.SetActor(triggerId: 211, visible: false, initialSequence: "Eff_MassiveEvent_Stair_Closed");
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._52000050_qd {
    public static class _main_02 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 7001, visible: false, initialSequence: "Sit_Down_A");
                context.SetActor(triggerId: 7002, visible: false, initialSequence: "Down_Idle_A");
                context.SetMesh(triggerIds: new []{6020, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6011}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000478}, state: 1);
                context.SetEffect(triggerIds: new []{7010}, visible: false);
                context.SetBreakable(triggerIds: new []{9010, 9011, 9012, 9013, 9014}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{9010, 9011, 9012, 9013, 9014}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003059}, questStates: new byte[]{1})) {
                    return new StateStart_c(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003058}, questStates: new byte[]{2})) {
                    return new StateStart_c(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003058}, questStates: new byte[]{1})) {
                    return new StateStart_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_b : TriggerState {
            internal StateStart_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7011}, visible: true);
                context.SetMesh(triggerIds: new []{6020, 6021, 6022, 6023, 6024, 6025}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{6020, 6021, 6022, 6023, 6024, 6025}, visible: true, arg3: 0, arg4: 0);
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 111, 112, 121, 122});
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Sit_Down_A");
                context.SetActor(triggerId: 7002, visible: true, initialSequence: "Down_Idle_A");
                context.SetMesh(triggerIds: new []{6010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6011}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000478}, arg2: 0)) {
                    return new StateStart_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_b_02 : TriggerState {
            internal StateStart_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7010}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUser(mapId: 52000048, portalId: 1);
                    // return new StateStart_02_end(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c : TriggerState {
            internal StateStart_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6020, 6021, 6022, 6023, 6024}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{6020, 6021, 6022, 6023, 6024, 6025}, visible: true, arg3: 0, arg4: 0);
                context.DestroyMonster(spawnIds: new []{101, 102, 111, 112, 121, 122});
                context.SetActor(triggerId: 7001, visible: true, initialSequence: "Sit_Down_A");
                context.SetActor(triggerId: 7002, visible: true, initialSequence: "Down_Idle_A");
                context.SetMesh(triggerIds: new []{6010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{6010}, visible: true, arg3: 0, arg4: 0);
                context.SetInteractObject(interactIds: new []{10000478}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003059}, questStates: new byte[]{1})) {
                    context.MoveUser(mapId: 52000050, portalId: 2);
                    return new StateStart_c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c_02 : TriggerState {
            internal StateStart_c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6020, 6021, 6022, 6023, 6024, 6025}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{6026, 6027, 6028, 6029, 6030}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMeshAnimation(triggerIds: new []{6026, 6027, 6028, 6029, 6030}, visible: true, arg3: 0, arg4: 0);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8010, 8011, 8001}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_9902");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000050_QD__MAIN_02__0$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_c_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c_03 : TriggerState {
            internal StateStart_c_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000050_QD__MAIN_02__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_c_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c_04 : TriggerState {
            internal StateStart_c_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000050_QD__MAIN_02__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStart_c_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c_05 : TriggerState {
            internal StateStart_c_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{9010, 9011, 9012, 9013, 9014}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{9010, 9011, 9012, 9013, 9014}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetMesh(triggerIds: new []{6026, 6027, 6028, 6029, 6030}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateStart_c_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c_06 : TriggerState {
            internal StateStart_c_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7011}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelectPath(pathIds: new []{8001}, returnView: true);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "FlyingBirds");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.SetBreakable(triggerIds: new []{9010, 9011, 9012, 9013, 9014}, enabled: false);
                    context.SetVisibleBreakableObject(triggerIds: new []{9010, 9011, 9012, 9013, 9014}, arg2: false);
                    return new StateStart_c_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_c_07 : TriggerState {
            internal StateStart_c_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

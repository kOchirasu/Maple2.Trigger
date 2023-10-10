namespace Maple2.Trigger._02000379_bf {
    public static class _fakelaoz01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5100, 5200, 5300}, visible: false);
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3002}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMeshAnimation(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3001, 3002}, visible: false, arg3: 0, arg4: 0);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3200, 3201, 3202, 3203, 3204, 3205, 3206}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{2000, 2001, 2002}, enabled: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLodingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 201, 301, 910, 911, 912, 920, 921, 922}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLodingDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay03 : TriggerState {
            internal StateLodingDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraAct01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct01 : TriggerState {
            internal StateCameraAct01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000379_BF__FAKELAOZ01__0$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.SetSkip(state: new StateCameraAct02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCameraAct02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct02 : TriggerState {
            internal StateCameraAct02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCameraAct03(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraAct03 : TriggerState {
            internal StateCameraAct03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.SetConversation(type: 1, spawnId: 201, script: "$02000379_BF__FAKELAOZ01__1$", arg4: 3, arg5: 0);
                context.SetSkip(state: new StateCameraAct04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraAct04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct04 : TriggerState {
            internal StateCameraAct04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(triggerId: 600, enabled: false);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKanduraTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraTalk01 : TriggerState {
            internal StateKanduraTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$02000379_BF__FAKELAOZ01__2$", arg4: 3, arg5: 2);
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Event_A");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateCollapseBridge01(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCollapseBridge01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge01 : TriggerState {
            internal StateCollapseBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2000}, enabled: true);
                context.SetEffect(triggerIds: new []{5100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCollapseBridge02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge02 : TriggerState {
            internal StateCollapseBridge02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2001}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCollapseBridge03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge03 : TriggerState {
            internal StateCollapseBridge03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2002}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCollapseBridge04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge04 : TriggerState {
            internal StateCollapseBridge04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraAct11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct11 : TriggerState {
            internal StateCameraAct11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enabled: true);
                context.SetSkip(state: new StateCameraAct13(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraAct12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct12 : TriggerState {
            internal StateCameraAct12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 301, script: "$02000379_BF__FAKELAOZ01__3$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Event_A");
                context.SetSkip(state: new StateCameraAct13(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraAct13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraAct13 : TriggerState {
            internal StateCameraAct13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enabled: false);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFakeLaozApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp01 : TriggerState {
            internal StateFakeLaozApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 602, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFakeLaozApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp02 : TriggerState {
            internal StateFakeLaozApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5200}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFakeLaozApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp03 : TriggerState {
            internal StateFakeLaozApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{102, 202, 900}, arg2: false);
                context.SetSkip(state: new StateFakeLaozApp04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFakeLaozApp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp04 : TriggerState {
            internal StateFakeLaozApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011}, visible: false);
                context.CameraSelect(triggerId: 602, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKanduraDisapp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisapp01 : TriggerState {
            internal StateKanduraDisapp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "SpyKandura", value: 1);
                context.DestroyMonster(spawnIds: new []{301});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateKanduraDisapp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraDisapp02 : TriggerState {
            internal StateKanduraDisapp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateFakeLaozDie01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozDie01 : TriggerState {
            internal StateFakeLaozDie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 200, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3001}, visible: true, arg3: 200, arg4: 0);
                context.SetUserValue(triggerId: 2, key: "SpyKandura", value: 2);
                context.DestroyMonster(spawnIds: new []{900, 910, 911, 912, 920, 921, 922, 102, 202});
                context.CreateMonster(spawnIds: new []{103, 203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLampLightUp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp01 : TriggerState {
            internal StateLampLightUp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: true);
                context.SetRandomMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323}, visible: true, meshCount: 24, arg4: 100, delay: 70);
                context.SetMesh(triggerIds: new []{3202, 3203, 3204, 3100, 3101, 3102, 3103, 3104, 3105, 3106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CameraSelect(triggerId: 700, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new StateLampLightUp02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLampLightUp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp02 : TriggerState {
            internal StateLampLightUp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.MoveUser(mapId: 02000379, portalId: 11, boxId: 9900);
            }

            public override TriggerState? Execute() {
                return new StateLampLightUp03(context);
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp03 : TriggerState {
            internal StateLampLightUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 103, script: "$02000379_BF__FAKELAOZ01__4$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 203, script: "$02000379_BF__FAKELAOZ01__5$", arg4: 3, arg5: 3);
                context.SetSkip(state: new StateLampLightUp04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateLampLightUp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp04 : TriggerState {
            internal StateLampLightUp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateLampLightUp05(context);
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp05 : TriggerState {
            internal StateLampLightUp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_102");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_202");
                context.SetConversation(type: 1, spawnId: 103, script: "$02000379_BF__FAKELAOZ01__6$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 203, script: "$02000379_BF__FAKELAOZ01__7$", arg4: 3, arg5: 6);
                context.SetSkip(state: new StateTimeToLeave01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 700, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

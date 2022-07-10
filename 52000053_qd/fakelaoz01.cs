namespace Maple2.Trigger._52000053_qd {
    public static class _fakelaoz01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5000, 5100, 5200, 5300, 5400, 5500, 5501, 5502, 5600}, visible: false);
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3002}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
                context.SetMeshAnimation(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3001, 3002}, visible: false, arg3: 0, arg4: 0);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3319, 3320, 3321, 3322, 3323}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(triggerIds: new []{2000, 2001, 2002, 2003}, arg2: false);
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
                context.CameraSelect(triggerId: 500, enable: true);
                context.CreateMonster(spawnIds: new []{101, 201, 910, 911, 912, 920, 921, 922}, arg2: false);
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateZoomInLamp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateZoomInLamp01 : TriggerState {
            internal StateZoomInLamp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateZoomInLamp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateZoomInLamp02 : TriggerState {
            internal StateZoomInLamp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000053_QD__FAKELAOZ01__0$", arg4: 4);
                context.SetSkip(state: new StateZoomInLamp02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateZoomInLamp02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateZoomInLamp02Skip : TriggerState {
            internal StateZoomInLamp02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateMoveToLamp01(context);
            }

            public override void OnExit() { }
        }

        private class StateMoveToLamp01 : TriggerState {
            internal StateMoveToLamp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 510, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMoveToLamp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToLamp02 : TriggerState {
            internal StateMoveToLamp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52000053_QD__FAKELAOZ01__1$", arg4: 2, arg5: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_110");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_210");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateMoveToLamp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToLamp03 : TriggerState {
            internal StateMoveToLamp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enable: true);
                context.SetConversation(type: 1, spawnId: 201, script: "$52000053_QD__FAKELAOZ01__2$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePCStop01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCStop01 : TriggerState {
            internal StatePCStop01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000053_QD__FAKELAOZ01__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCStop02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCStop02 : TriggerState {
            internal StatePCStop02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 511, enable: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_111");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000053_QD__FAKELAOZ01__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCStop03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCStop03 : TriggerState {
            internal StatePCStop03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_211");
                context.SetConversation(type: 1, spawnId: 201, script: "$52000053_QD__FAKELAOZ01__5$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateKanduraApp00(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp00 : TriggerState {
            internal StateKanduraApp00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_212");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp01 : TriggerState {
            internal StateKanduraApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_112");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp02 : TriggerState {
            internal StateKanduraApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301}, arg2: false);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_302");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateKanduraApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp03 : TriggerState {
            internal StateKanduraApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 512, enable: true);
                context.SetConversation(type: 2, spawnId: 11001559, script: "$52000053_QD__FAKELAOZ01__6$", arg4: 3);
                context.SetSkip(state: new StateKanduraApp03Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKanduraApp03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp03Skip : TriggerState {
            internal StateKanduraApp03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKanduraApp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp04 : TriggerState {
            internal StateKanduraApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{104, 204}, arg2: false);
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Event_A");
                context.SetConversation(type: 2, spawnId: 11001559, script: "$52000053_QD__FAKELAOZ01__7$", arg4: 5);
                context.SetSkip(state: new StateKanduraApp04Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateKanduraApp04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraApp04Skip : TriggerState {
            internal StateKanduraApp04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 520, enable: true);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_113");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_213");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCollapseBridge01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCollapseBridge01 : TriggerState {
            internal StateCollapseBridge01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{2000}, arg2: true);
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
                context.SetSkill(triggerIds: new []{2001}, arg2: true);
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
                context.SetSkill(triggerIds: new []{2002}, arg2: true);
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

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000053_QD__FAKELAOZ01__31$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraSummon01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraSummon01 : TriggerState {
            internal StateKanduraSummon01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 601, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKanduraSummon02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraSummon02 : TriggerState {
            internal StateKanduraSummon02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 301, sequenceName: "Event_A");
                context.SetConversation(type: 2, spawnId: 11001559, script: "$52000053_QD__FAKELAOZ01__8$", arg4: 4);
                context.SetSkip(state: new StateKanduraSummon03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateKanduraSummon03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraSummon03 : TriggerState {
            internal StateKanduraSummon03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(triggerId: 602, enable: true);
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
                context.SetEffect(triggerIds: new []{5200}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFakeLaozApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp02 : TriggerState {
            internal StateFakeLaozApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{900}, arg2: false);
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
                context.CameraSelect(triggerId: 603, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1003");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000053_QD__FAKELAOZ01__9$", arg4: 2, arg5: 0);
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
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000053_QD__FAKELAOZ01__10$", arg4: 4);
                context.SetSkip(state: new StateFakeLaozApp04Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFakeLaozApp04Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFakeLaozApp04Skip : TriggerState {
            internal StateFakeLaozApp04Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReachToLamp01(context);
            }

            public override void OnExit() { }
        }

        private class StateReachToLamp01 : TriggerState {
            internal StateReachToLamp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000053_QD__FAKELAOZ01__11$", arg4: 4);
                context.SetSkip(state: new StateReachToLamp02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReachToLamp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReachToLamp02 : TriggerState {
            internal StateReachToLamp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateReachToLamp03(context);
            }

            public override void OnExit() { }
        }

        private class StateReachToLamp03 : TriggerState {
            internal StateReachToLamp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 700, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_101");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateReachToLamp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReachToLamp04 : TriggerState {
            internal StateReachToLamp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104, 204});
                context.CreateMonster(spawnIds: new []{102, 202}, arg2: false);
                context.CameraSelect(triggerId: 700, enable: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011}, visible: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
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
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFakeLaozDie01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{900, 910, 911, 912, 920, 921, 922});
            }
        }

        private class StateFakeLaozDie01 : TriggerState {
            internal StateFakeLaozDie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 200, arg4: 0, arg5: 5f);
                context.SetMesh(triggerIds: new []{3001}, visible: true, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3001}, visible: true, arg3: 200, arg4: 0);
                context.SetUserValue(triggerId: 2, key: "SpyKandura", value: 2);
                context.DestroyMonster(spawnIds: new []{102, 202});
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
                context.CameraSelect(triggerId: 700, enable: true);
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
            }

            public override TriggerState? Execute() {
                return new StateLampLightUp03(context);
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp03 : TriggerState {
            internal StateLampLightUp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000053, portalId: 11, boxId: 9900);
                context.SetConversation(type: 1, spawnId: 103, script: "$52000053_QD__FAKELAOZ01__12$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 203, script: "$52000053_QD__FAKELAOZ01__13$", arg4: 3, arg5: 3);
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
                context.SetConversation(type: 1, spawnId: 103, script: "$52000053_QD__FAKELAOZ01__14$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateLampLightUp06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLampLightUp06 : TriggerState {
            internal StateLampLightUp06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 701, enable: true);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_103");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.SetConversation(type: 1, spawnId: 203, script: "$52000053_QD__FAKELAOZ01__15$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNpcWalkDown01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcWalkDown01 : TriggerState {
            internal StateNpcWalkDown01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 702, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1004");
                context.SetConversation(type: 1, spawnId: 103, script: "$52000053_QD__FAKELAOZ01__16$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNpcWalkDown02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcWalkDown02 : TriggerState {
            internal StateNpcWalkDown02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{302}, arg2: false);
                context.SetConversation(type: 1, spawnId: 203, script: "$52000053_QD__FAKELAOZ01__17$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000053_QD__FAKELAOZ01__18$", arg4: 3, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNpcWalkDown03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcWalkDown03 : TriggerState {
            internal StateNpcWalkDown03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3002}, visible: true, arg3: 0, arg4: 0, arg5: 5f);
                context.SetMeshAnimation(triggerIds: new []{3001}, visible: false, arg3: 0, arg4: 0);
                context.SetMeshAnimation(triggerIds: new []{3002}, visible: true, arg3: 200, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateKanduraAppAgain01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppAgain01 : TriggerState {
            internal StateKanduraAppAgain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001559, script: "$52000053_QD__FAKELAOZ01__19$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateKanduraAppAgain02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{103, 203});
                context.CreateMonster(spawnIds: new []{105, 205}, arg2: false);
            }
        }

        private class StateKanduraAppAgain02 : TriggerState {
            internal StateKanduraAppAgain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_104");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_204");
                context.SetSkip(state: new StateKanduraAppAgain03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateKanduraAppAgain03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraAppAgain03 : TriggerState {
            internal StateKanduraAppAgain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 710, enable: true);
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_303");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateNoticeLampDisapp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNoticeLampDisapp01 : TriggerState {
            internal StateNoticeLampDisapp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001557, script: "$52000053_QD__FAKELAOZ01__20$", arg4: 4);
                context.SetSkip(state: new StateNoticeLampDisapp01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNoticeLampDisapp01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNoticeLampDisapp01Skip : TriggerState {
            internal StateNoticeLampDisapp01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateNoticeLampDisapp02(context);
            }

            public override void OnExit() { }
        }

        private class StateNoticeLampDisapp02 : TriggerState {
            internal StateNoticeLampDisapp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$52000053_QD__FAKELAOZ01__21$", arg4: 4);
                context.SetSkip(state: new StateNoticeLampDisapp02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateNoticeLampDisapp02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNoticeLampDisapp02Skip : TriggerState {
            internal StateNoticeLampDisapp02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 711, enable: true);
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraReadyToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToLeave01 : TriggerState {
            internal StateKanduraReadyToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_304");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateKanduraReadyToLeave02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToLeave02 : TriggerState {
            internal StateKanduraReadyToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001559, script: "$52000053_QD__FAKELAOZ01__22$", arg4: 5);
                context.SetEffect(triggerIds: new []{5400}, visible: true);
                context.SetSkip(state: new StateKanduraReadyToLeave03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateKanduraReadyToLeave03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKanduraReadyToLeave03 : TriggerState {
            internal StateKanduraReadyToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CreateMonster(spawnIds: new []{840, 841, 842, 843, 844, 845, 846, 847, 848, 849, 850, 851, 852, 853, 854, 855, 856, 857, 858, 859, 860, 861, 862, 863, 864, 865, 866, 867, 868, 869}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateShadowApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp01 : TriggerState {
            internal StateShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{870, 871, 872, 873, 874, 875, 876, 877, 878, 879, 880, 881, 882, 883, 884, 885, 886, 887, 888, 889, 890, 891, 892, 893, 894, 895, 896, 897, 898, 899}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp02 : TriggerState {
            internal StateShadowApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{302});
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_105");
                context.MoveNpc(spawnId: 205, patrolName: "MS2PatrolData_205");
                context.CameraSelect(triggerId: 720, enable: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_1005");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTired01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTired01 : TriggerState {
            internal StateNpcTired01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 105, script: "$52000053_QD__FAKELAOZ01__23$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTired02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTired02 : TriggerState {
            internal StateNpcTired02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 105, sequenceName: "Down_Idle_A", duration: 20000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcTired03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTired03 : TriggerState {
            internal StateNpcTired03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 205, script: "$52000053_QD__FAKELAOZ01__24$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTired04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTired04 : TriggerState {
            internal StateNpcTired04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 205, sequenceName: "Down_Idle_A", duration: 20000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateNpcTired05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTired05 : TriggerState {
            internal StateNpcTired05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 205, script: "$52000053_QD__FAKELAOZ01__25$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateNpcTired06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcTired06 : TriggerState {
            internal StateNpcTired06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000053_QD__FAKELAOZ01__26$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateRealLaozApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRealLaozApp01 : TriggerState {
            internal StateRealLaozApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001556, script: "$52000053_QD__FAKELAOZ01__27$", arg4: 4);
                context.DestroyMonster(spawnIds: new []{105, 205});
                context.CreateMonster(spawnIds: new []{106, 206}, arg2: false);
                context.SetSkip(state: new StateRealLaozApp02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateRealLaozApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRealLaozApp02 : TriggerState {
            internal StateRealLaozApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CreateMonster(spawnIds: new []{400}, arg2: false);
                context.CreateMonster(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRealLaozApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRealLaozApp03 : TriggerState {
            internal StateRealLaozApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 721, enable: true);
                context.DestroyMonster(spawnIds: new []{840, 841, 842, 843, 844, 845, 846, 847, 848, 849, 850, 851, 852, 853, 854, 855, 856, 857, 858, 859, 860, 861, 862, 863, 864, 865, 866, 867, 868, 869, 870, 871, 872, 873, 874, 875, 876, 877, 878, 879, 880, 881, 882, 883, 884, 885, 886, 887, 888, 889, 890, 891, 892, 893, 894, 895, 896, 897, 898, 899});
                context.SetConversation(type: 1, spawnId: 400, script: "$52000053_QD__FAKELAOZ01__28$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLaozKillAll01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozKillAll01 : TriggerState {
            internal StateLaozKillAll01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5600}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 400, sequenceName: "Attack_01_D");
                context.SetEffect(triggerIds: new []{5501}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1400)) {
                    return new StateLaozKillAll02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozKillAll02 : TriggerState {
            internal StateLaozKillAll02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5500, 5502}, visible: true);
                context.SetSkill(triggerIds: new []{2003}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLaozKillAll03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLaozKillAll03 : TriggerState {
            internal StateLaozKillAll03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400}, visible: false);
                context.DestroyMonster(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989, 990, 991, 992, 993, 994, 995, 996, 997, 998, 999});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMeetRealLaoz01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetRealLaoz01 : TriggerState {
            internal StateMeetRealLaoz01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 730, enable: true);
                context.SetConversation(type: 1, spawnId: 400, script: "$52000053_QD__FAKELAOZ01__29$", arg4: 3, arg5: 1);
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_400");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMeetRealLaoz02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMeetRealLaoz02 : TriggerState {
            internal StateMeetRealLaoz02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 0, script: "$52000053_QD__FAKELAOZ01__30$", arg4: 2, arg5: 0);
                context.MoveUserPath(patrolName: "MS2PatrolData_1006");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuestLaozApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestLaozApp01 : TriggerState {
            internal StateQuestLaozApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{400});
                context.CreateMonster(spawnIds: new []{401}, arg2: false);
                context.CameraSelect(triggerId: 730, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReturnLaoz01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnLaoz01 : TriggerState {
            internal StateReturnLaoz01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "ReturnLaoz");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{10003058}, questStates: new byte[]{1})) {
                    return new StateTimeToLeave01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

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
                context.MoveUser(mapId: 52000050, portalId: 2, boxId: 9900);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._52000070_qd {
    public static class _trap01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: false);
                context.SetMesh(triggerIds: new []{3100, 4100}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{4200}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 3000, visible: true, initialSequence: "Closed");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{6000, 6100}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002677}, questStates: new byte[]{1})) {
                    return new StateLoadingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCEnter01 : TriggerState {
            internal StatePCEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 600, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCEnter02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCEnter02 : TriggerState {
            internal StatePCEnter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enable: true);
                context.SetMesh(triggerIds: new []{4200}, visible: false, arg3: 100, arg4: 0, arg5: 3f);
                context.SetBreakable(triggerIds: new []{4000}, enabled: true);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: true);
                context.SetEffect(triggerIds: new []{6000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBoardSlide01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardSlide01 : TriggerState {
            internal StateBoardSlide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3000, visible: true, initialSequence: "Opened");
                context.SetEffect(triggerIds: new []{6100}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBoardSlide02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardSlide02 : TriggerState {
            internal StateBoardSlide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4100}, visible: true, arg3: 800, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyNpcWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn01 : TriggerState {
            internal StateEnemyNpcWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: false);
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, arg2: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyNpcWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn02 : TriggerState {
            internal StateEnemyNpcWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 602, enable: true);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_102");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyNpcWalkIn03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn03 : TriggerState {
            internal StateEnemyNpcWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_103");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyNpcWalkIn04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn04 : TriggerState {
            internal StateEnemyNpcWalkIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_104");
                context.CameraSelect(triggerId: 603, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnemyNpcTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk01 : TriggerState {
            internal StateEnemyNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001963, script: "$52000070_QD__TRAP01__0$", arg4: 5);
                context.SetSkip(state: new StateEnemyNpcTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnemyNpcTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk01Skip : TriggerState {
            internal StateEnemyNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEnemyNpcTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk02 : TriggerState {
            internal StateEnemyNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001963, script: "$52000070_QD__TRAP01__1$", arg4: 5);
                context.SetSkip(state: new StateEnemyNpcTalk02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnemyNpcTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk02Skip : TriggerState {
            internal StateEnemyNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnemyMobChange01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnemyMobChange01 : TriggerState {
            internal StateEnemyMobChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104});
                context.CreateMonster(spawnIds: new []{901, 902, 903, 904}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904})) {
                    return new StateBattleEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCPositionFix01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPositionFix01 : TriggerState {
            internal StatePCPositionFix01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 604, enable: true);
                context.MoveUser(mapId: 52000070, portalId: 10, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePCPositionFix02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPositionFix02 : TriggerState {
            internal StatePCPositionFix02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFriendNpcWalkIn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcWalkIn01 : TriggerState {
            internal StateFriendNpcWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204}, arg2: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_202");
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_203");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFriendNpcWalkIn02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcWalkIn02 : TriggerState {
            internal StateFriendNpcWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
                context.CameraSelect(triggerId: 605, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateFriendNpcTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk01 : TriggerState {
            internal StateFriendNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001964, script: "$52000070_QD__TRAP01__2$", arg4: 4);
                context.SetSkip(state: new StateFriendNpcTalk01Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFriendNpcTalk01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk01Skip : TriggerState {
            internal StateFriendNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateFriendNpcTalk02(context);
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk02 : TriggerState {
            internal StateFriendNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001964, script: "$52000070_QD__TRAP01__3$", arg4: 4);
                context.SetSkip(state: new StateFriendNpcTalk02Skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFriendNpcTalk02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk02Skip : TriggerState {
            internal StateFriendNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWayOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWayOpen01 : TriggerState {
            internal StateWayOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_211");
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_212");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWayOpen02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWayOpen02 : TriggerState {
            internal StateWayOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_213");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_214");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWayOpen03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWayOpen03 : TriggerState {
            internal StateWayOpen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 201, script: "$52000070_QD__TRAP01__4$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestCom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestCom : TriggerState {
            internal StateQuestCom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 9900, type: "trigger", code: "remnantssweeping");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{40002677}, questStates: new byte[]{2})) {
                    return new StateMoveToComplete(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToComplete : TriggerState {
            internal StateMoveToComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.MoveUser(mapId: 02000208, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

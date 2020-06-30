using System;

namespace Maple2.Trigger._52000070_qd {
    public static class _trap01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4200}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 3000, arg2: true, arg3: "Closed");
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6100}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002677},
                    arg3: new byte[] {1})) {
                    context.State = new StateLoadingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay01 : TriggerState {
            internal StateLoadingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCEnter01 : TriggerState {
            internal StatePCEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePCEnter02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCEnter02 : TriggerState {
            internal StatePCEnter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetMesh(arg1: new int[] {4200}, arg2: false, arg3: 100, arg4: 0, arg5: 3f);
                context.SetBreakable(arg1: new int[] {4000}, arg2: true);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: true);
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateBoardSlide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardSlide01 : TriggerState {
            internal StateBoardSlide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 3000, arg2: true, arg3: "Opened");
                context.SetEffect(arg1: new int[] {6100}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBoardSlide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBoardSlide02 : TriggerState {
            internal StateBoardSlide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {4100}, arg2: true, arg3: 800, arg4: 0, arg5: 3f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnemyNpcWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn01 : TriggerState {
            internal StateEnemyNpcWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnemyNpcWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn02 : TriggerState {
            internal StateEnemyNpcWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: true);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnemyNpcWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn03 : TriggerState {
            internal StateEnemyNpcWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnemyNpcWalkIn04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcWalkIn04 : TriggerState {
            internal StateEnemyNpcWalkIn04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104");
                context.CameraSelect(arg1: 603, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnemyNpcTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk01 : TriggerState {
            internal StateEnemyNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001963, arg3: "$52000070_QD__TRAP01__0$", arg4: 5);
                context.SetSkip(arg1: "EnemyNpcTalk01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEnemyNpcTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk01Skip : TriggerState {
            internal StateEnemyNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEnemyNpcTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk02 : TriggerState {
            internal StateEnemyNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001963, arg3: "$52000070_QD__TRAP01__1$", arg4: 5);
                context.SetSkip(arg1: "EnemyNpcTalk02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEnemyNpcTalk02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyNpcTalk02Skip : TriggerState {
            internal StateEnemyNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateEnemyMobChange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnemyMobChange01 : TriggerState {
            internal StateEnemyMobChange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.DestroyMonster(arg1: new int[] {101, 102, 103, 104});
                context.CreateMonster(arg1: new int[] {901, 902, 903, 904}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901, 902, 903, 904})) {
                    context.State = new StateBattleEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCPositionFix01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPositionFix01 : TriggerState {
            internal StatePCPositionFix01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 604, arg2: true);
                context.MoveUser(arg1: 52000070, arg2: 10, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePCPositionFix02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCPositionFix02 : TriggerState {
            internal StatePCPositionFix02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFriendNpcWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcWalkIn01 : TriggerState {
            internal StateFriendNpcWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201, 202, 203, 204}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFriendNpcWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcWalkIn02 : TriggerState {
            internal StateFriendNpcWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
                context.CameraSelect(arg1: 605, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateFriendNpcTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk01 : TriggerState {
            internal StateFriendNpcTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001964, arg3: "$52000070_QD__TRAP01__2$", arg4: 4);
                context.SetSkip(arg1: "FriendNpcTalk01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFriendNpcTalk01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk01Skip : TriggerState {
            internal StateFriendNpcTalk01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFriendNpcTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk02 : TriggerState {
            internal StateFriendNpcTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001964, arg3: "$52000070_QD__TRAP01__3$", arg4: 4);
                context.SetSkip(arg1: "FriendNpcTalk02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFriendNpcTalk02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFriendNpcTalk02Skip : TriggerState {
            internal StateFriendNpcTalk02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWayOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWayOpen01 : TriggerState {
            internal StateWayOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_211");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_212");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWayOpen02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWayOpen02 : TriggerState {
            internal StateWayOpen02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_213");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_214");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWayOpen03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWayOpen03 : TriggerState {
            internal StateWayOpen03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$52000070_QD__TRAP01__4$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestCom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestCom : TriggerState {
            internal StateQuestCom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 9900, arg2: "trigger", arg3: "remnantssweeping");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {40002677},
                    arg3: new byte[] {2})) {
                    context.State = new StateMoveToComplete(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToComplete : TriggerState {
            internal StateMoveToComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.MoveUser(arg1: 02000208, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
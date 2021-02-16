using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100002_qd {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateQuest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100060}, arg3: new byte[] {1})) {
                    return new StateRoomCheck(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100060}, arg3: new byte[] {2})) {
                    return new StateQuest완료가능이거나완료1(context);
                }

                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {50100060}, arg3: new byte[] {3})) {
                    return new StateQuest완료가능이거나완료1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonInit(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestDungeonInit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    return new StateDead체크(context);
                }

                if (context.MonsterDead(arg1: new[] {2001, 2002})) {
                    return new StateDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDead체크 : TriggerState {
            internal StateDead체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001, 2002})) {
                    return new StateDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDeadDelay : TriggerState {
            internal StateDeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEnd체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd체크 : TriggerState {
            internal StateEnd체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2001, 2002})) {
                    return new State암전Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDungeonInit : TriggerState {
            internal StateQuestDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001, 1002, 2101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {2101})) {
                    context.SetEffect(arg1: new[] {601}, arg2: true);
                    return new StateQuestDead체크(context);
                }

                if (context.MonsterDead(arg1: new[] {2101, 2102})) {
                    return new StateQuestDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDead체크 : TriggerState {
            internal StateQuestDead체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2101, 2102})) {
                    return new StateQuestDeadDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestDeadDelay : TriggerState {
            internal StateQuestDeadDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateQuest종료체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest종료체크 : TriggerState {
            internal StateQuest종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2101, 2102})) {
                    return new State암전Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전Wait : TriggerState {
            internal State암전Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEndCinematicWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematicWait : TriggerState {
            internal StateEndCinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 301, arg2: true);
                context.MoveUser(arg1: 52100002, arg2: 2);
                context.DestroyMonster(arg1: new[] {1001, 1002, 2001, 2002, 2101, 2102});
                context.CreateMonster(arg1: new[] {1098, 1099}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 1098, arg2: "Dead_B", arg3: 3000000f);
                context.SetNpcEmotionLoop(arg1: 1099, arg2: "Dead_B", arg3: 3000000f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEndCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndCinematic : TriggerState {
            internal StateEndCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateStopCinematic(context));
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", script: "$02000392_BF__MAIN__0$", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", script: "$02000392_BF__MAIN__1$", align: Align.Right, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StatePC대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대사 : TriggerState {
            internal StatePC대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$02000392_BF__MAIN__2$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePCScript2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript2 : TriggerState {
            internal StatePCScript2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$02000392_BF__MAIN__10$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State자매교체(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매교체 : TriggerState {
            internal State자매교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1098, 1099});
                context.CreateMonster(arg1: new[] {1096, 1097}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State자매대화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화 : TriggerState {
            internal State자매대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 302, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State자매대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화01 : TriggerState {
            internal State자매대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", script: "$02000392_BF__MAIN__3$", align: Align.Left, duration: 4000);
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", script: "$02000392_BF__MAIN__4$", align: Align.Right, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State자매대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화02 : TriggerState {
            internal State자매대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", script: "$02000392_BF__MAIN__5$", align: Align.Left, duration: 5000);
                context.SetConversation(arg1: 1, arg2: 1097, script: "$02000392_BF__MAIN__6$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State자매대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화03 : TriggerState {
            internal State자매대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", script: "$02000392_BF__MAIN__11$", align: Align.Left, duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCScript3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCScript3 : TriggerState {
            internal StatePCScript3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 0, script: "$02000392_BF__MAIN__12$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화04 : TriggerState {
            internal State자매대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", script: "$02000392_BF__MAIN__7$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화05 : TriggerState {
            internal State자매대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", script: "$02000392_BF__MAIN__8$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State자매대화06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State자매대화06 : TriggerState {
            internal State자매대화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", script: "$02000392_BF__MAIN__9$", align: Align.Left, duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.DestroyMonster(arg1: new[] {1098, 1099, 1096, 1097});
                context.CreateMonster(arg1: new[] {1096, 1097}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRoomCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료가능이거나완료1 : TriggerState {
            internal StateQuest완료가능이거나완료1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1096, 1097}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateRoomCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck2 : TriggerState {
            internal StateRoomCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonComplete(context);
                }

                if (!context.IsDungeonRoom()) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonComplete : TriggerState {
            internal StateDungeonComplete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ClearSirenSisters");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
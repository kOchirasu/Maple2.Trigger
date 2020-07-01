using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000066_bf {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 6003}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new[] {99}, arg2: false);
                context.SetMesh(arg1: new[] {9001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonMaxUserCount() == 4) {
                    return new State연출시작(context);
                }

                if (context.GetDungeonMaxUserCount() == 3) {
                    context.SetUserValue(triggerId: 9995001, key: "randomTalk", value: 1);
                    return new State연출시작(context);
                }

                if (context.GetDungeonMaxUserCount() == 2) {
                    context.SetUserValue(triggerId: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995003, key: "randomTalk", value: 1);
                    return new State연출시작(context);
                }

                if (context.GetDungeonMaxUserCount() == 1) {
                    context.SetUserValue(triggerId: 9995001, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995003, key: "randomTalk", value: 1);
                    return new State연출시작(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 9995001, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995003, key: "randomTalk", value: 1);
                    return new State연출시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSkip(arg1: "1차어나운스03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1차어나운스01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차어나운스01 : TriggerState {
            internal State1차어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg2: true);
                context.AddCinematicTalk(npcId: 11000032, illustId: "Anos_serious", msg: "$02000066_BF__MAIN__4$", duration: 5000, align: "center");
                context.SetSkip(arg1: "1차어나운스03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State1차어나운스02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차어나운스02 : TriggerState {
            internal State1차어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11000032, illustId: "Anos_serious", msg: "$02000066_BF__MAIN__5$", duration: 5000, align: "center");
                context.SetSkip(arg1: "1차어나운스03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State1차어나운스03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차어나운스03 : TriggerState {
            internal State1차어나운스03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.CameraSelect(arg1: 300, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEventUI(arg1: 0, arg2: "1,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__6$", stage: 1, count: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State1차웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브 : TriggerState {
            internal State1차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120, arg3: false, arg4: true, arg5: 0);
                context.CreateMonster(arg1: new[] {900}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    return new State1차웨이브성공(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State1차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1299, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1401, 1402, 1403, 1404, 1601, 1602, 1603, 1604});
            }
        }

        private class State1차웨이브실패 : TriggerState {
            internal State1차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {613}, arg2: true);
                context.SetEventUI(arg1: 5, arg2: "$02000066_BF__MAIN__7$", arg3: 3000, arg4: "0");
                context.DestroyMonster(arg1: new[] {900});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브성공 : TriggerState {
            internal State1차웨이브성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000662, textId: 20000662);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new[] {900});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2차어나운스01(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State1차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20000662);
            }
        }

        private class State2차어나운스01 : TriggerState {
            internal State2차어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000665, textId: 20000665, duration: 7000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State2차어나운스02(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State1차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20000665);
            }
        }

        private class State2차어나운스02 : TriggerState {
            internal State2차어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__10$", stage: 2, count: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State2차웨이브(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State1차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브 : TriggerState {
            internal State2차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120, arg3: false, arg4: true);
                context.CreateMonster(arg1: new[] {901}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    return new State2차웨이브성공(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State2차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1299, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1401, 1402, 1403, 1404, 1601, 1602, 1603, 1604});
            }
        }

        private class State2차웨이브실패 : TriggerState {
            internal State2차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$02000066_BF__MAIN__11$", arg3: 3000, arg4: "0");
                context.DestroyMonster(arg1: new[] {901});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브성공 : TriggerState {
            internal State2차웨이브성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000662, textId: 20000662);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new[] {901});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State2차웨이브실패(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State3차어나운스01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20000662);
            }
        }

        private class State3차어나운스01 : TriggerState {
            internal State3차어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000665, textId: 20000665, duration: 7000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State2차웨이브실패(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new State3차어나운스02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20000665);
            }
        }

        private class State3차어나운스02 : TriggerState {
            internal State3차어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__14$", stage: 3, count: 5);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State2차웨이브실패(context);
                }

                if (context.WaitTick(waitTick: 6000)) {
                    return new State3차웨이브(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브 : TriggerState {
            internal State3차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120, arg3: false, arg4: true);
                context.CreateMonster(arg1: new[] {902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    return new State3차웨이브성공(context);
                }

                if (context.MonsterDead(arg1: new[] {99})) {
                    return new State3차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1299, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1401, 1402, 1403, 1404, 1601, 1602, 1603, 1604});
            }
        }

        private class State3차웨이브실패 : TriggerState {
            internal State3차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$02000066_BF__MAIN__15$", arg3: 3000, arg4: "0");
                context.DestroyMonster(arg1: new[] {902});
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브성공 : TriggerState {
            internal State3차웨이브성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$02000066_BF__MAIN__33$", arg3: 3000, arg4: "0");
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.ShowGuideSummary(entityId: 20000662, textId: 20000662);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "EdgeofSpirits");
                context.DestroyMonster(arg1: new[] {902});
                context.SetMesh(arg1: new[] {9001}, arg2: false);
                context.DestroyMonster(arg1: new[] {99});
                context.SetNpcEmotionLoop(arg1: 99, arg2: "Attack_Idle_A", arg3: 999999999999f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetEffect(arg1: new[] {6003}, arg2: false);
                    return new State3차승리연출랜덤(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20000662);
            }
        }

        private class State3차승리연출랜덤 : TriggerState {
            internal State3차승리연출랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State3차승리연출01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3차승리연출02(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3차승리연출03(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3차승리연출04(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3차승리연출05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리연출01 : TriggerState {
            internal State3차승리연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__17$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3차승리연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리연출02 : TriggerState {
            internal State3차승리연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__18$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3차승리연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리연출03 : TriggerState {
            internal State3차승리연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__19$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3차승리연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리연출04 : TriggerState {
            internal State3차승리연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__20$", arg4: 5);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3차승리연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리연출05 : TriggerState {
            internal State3차승리연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__21$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5982)) {
                    return new State3차승리연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리연출종료 : TriggerState {
            internal State3차승리연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State분기점(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "ClearAnosSOS");
            }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {612}, arg2: true);
                context.DungeonClear();
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "ClearLifeForest");
                context.SetUserValue(triggerId: 10003067, key: "woodsoflife", value: 1);
                context.CreateMonster(arg1: new[] {907}, arg2: false);
                context.MoveUser(arg1: 02000066, arg2: 3, arg3: 103);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.ShowGuideSummary(entityId: 20000666, textId: 20000666);
                    context.SetEffect(arg1: new[] {620}, arg2: true);
                    context.DestroyMonster(arg1: new[] {907});
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "woodsoflife", value: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    return new State실패연출01(context);
                }

                if (context.RandomCondition(arg1: 15f)) {
                    return new State실패연출02(context);
                }

                if (context.RandomCondition(arg1: 14f)) {
                    return new State실패연출03(context);
                }

                if (context.RandomCondition(arg1: 14f)) {
                    return new State실패연출04(context);
                }

                if (context.RandomCondition(arg1: 14f)) {
                    return new State실패연출05(context);
                }

                if (context.RandomCondition(arg1: 14f)) {
                    return new State실패연출06(context);
                }

                if (context.RandomCondition(arg1: 14f)) {
                    return new State실패연출07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출01 : TriggerState {
            internal State실패연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__40$", arg4: 3);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출02 : TriggerState {
            internal State실패연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__41$", arg4: 3);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출03 : TriggerState {
            internal State실패연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__42$", arg4: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출04 : TriggerState {
            internal State실패연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__43$", arg4: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출05 : TriggerState {
            internal State실패연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__44$", arg4: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출06 : TriggerState {
            internal State실패연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__45$", arg4: 6);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출07 : TriggerState {
            internal State실패연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__46$", arg4: 4);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new State실패연출종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패연출종료 : TriggerState {
            internal State실패연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State실패강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패강제이동 : TriggerState {
            internal State실패강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000066_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {602}, arg2: false);
                context.SetEffect(arg1: new int[] {603}, arg2: false);
                context.SetEffect(arg1: new int[] {604}, arg2: false);
                context.SetEffect(arg1: new int[] {605}, arg2: false);
                context.SetEffect(arg1: new int[] {606}, arg2: false);
                context.SetEffect(arg1: new int[] {607}, arg2: false);
                context.SetEffect(arg1: new int[] {608}, arg2: false);
                context.SetEffect(arg1: new int[] {609}, arg2: false);
                context.SetEffect(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {611}, arg2: false);
                context.SetEffect(arg1: new int[] {612}, arg2: false);
                context.SetEffect(arg1: new int[] {613}, arg2: false);
                context.SetEffect(arg1: new int[] {614}, arg2: false);
                context.SetEffect(arg1: new int[] {615}, arg2: false);
                context.SetEffect(arg1: new int[] {616}, arg2: false);
                context.SetEffect(arg1: new int[] {617}, arg2: false);
                context.SetEffect(arg1: new int[] {618}, arg2: false);
                context.SetEffect(arg1: new int[] {619}, arg2: false);
                context.SetEffect(arg1: new int[] {620}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {99}, arg2: false);
                context.SetMesh(arg1: new int[] {9001}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.DungeonMaxUserCount(value: 4)) {
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.DungeonMaxUserCount(value: 3)) {
                    context.SetUserValue(triggerID: 9995001, key: "randomTalk", value: 1);
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.DungeonMaxUserCount(value: 2)) {
                    context.SetUserValue(triggerID: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerID: 9995003, key: "randomTalk", value: 1);
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.DungeonMaxUserCount(value: 1)) {
                    context.SetUserValue(triggerID: 9995001, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerID: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerID: 9995003, key: "randomTalk", value: 1);
                    context.State = new State연출시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 9995001, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerID: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerID: 9995003, key: "randomTalk", value: 1);
                    context.State = new State연출시작(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1차어나운스01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차어나운스01 : TriggerState {
            internal State1차어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg2: true);
                context.AddCinematicTalk(npcID: 11000032, illustID: "Anos_serious", msg: "$02000066_BF__MAIN__4$",
                    duration: 5000, align: "center");
                context.SetSkip(arg1: "1차어나운스03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State1차어나운스02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차어나운스02 : TriggerState {
            internal State1차어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11000032, illustID: "Anos_serious", msg: "$02000066_BF__MAIN__5$",
                    duration: 5000, align: "center");
                context.SetSkip(arg1: "1차어나운스03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State1차어나운스03(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State1차웨이브(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차웨이브 : TriggerState {
            internal State1차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120, arg3: false, arg4: true, arg5: 0);
                context.CreateMonster(arg1: new int[] {900}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.State = new State1차웨이브성공(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State1차웨이브실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {1001});
                context.DestroyMonster(arg1: new int[] {1002});
                context.DestroyMonster(arg1: new int[] {1003});
                context.DestroyMonster(arg1: new int[] {1004});
                context.DestroyMonster(arg1: new int[] {1005});
                context.DestroyMonster(arg1: new int[] {1006});
                context.DestroyMonster(arg1: new int[] {1007});
                context.DestroyMonster(arg1: new int[] {1008});
                context.DestroyMonster(arg1: new int[] {1101});
                context.DestroyMonster(arg1: new int[] {1102});
                context.DestroyMonster(arg1: new int[] {1103});
                context.DestroyMonster(arg1: new int[] {1104});
                context.DestroyMonster(arg1: new int[] {1105});
                context.DestroyMonster(arg1: new int[] {1106});
                context.DestroyMonster(arg1: new int[] {1107});
                context.DestroyMonster(arg1: new int[] {1108});
                context.DestroyMonster(arg1: new int[] {1201});
                context.DestroyMonster(arg1: new int[] {1202});
                context.DestroyMonster(arg1: new int[] {1203});
                context.DestroyMonster(arg1: new int[] {1204});
                context.DestroyMonster(arg1: new int[] {1205});
                context.DestroyMonster(arg1: new int[] {1206});
                context.DestroyMonster(arg1: new int[] {1207});
                context.DestroyMonster(arg1: new int[] {1208});
                context.DestroyMonster(arg1: new int[] {1299});
                context.DestroyMonster(arg1: new int[] {1301});
                context.DestroyMonster(arg1: new int[] {1302});
                context.DestroyMonster(arg1: new int[] {1303});
                context.DestroyMonster(arg1: new int[] {1304});
                context.DestroyMonster(arg1: new int[] {1305});
                context.DestroyMonster(arg1: new int[] {1306});
                context.DestroyMonster(arg1: new int[] {1307});
                context.DestroyMonster(arg1: new int[] {1308});
                context.DestroyMonster(arg1: new int[] {1401});
                context.DestroyMonster(arg1: new int[] {1402});
                context.DestroyMonster(arg1: new int[] {1403});
                context.DestroyMonster(arg1: new int[] {1404});
                context.DestroyMonster(arg1: new int[] {1601});
                context.DestroyMonster(arg1: new int[] {1602});
                context.DestroyMonster(arg1: new int[] {1603});
                context.DestroyMonster(arg1: new int[] {1604});
            }
        }

        private class State1차웨이브실패 : TriggerState {
            internal State1차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {613}, arg2: true);
                context.SetEventUI(arg1: 5, arg2: "$02000066_BF__MAIN__7$", arg3: new int[] {3000}, arg4: "0");
                context.DestroyMonster(arg1: new int[] {900});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차웨이브성공 : TriggerState {
            internal State1차웨이브성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20000662, textID: 20000662);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new int[] {900});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2차어나운스01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State1차웨이브실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20000662);
            }
        }

        private class State2차어나운스01 : TriggerState {
            internal State2차어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20000665, textID: 20000665, duration: 7000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State2차어나운스02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State1차웨이브실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20000665);
            }
        }

        private class State2차어나운스02 : TriggerState {
            internal State2차어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "2,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__10$", stage: 2, count: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State2차웨이브(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State1차웨이브실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브 : TriggerState {
            internal State2차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120, arg3: false, arg4: true);
                context.CreateMonster(arg1: new int[] {901}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.State = new State2차웨이브성공(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State2차웨이브실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {1001});
                context.DestroyMonster(arg1: new int[] {1002});
                context.DestroyMonster(arg1: new int[] {1003});
                context.DestroyMonster(arg1: new int[] {1004});
                context.DestroyMonster(arg1: new int[] {1005});
                context.DestroyMonster(arg1: new int[] {1006});
                context.DestroyMonster(arg1: new int[] {1007});
                context.DestroyMonster(arg1: new int[] {1008});
                context.DestroyMonster(arg1: new int[] {1101});
                context.DestroyMonster(arg1: new int[] {1102});
                context.DestroyMonster(arg1: new int[] {1103});
                context.DestroyMonster(arg1: new int[] {1104});
                context.DestroyMonster(arg1: new int[] {1105});
                context.DestroyMonster(arg1: new int[] {1106});
                context.DestroyMonster(arg1: new int[] {1107});
                context.DestroyMonster(arg1: new int[] {1108});
                context.DestroyMonster(arg1: new int[] {1201});
                context.DestroyMonster(arg1: new int[] {1202});
                context.DestroyMonster(arg1: new int[] {1203});
                context.DestroyMonster(arg1: new int[] {1204});
                context.DestroyMonster(arg1: new int[] {1205});
                context.DestroyMonster(arg1: new int[] {1206});
                context.DestroyMonster(arg1: new int[] {1207});
                context.DestroyMonster(arg1: new int[] {1208});
                context.DestroyMonster(arg1: new int[] {1299});
                context.DestroyMonster(arg1: new int[] {1301});
                context.DestroyMonster(arg1: new int[] {1302});
                context.DestroyMonster(arg1: new int[] {1303});
                context.DestroyMonster(arg1: new int[] {1304});
                context.DestroyMonster(arg1: new int[] {1305});
                context.DestroyMonster(arg1: new int[] {1306});
                context.DestroyMonster(arg1: new int[] {1307});
                context.DestroyMonster(arg1: new int[] {1308});
                context.DestroyMonster(arg1: new int[] {1401});
                context.DestroyMonster(arg1: new int[] {1402});
                context.DestroyMonster(arg1: new int[] {1403});
                context.DestroyMonster(arg1: new int[] {1404});
                context.DestroyMonster(arg1: new int[] {1601});
                context.DestroyMonster(arg1: new int[] {1602});
                context.DestroyMonster(arg1: new int[] {1603});
                context.DestroyMonster(arg1: new int[] {1604});
            }
        }

        private class State2차웨이브실패 : TriggerState {
            internal State2차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$02000066_BF__MAIN__11$", arg3: new int[] {3000}, arg4: "0");
                context.DestroyMonster(arg1: new int[] {901});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차웨이브성공 : TriggerState {
            internal State2차웨이브성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20000662, textID: 20000662);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.DestroyMonster(arg1: new int[] {901});
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State2차웨이브실패(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3차어나운스01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20000662);
            }
        }

        private class State3차어나운스01 : TriggerState {
            internal State3차어나운스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20000665, textID: 20000665, duration: 7000);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State2차웨이브실패(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State3차어나운스02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20000665);
            }
        }

        private class State3차어나운스02 : TriggerState {
            internal State3차어나운스02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 0, arg2: "3,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__14$", stage: 3, count: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State2차웨이브실패(context);
                    return;
                }

                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State3차웨이브(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차웨이브 : TriggerState {
            internal State3차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120, arg3: false, arg4: true);
                context.CreateMonster(arg1: new int[] {902}, arg2: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    context.State = new State3차웨이브성공(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {99})) {
                    context.State = new State3차웨이브실패(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {1001});
                context.DestroyMonster(arg1: new int[] {1002});
                context.DestroyMonster(arg1: new int[] {1003});
                context.DestroyMonster(arg1: new int[] {1004});
                context.DestroyMonster(arg1: new int[] {1005});
                context.DestroyMonster(arg1: new int[] {1006});
                context.DestroyMonster(arg1: new int[] {1007});
                context.DestroyMonster(arg1: new int[] {1008});
                context.DestroyMonster(arg1: new int[] {1101});
                context.DestroyMonster(arg1: new int[] {1102});
                context.DestroyMonster(arg1: new int[] {1103});
                context.DestroyMonster(arg1: new int[] {1104});
                context.DestroyMonster(arg1: new int[] {1105});
                context.DestroyMonster(arg1: new int[] {1106});
                context.DestroyMonster(arg1: new int[] {1107});
                context.DestroyMonster(arg1: new int[] {1108});
                context.DestroyMonster(arg1: new int[] {1201});
                context.DestroyMonster(arg1: new int[] {1202});
                context.DestroyMonster(arg1: new int[] {1203});
                context.DestroyMonster(arg1: new int[] {1204});
                context.DestroyMonster(arg1: new int[] {1205});
                context.DestroyMonster(arg1: new int[] {1206});
                context.DestroyMonster(arg1: new int[] {1207});
                context.DestroyMonster(arg1: new int[] {1208});
                context.DestroyMonster(arg1: new int[] {1299});
                context.DestroyMonster(arg1: new int[] {1301});
                context.DestroyMonster(arg1: new int[] {1302});
                context.DestroyMonster(arg1: new int[] {1303});
                context.DestroyMonster(arg1: new int[] {1304});
                context.DestroyMonster(arg1: new int[] {1305});
                context.DestroyMonster(arg1: new int[] {1306});
                context.DestroyMonster(arg1: new int[] {1307});
                context.DestroyMonster(arg1: new int[] {1308});
                context.DestroyMonster(arg1: new int[] {1401});
                context.DestroyMonster(arg1: new int[] {1402});
                context.DestroyMonster(arg1: new int[] {1403});
                context.DestroyMonster(arg1: new int[] {1404});
                context.DestroyMonster(arg1: new int[] {1601});
                context.DestroyMonster(arg1: new int[] {1602});
                context.DestroyMonster(arg1: new int[] {1603});
                context.DestroyMonster(arg1: new int[] {1604});
            }
        }

        private class State3차웨이브실패 : TriggerState {
            internal State3차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, arg2: "$02000066_BF__MAIN__15$", arg3: new int[] {3000}, arg4: "0");
                context.DestroyMonster(arg1: new int[] {902});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차웨이브성공 : TriggerState {
            internal State3차웨이브성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$02000066_BF__MAIN__33$", arg3: new int[] {3000}, arg4: "0");
                context.SetEventUI(arg1: 0, arg2: "0,0");
                context.SetEffect(arg1: new int[] {6003}, arg2: true);
                context.ShowGuideSummary(entityID: 20000662, textID: 20000662);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "EdgeofSpirits");
                context.DestroyMonster(arg1: new int[] {902});
                context.SetMesh(arg1: new int[] {9001}, arg2: false);
                context.DestroyMonster(arg1: new int[] {99});
                context.SetNpcEmotionLoop(arg1: 99, arg2: "Attack_Idle_A", arg3: 999999999999f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetEffect(arg1: new int[] {6003}, arg2: false);
                    context.State = new State3차승리연출랜덤(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20000662);
            }
        }

        private class State3차승리연출랜덤 : TriggerState {
            internal State3차승리연출랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3차승리연출01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3차승리연출02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3차승리연출03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3차승리연출04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3차승리연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차승리연출01 : TriggerState {
            internal State3차승리연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__17$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State3차승리연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차승리연출02 : TriggerState {
            internal State3차승리연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__18$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State3차승리연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차승리연출03 : TriggerState {
            internal State3차승리연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__19$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3차승리연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차승리연출04 : TriggerState {
            internal State3차승리연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__20$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State3차승리연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차승리연출05 : TriggerState {
            internal State3차승리연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__21$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5982)) {
                    context.State = new State3차승리연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차승리연출종료 : TriggerState {
            internal State3차승리연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State분기점(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "ClearAnosSOS");
            }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {612}, arg2: true);
                context.DungeonClear();
                context.SetAchievement(arg1: 103, arg2: "trigger", arg3: "ClearLifeForest");
                context.SetUserValue(triggerID: 10003067, key: "woodsoflife", value: 1);
                context.CreateMonster(arg1: new int[] {907}, arg2: false);
                context.MoveUser(arg1: 02000066, arg2: 3, arg3: 103);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.ShowGuideSummary(entityID: 20000666, textID: 20000666);
                    context.SetEffect(arg1: new int[] {620}, arg2: true);
                    context.DestroyMonster(arg1: new int[] {907});
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "woodsoflife", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new State실패연출01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 15f)) {
                    context.State = new State실패연출02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new State실패연출03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new State실패연출04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new State실패연출05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new State실패연출06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 14f)) {
                    context.State = new State실패연출07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출01 : TriggerState {
            internal State실패연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__40$", arg4: 3);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출02 : TriggerState {
            internal State실패연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__41$", arg4: 3);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출03 : TriggerState {
            internal State실패연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__42$", arg4: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출04 : TriggerState {
            internal State실패연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__43$", arg4: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출05 : TriggerState {
            internal State실패연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__44$", arg4: 5);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출06 : TriggerState {
            internal State실패연출06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__45$", arg4: 6);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패연출07 : TriggerState {
            internal State실패연출07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000068, arg3: "$02000066_BF__MAIN__46$", arg4: 4);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State실패연출종료(context);
                    return;
                }
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

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State실패강제이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State실패강제이동 : TriggerState {
            internal State실패강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.MoveUser(arg1: 0, arg2: 0);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
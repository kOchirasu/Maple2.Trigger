using System;
using Maple2.Trigger._dungeon_common;
using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000066_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{602, 603, 604, 605, 606, 607, 608, 609, 610, 611, 612, 613, 614, 615, 616, 617, 618, 619, 620, 6003}, visible: false);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{99}, arg2: false);
                context.SetMesh(triggerIds: new []{9001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonMaxUserCount() == 4) {
                    return new StateStartCinematic(context);
                }

                if (context.GetDungeonMaxUserCount() == 3) {
                    context.SetUserValue(triggerId: 9995001, key: "randomTalk", value: 1);
                    return new StateStartCinematic(context);
                }

                if (context.GetDungeonMaxUserCount() == 2) {
                    context.SetUserValue(triggerId: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995003, key: "randomTalk", value: 1);
                    return new StateStartCinematic(context);
                }

                if (context.GetDungeonMaxUserCount() == 1) {
                    context.SetUserValue(triggerId: 9995001, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995003, key: "randomTalk", value: 1);
                    return new StateStartCinematic(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 9995001, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995002, key: "randomTalk", value: 1);
                    context.SetUserValue(triggerId: 9995003, key: "randomTalk", value: 1);
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 300, enable: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSkip(state: new State1차어나운스03(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: Array.Empty<int>(), visible: true);
                context.AddCinematicTalk(npcId: 11000032, illustId: "Anos_serious", script: "$02000066_BF__MAIN__4$", duration: 5000, align: Align.Center);
                context.SetSkip(state: new State1차어나운스03(context));
            }

            public override TriggerState? Execute() {
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
                context.AddCinematicTalk(npcId: 11000032, illustId: "Anos_serious", script: "$02000066_BF__MAIN__5$", duration: 5000, align: Align.Center);
                context.SetSkip(state: new State1차어나운스03(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 300, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEventUI(arg1: 0, script: "1,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__6$", stage: 1, count: 5);
            }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "120", seconds: 120, clearAtZero: false, display: true, arg5: 0);
                context.CreateMonster(spawnIds: new []{900}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "120")) {
                    return new State1차웨이브Success(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State1차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1299, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1401, 1402, 1403, 1404, 1601, 1602, 1603, 1604});
            }
        }

        private class State1차웨이브실패 : TriggerState {
            internal State1차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{613}, visible: true);
                context.SetEventUI(arg1: 5, script: "$02000066_BF__MAIN__7$", duration: 3000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{900});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차웨이브Success : TriggerState {
            internal State1차웨이브Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000662, textId: 20000662);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.DestroyMonster(spawnIds: new []{900});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2차어나운스01(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State2차어나운스02(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
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
                context.SetEventUI(arg1: 0, script: "2,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__10$", stage: 2, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State2차웨이브(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State1차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브 : TriggerState {
            internal State2차웨이브(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "120", seconds: 120, clearAtZero: false, display: true);
                context.CreateMonster(spawnIds: new []{901}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "120")) {
                    return new State2차웨이브Success(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State2차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1299, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1401, 1402, 1403, 1404, 1601, 1602, 1603, 1604});
            }
        }

        private class State2차웨이브실패 : TriggerState {
            internal State2차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, script: "$02000066_BF__MAIN__11$", duration: 3000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{901});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차웨이브Success : TriggerState {
            internal State2차웨이브Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20000662, textId: 20000662);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.DestroyMonster(spawnIds: new []{901});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
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
                context.SetEventUI(arg1: 0, script: "3,3");
                context.ShowCountUI(text: "$02000066_BF__MAIN__14$", stage: 3, count: 5);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
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
                context.SetTimer(timerId: "120", seconds: 120, clearAtZero: false, display: true);
                context.CreateMonster(spawnIds: new []{902}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "120")) {
                    return new State3차웨이브Success(context);
                }

                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new State3차웨이브실패(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1299, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1401, 1402, 1403, 1404, 1601, 1602, 1603, 1604});
            }
        }

        private class State3차웨이브실패 : TriggerState {
            internal State3차웨이브실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 5, script: "$02000066_BF__MAIN__15$", duration: 3000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{902});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차웨이브Success : TriggerState {
            internal State3차웨이브Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, script: "$02000066_BF__MAIN__33$", duration: 3000, boxId: 0);
                context.SetEventUI(arg1: 0, script: "0,0");
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.ShowGuideSummary(entityId: 20000662, textId: 20000662);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetAchievement(triggerId: 103, type: "trigger", code: "EdgeofSpirits");
                context.DestroyMonster(spawnIds: new []{902});
                context.SetMesh(triggerIds: new []{9001}, visible: false);
                context.DestroyMonster(spawnIds: new []{99});
                context.SetNpcEmotionLoop(spawnId: 99, sequenceName: "Attack_Idle_A", duration: 999999999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.SetEffect(triggerIds: new []{6003}, visible: false);
                    return new State3차승리CinematicRandom(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20000662);
            }
        }

        private class State3차승리CinematicRandom : TriggerState {
            internal State3차승리CinematicRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20f)) {
                    return new State3차승리Cinematic01(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3차승리Cinematic02(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3차승리Cinematic03(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3차승리Cinematic04(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3차승리Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리Cinematic01 : TriggerState {
            internal State3차승리Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__17$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3차승리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리Cinematic02 : TriggerState {
            internal State3차승리Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__18$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3차승리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리Cinematic03 : TriggerState {
            internal State3차승리Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__19$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3차승리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리Cinematic04 : TriggerState {
            internal State3차승리Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__20$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3차승리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리Cinematic05 : TriggerState {
            internal State3차승리Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__21$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5982)) {
                    return new State3차승리StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차승리StopCinematic : TriggerState {
            internal State3차승리StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State분기점(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(triggerId: 103, type: "trigger", code: "ClearAnosSOS");
            }
        }

        private class State분기점 : TriggerState {
            internal State분기점(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{612}, visible: true);
                context.DungeonClear();
                context.SetAchievement(triggerId: 103, type: "trigger", code: "ClearLifeForest");
                context.SetUserValue(triggerId: 10003067, key: "woodsoflife", value: 1);
                context.CreateMonster(spawnIds: new []{907}, arg2: false);
                context.MoveUser(mapId: 02000066, portalId: 3, boxId: 103);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.ShowGuideSummary(entityId: 20000666, textId: 20000666);
                    context.SetEffect(triggerIds: new []{620}, visible: true);
                    context.DestroyMonster(spawnIds: new []{907});
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State실패 : TriggerState {
            internal State실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 15f)) {
                    return new State실패Cinematic01(context);
                }

                if (context.RandomCondition(rate: 15f)) {
                    return new State실패Cinematic02(context);
                }

                if (context.RandomCondition(rate: 14f)) {
                    return new State실패Cinematic03(context);
                }

                if (context.RandomCondition(rate: 14f)) {
                    return new State실패Cinematic04(context);
                }

                if (context.RandomCondition(rate: 14f)) {
                    return new State실패Cinematic05(context);
                }

                if (context.RandomCondition(rate: 14f)) {
                    return new State실패Cinematic06(context);
                }

                if (context.RandomCondition(rate: 14f)) {
                    return new State실패Cinematic07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic01 : TriggerState {
            internal State실패Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__40$", arg4: 3);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic02 : TriggerState {
            internal State실패Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__41$", arg4: 3);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic03 : TriggerState {
            internal State실패Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__42$", arg4: 5);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic04 : TriggerState {
            internal State실패Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__43$", arg4: 5);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic05 : TriggerState {
            internal State실패Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__44$", arg4: 5);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic06 : TriggerState {
            internal State실패Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__45$", arg4: 6);
                context.SetTimer(timerId: "7", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패Cinematic07 : TriggerState {
            internal State실패Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000068, script: "$02000066_BF__MAIN__46$", arg4: 4);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new State실패StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패StopCinematic : TriggerState {
            internal State실패StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State실패강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State실패강제이동 : TriggerState {
            internal State실패강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    context.MoveUser(mapId: 0, portalId: 0);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

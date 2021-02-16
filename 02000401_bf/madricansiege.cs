using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000401_bf {
    public static class _madricansiege {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006, 8101, 8102, 8103, 8104, 8105, 8106, 8201, 8202, 8203, 8204, 8205, 8206}, arg2: true);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3101, 3102, 3103, 3104, 3105, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3801, 3802, 3803, 3804}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 2000, 2001}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(arg1: 201, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 202, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 203, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 204, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 205, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 206, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 207, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 208, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 209, arg2: false, arg3: "Dead_A");
                context.SetActor(arg1: 210, arg2: false, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateStopCinematic(context));
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 2, arg2: 11000015, script: "$02000401_BF__MADRICANSIEGE__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraSelect(arg1: 300, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDungeonInit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonInit : TriggerState {
            internal StateDungeonInit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAgent(arg1: new[] {8001, 8002, 8003, 8004, 8005, 8006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 1001, script: "$02000401_BF__MADRICANSIEGE__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2000, 2001})) {
                    context.SetMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.SetAgent(arg1: new[] {8101, 8102, 8103, 8104, 8105, 8106}, arg2: false);
                    context.MoveNpc(arg1: 1102, arg2: "MS2PatrolData_1001A");
                    return new State1차지원(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차지원 : TriggerState {
            internal State1차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030}, isAutoTargeting: false);
                context.CreateMonster(arg1: new[] {2002, 2003, 2004, 2005}, arg2: false);
                context.SetUserValue(triggerId: 99999101, key: "cannon01", value: 1);
                context.SetUserValue(triggerId: 99999099, key: "faction01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2901})) {
                    context.DestroyMonster(arg1: new[] {2002});
                    context.ShadowExpeditionOpenBossGauge(maxGaugePoint: 1000);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1300)) {
                    return new State다리건넘(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건넘 : TriggerState {
            internal State다리건넘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {8201, 8202, 8203, 8204, 8205, 8206}, arg2: false);
                context.SetMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetUserValue(triggerId: 99999102, key: "cannon02", value: 1);
                context.SetUserValue(triggerId: 99999103, key: "cannon03", value: 1);
                context.SetUserValue(triggerId: 99999104, key: "cannon04", value: 1);
                context.SetUserValue(triggerId: 99999105, key: "cannon05", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetShadowExpeditionPoints() >= 300) {
                    return new State2차지원(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차지원 : TriggerState {
            internal State2차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99999098, key: "faction02", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetShadowExpeditionPoints() >= 600) {
                    return new State3차지원(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차지원 : TriggerState {
            internal State3차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2031, 2032, 2033, 2034, 2035, 2036}, arg2: false);
                context.SetUserValue(triggerId: 99999097, key: "faction03", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetShadowExpeditionPoints() >= 1000) {
                    context.ShadowExpeditionCloseBossGauge();
                    return new StateBossSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawn : TriggerState {
            internal StateBossSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2026, 2027, 2028, 2029, 2030}, arg2: false);
                context.SetUserValue(triggerId: 99999096, key: "faction04", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "bossSpawn") == 1) {
                    return new State던전종료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료Wait : TriggerState {
            internal State던전종료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2099})) {
                    return new State던전종료Delay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료Delay : TriggerState {
            internal State던전종료Delay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 201, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 202, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 203, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 204, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 205, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 206, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 207, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 208, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 209, arg2: true, arg3: "Dead_A");
                context.SetActor(arg1: 210, arg2: true, arg3: "Dead_A");
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(arg1: 02000401, arg2: 3);
                context.SetUserValue(triggerId: 99999099, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999098, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999097, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerId: 99999096, key: "DungeonClear", value: 1);
                context.DestroyMonster(arg1: new[] {2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033, 2034, 2035, 2036, 2099, 2901, 2902, 2903, 2904, 2905}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1918, 1919}, isAutoTargeting: false);
                context.SetPortal(portalId: 2, visible: true, enabled: false, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State던전종료StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료StartCinematic : TriggerState {
            internal State던전종료StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 1, arg2: 1901, script: "$02000401_BF__MADRICANSIEGE__2$", arg4: 3, arg5: 2);
                context.SetSkip(state: new State던전종료StopCinematic(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State던전EndingCinematic01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetMesh(arg1: new[] {3801, 3802, 3803, 3804}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }
        }

        private class State던전EndingCinematic01 : TriggerState {
            internal State던전EndingCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetConversation(arg1: 1, arg2: 1903, script: "$02000401_BF__MADRICANSIEGE__3$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State던전EndingCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전EndingCinematic02 : TriggerState {
            internal State던전EndingCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1902, script: "$02000401_BF__MADRICANSIEGE__4$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1904, script: "$02000401_BF__MADRICANSIEGE__5$", arg4: 2, arg5: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State던전종료StopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료StopCinematic : TriggerState {
            internal State던전종료StopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateRoomCheck(context);
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
                    return new State던전종료(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestDungeon종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "Madracan01");
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ClearMadracanSiege");
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "Madracan_Q01");
                context.DungeonClear();
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

        private class StateQuestDungeon종료 : TriggerState {
            internal StateQuestDungeon종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "Madracan_Q01");
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
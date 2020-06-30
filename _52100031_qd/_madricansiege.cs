using System;

namespace Maple2.Trigger._52100031_qd {
    public static class _madricansiege {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8001,8002,8003,8004,8005,8006", arg2: true);
                context.SetAgent(arg1: "8101,8102,8103,8104,8105,8106", arg2: true);
                context.SetAgent(arg1: "8201,8202,8203,8204,8205,8206", arg2: true);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3801, 3802, 3803, 3804}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new int[] {1001, 1002, 1003, 1004, 1005}, arg2: false);
                context.CreateMonster(arg1: new int[] {2000, 2001}, arg2: false);
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

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State = new StateDungeonStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "연출종료");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetConversation(arg1: 2, arg2: 11000015, arg3: "$52100031_QD__MADRICANSIEGE__0$", arg4: 4,
                    arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 300, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State던전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetAgent(arg1: "8001,8002,8003,8004,8005,8006", arg2: false);
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$52100031_QD__MADRICANSIEGE__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2000, 2001})) {
                    context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105}, arg2: false, arg3: 0, arg4: 0,
                        arg5: 5f);
                    context.SetAgent(arg1: "8101,8102,8103,8104,8105,8106", arg2: false);
                    context.MoveNpc(arg1: 1102, arg2: "MS2PatrolData_1001A");
                    context.State = new State1차지원(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차지원 : TriggerState {
            internal State1차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(
                    rangeID: new int[] {
                        2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020, 2021,
                        2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030
                    }, isAutoTargeting: false);
                context.CreateMonster(arg1: new int[] {2002, 2003, 2004, 2005}, arg2: false);
                context.SetUserValue(triggerID: 99999101, key: "cannon01", value: 1);
                context.SetUserValue(triggerID: 99999099, key: "faction01", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2901})) {
                    context.DestroyMonster(arg1: new int[] {2002});
                    context.SetAgent(arg1: "8201,8202,8203,8204,8205,8206", arg2: false);
                    context.SetMesh(arg1: new int[] {3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: false, arg3: 0,
                        arg4: 0, arg5: 5f);
                    context.State = new State다리건넘(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건넘 : TriggerState {
            internal State다리건넘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShadowExpedition(type: "OpenBossGauge", maxGaugePoint: 1000);
                context.SetUserValue(triggerID: 99999102, key: "cannon02", value: 1);
                context.SetUserValue(triggerID: 99999103, key: "cannon03", value: 1);
                context.SetUserValue(triggerID: 99999104, key: "cannon04", value: 1);
                context.SetUserValue(triggerID: 99999105, key: "cannon05", value: 1);
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 300)) {
                    context.State = new State2차지원(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차지원 : TriggerState {
            internal State2차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99999098, key: "faction02", value: 1);
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 600)) {
                    context.State = new State3차지원(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차지원 : TriggerState {
            internal State3차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2031, 2032, 2033, 2034, 2035, 2036}, arg2: false);
                context.SetUserValue(triggerID: 99999097, key: "faction03", value: 1);
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 1000)) {
                    context.ShadowExpedition(type: "CloseBossGauge");
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2026, 2027, 2028, 2029, 2030}, arg2: false);
                context.SetUserValue(triggerID: 99999096, key: "faction04", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "bossSpawn", value: 1)) {
                    context.State = new State던전종료대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료대기 : TriggerState {
            internal State던전종료대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State던전종료딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료딜레이 : TriggerState {
            internal State던전종료딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State암전(context);
                    return;
                }
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52100031, arg2: 3);
                context.SetUserValue(triggerID: 99999099, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999098, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999097, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999096, key: "DungeonClear", value: 1);
                context.DestroyMonster(
                    arg1: new int[] {
                        2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017,
                        2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033,
                        2034, 2035, 2036, 2099, 2901, 2902, 2903, 2904, 2905
                    }, arg2: false);
                context.SpawnNpcRange(
                    rangeID: new int[] {
                        1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916,
                        1917, 1918, 1919, 1920, 1921, 1922
                    }, isAutoTargeting: false);
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State던전종료연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료연출시작 : TriggerState {
            internal State던전종료연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 305, arg2: true);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 1922, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11001567, illustID: "11001567", msg: "$52100031_QD__MADRICANSIEGE__2$",
                    duration: 3000, align: "Right");
                context.SetSkip(arg1: "던전종료연출종료");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State던전종료연출01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetMesh(arg1: new int[] {3801, 3802, 3803, 3804}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
            }
        }

        private class State던전종료연출01 : TriggerState {
            internal State던전종료연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 304, arg2: true);
                context.SetNpcEmotionLoop(arg1: 1921, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11001566, illustID: "11001566", msg: "$52100031_QD__MADRICANSIEGE__3$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State던전종료연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료연출02 : TriggerState {
            internal State던전종료연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcRotation(arg1: 1920, arg2: 180);
                context.SetNpcEmotionLoop(arg1: 1920, arg2: "Talk_A", arg3: 3000f);
                context.AddCinematicTalk(npcID: 11001568, illustID: "11001568", msg: "$52100031_QD__MADRICANSIEGE__4$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State룬블레이더이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State룬블레이더이동 : TriggerState {
            internal State룬블레이더이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1920, arg2: "MS2PatrolData_1920");
                context.MoveNpc(arg1: 1921, arg2: "MS2PatrolData_1921");
                context.MoveNpc(arg1: 1922, arg2: "MS2PatrolData_1922");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State던전종료연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료연출종료 : TriggerState {
            internal State던전종료연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1920, 1921, 1922}, arg2: false);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트던전종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트던전종료 : TriggerState {
            internal State퀘스트던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
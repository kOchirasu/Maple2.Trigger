using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000461_bf {
    public static class _madricansiege {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99999102, key: "cannon02", value: 0);
                context.SetUserValue(triggerID: 99999103, key: "cannon03", value: 0);
                context.SetUserValue(triggerID: 99999104, key: "cannon04", value: 0);
                context.SetUserValue(triggerID: 99999105, key: "cannon05", value: 0);
                context.SetUserValue(triggerID: 99999102, key: "Bosscannon02", value: 0);
                context.SetUserValue(triggerID: 99999103, key: "Bosscannon03", value: 0);
                context.SetUserValue(triggerID: 99999104, key: "Bosscannon04", value: 0);
                context.SetUserValue(triggerID: 99999105, key: "Bosscannon05", value: 0);
                context.SetAgent(arg1: "8001,8002,8003,8004,8005,8006", arg2: true);
                context.SetAgent(arg1: "8101,8102,8103,8104,8105,8106", arg2: true);
                context.SetAgent(arg1: "8201,8202,8203,8204,8205,8206", arg2: true);
                context.CameraSelect(arg1: 300, arg2: true);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.CreateMonster(arg1: new int[] {2000, 2001}, arg2: false);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3801, 3802, 3803, 3804}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
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
                context.RemoveBuff(arg1: 199, arg2: 99910150);
                context.SetInteractObject(arg1: new int[] {12000045}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000046}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000054}, arg2: 2);
                context.RemoveBuff(arg1: 199, arg2: 99910140);
                context.SetInteractObject(arg1: new int[] {12000047}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000048}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000049}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000050}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000055}, arg2: 2);
                context.RemoveBuff(arg1: 199, arg2: 99910130);
                context.SetInteractObject(arg1: new int[] {12000051}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000052}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000056}, arg2: 2);
                context.SetEffect(arg1: new int[] {601}, arg2: false);
                context.RemoveBuff(arg1: 199, arg2: 99910160);
                context.SetInteractObject(arg1: new int[] {12000053}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000057}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "199")) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State던전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전시작 : TriggerState {
            internal State던전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 1f);
                context.SetAgent(arg1: "8001,8002,8003,8004,8005,8006", arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2000, 2001})) {
                    context.SetMesh(arg1: new int[] {3101, 3102, 3103, 3104, 3105}, arg2: false, arg3: 0, arg4: 0,
                        arg5: 5f);
                    context.SetAgent(arg1: "8101,8102,8103,8104,8105,8106", arg2: false);
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
                    rangeID: new int[]
                        {2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020},
                    isAutoTargeting: false);
                context.CreateMonster(arg1: new int[] {2002, 2003, 2004, 2005}, arg2: false);
                context.SetUserValue(triggerID: 99999101, key: "cannon01", value: 1);
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
                context.ShadowExpedition(type: "OpenBossGauge", maxGaugePoint: 1400);
                context.SetUserValue(triggerID: 99999102, key: "cannon02", value: 1);
                context.SetUserValue(triggerID: 99999103, key: "cannon03", value: 1);
                context.SetUserValue(triggerID: 99999104, key: "cannon04", value: 1);
                context.SetUserValue(triggerID: 99999105, key: "cannon05", value: 1);
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 450)) {
                    context.State = new State2차지원(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차지원 : TriggerState {
            internal State2차지원(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeID: new int[] {2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030},
                    isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 700)) {
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
            }

            public override void Execute() {
                if (context.ShadowExpeditionReachPoint(point: 1400)) {
                    context.ShadowExpedition(type: "CloseBossGauge");
                    context.State = new State보스등장_딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장_딜레이 : TriggerState {
            internal State보스등장_딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(
                    arg1: new int[] {
                        2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017,
                        2018, 2019, 2020, 2021, 2022, 2023, 2024, 2025, 2026, 2027, 2028, 2029, 2030, 2031, 2032, 2033,
                        2034, 2035, 2036, 2901, 2902, 2903, 2904, 2905
                    }, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장 : TriggerState {
            internal State보스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2099}, arg2: true);
            }

            public override void Execute() {
                if (context.CheckNpcHp(compare: "lowerEqual", value: 50, spawnPointId: 2099, isRelative: "true")) {
                    context.State = new State보스_버프패턴(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스_버프패턴 : TriggerState {
            internal State보스_버프패턴(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000461_BF__MADRICANSIEGE__0$", arg3: new int[] {5000});
                context.SetUserValue(triggerID: 99999102, key: "Bosscannon02", value: 1);
                context.SetUserValue(triggerID: 99999103, key: "Bosscannon03", value: 1);
                context.SetUserValue(triggerID: 99999104, key: "Bosscannon04", value: 1);
                context.SetUserValue(triggerID: 99999105, key: "Bosscannon05", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {2099})) {
                    context.State = new State던전종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전종료 : TriggerState {
            internal State던전종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "Madracan01");
                context.SetAchievement(arg1: 199, arg2: "trigger", arg3: "ClearMadracanSiege");
                context.DungeonClear();
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
                context.SetUserValue(triggerID: 99999099, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999098, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999097, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999096, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999102, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999103, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999104, key: "DungeonClear", value: 1);
                context.SetUserValue(triggerID: 99999105, key: "DungeonClear", value: 1);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (true) {
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
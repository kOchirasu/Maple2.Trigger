using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000331_bf {
    public static class _seeker01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "11000", arg2: false);
                context.SetAgent(arg1: "11001", arg2: false);
                context.SetAgent(arg1: "13001", arg2: true);
                context.SetAgent(arg1: "13002", arg2: true);
                context.SetAgent(arg1: "13003", arg2: true);
                context.SetAgent(arg1: "13004", arg2: true);
                context.SetAgent(arg1: "13005", arg2: true);
                context.SetAgent(arg1: "13006", arg2: true);
                context.SetAgent(arg1: "15000", arg2: false);
                context.SetAgent(arg1: "15001", arg2: false);
                context.SetAgent(arg1: "15002", arg2: false);
                context.SetAgent(arg1: "16000", arg2: false);
                context.SetAgent(arg1: "16001", arg2: false);
                context.SetAgent(arg1: "16002", arg2: false);
                context.SetAgent(arg1: "16003", arg2: false);
                context.SetAgent(arg1: "16004", arg2: false);
                context.SetMesh(arg1: new int[] {90000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90003}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90006}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90007}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {98880}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {89999}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 92220, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 92221, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 92222, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 92223, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 92224, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 93330, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 93331, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 93332, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 93333, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 93334, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94440, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94441, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94442, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94443, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94444, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94445, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94446, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94447, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94448, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94449, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94450, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94451, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94452, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94453, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 94454, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 96660, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 96661, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 96662, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 96663, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 96664, arg2: true, arg3: "Idle_A");
                context.SetActor(arg1: 97770, arg2: true, arg3: "Closed");
                context.SetMesh(
                    arg1: new int[] {
                        10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013,
                        10014, 10015, 10016
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {10040, 10041, 10042, 10043, 10044}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116,
                        2117
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216,
                        2217, 2218, 2219, 2220
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[]
                        {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315},
                    arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416,
                        3417, 3418, 3419
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: false, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90090, 90091, 90092, 90093, 90094, 90095, 90096, 90097, 90098, 90099},
                    arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {10000766}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000767}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000768}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000769}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000771}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000772}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000773}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000774}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000775}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000784}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000792}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000793}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000794}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000795}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000785}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000796}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000797}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000798}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000799}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {10000776}, arg2: 2);
                context.CreateMonster(arg1: new int[] {401}, arg2: false);
                context.CreateMonster(arg1: new int[] {610}, arg2: false);
                context.SetEffect(arg1: new int[] {99999}, arg2: false);
                context.SetEffect(arg1: new int[] {7771}, arg2: false);
                context.SetEffect(arg1: new int[] {7772}, arg2: false);
                context.SetEffect(arg1: new int[] {777401}, arg2: false);
                context.SetEffect(arg1: new int[] {777402}, arg2: false);
                context.SetEffect(arg1: new int[] {777403}, arg2: false);
                context.SetEffect(arg1: new int[] {777404}, arg2: false);
                context.SetEffect(arg1: new int[] {777405}, arg2: false);
                context.SetEffect(arg1: new int[] {777501}, arg2: false);
                context.SetEffect(arg1: new int[] {777502}, arg2: false);
                context.SetEffect(arg1: new int[] {7776}, arg2: false);
                context.SetEffect(arg1: new int[] {777701}, arg2: false);
                context.SetEffect(arg1: new int[] {777702}, arg2: false);
                context.SetEffect(arg1: new int[] {777801}, arg2: false);
                context.SetEffect(arg1: new int[] {777802}, arg2: false);
                context.SetEffect(arg1: new int[] {777803}, arg2: false);
                context.SetEffect(arg1: new int[] {777901}, arg2: false);
                context.SetEffect(arg1: new int[] {777902}, arg2: false);
                context.SetEffect(arg1: new int[] {777903}, arg2: false);
                context.SetEffect(arg1: new int[] {777904}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.State = new StateLoadingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.CreateMonster(arg1: new int[] {100}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGateOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new int[] {89999}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State술래말풍선01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선01 : TriggerState {
            internal State술래말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__0$", arg4: 2, arg5: 0);
                context.SetMesh(arg1: new int[] {90000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State술래패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래패트롤01 : TriggerState {
            internal State술래패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003311, textID: 20003311);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new int[] {100})) {
                    context.State = new State몬스터출현01_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_시작 : TriggerState {
            internal State몬스터출현01_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "Opened");
                context.HideGuideSummary(entityID: 20003311);
                context.CreateMonster(arg1: new int[] {900}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현01_연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_연출01 : TriggerState {
            internal State몬스터출현01_연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__1$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {900})) {
                    context.State = new State몬스터출현01_연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_연출02 : TriggerState {
            internal State몬스터출현01_연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State몬스터출현01_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_생성랜덤01 : TriggerState {
            internal State몬스터출현01_생성랜덤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_1번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_2번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_3번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_4번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_1번생성 : TriggerState {
            internal State몬스터출현01_1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {901, 902}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현01_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_2번생성 : TriggerState {
            internal State몬스터출현01_2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {902, 904}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현01_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_3번생성 : TriggerState {
            internal State몬스터출현01_3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {903, 905}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현01_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_4번생성 : TriggerState {
            internal State몬스터출현01_4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {901, 905}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현01_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_생성랜덤02 : TriggerState {
            internal State몬스터출현01_생성랜덤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_5번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_6번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_7번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_8번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_5번생성 : TriggerState {
            internal State몬스터출현01_5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {905, 906, 907}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State몬스터출현01_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_6번생성 : TriggerState {
            internal State몬스터출현01_6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {906, 907, 909}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현01_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_7번생성 : TriggerState {
            internal State몬스터출현01_7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {907, 909, 910}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State몬스터출현01_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_8번생성 : TriggerState {
            internal State몬스터출현01_8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {907, 908, 909}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현01_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_생성랜덤03 : TriggerState {
            internal State몬스터출현01_생성랜덤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_9번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_10번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_11번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현01_12번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_9번생성 : TriggerState {
            internal State몬스터출현01_9번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {901, 902, 903}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    context.State = new State몬스터출현01_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_10번생성 : TriggerState {
            internal State몬스터출현01_10번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {902, 903, 904}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    context.State = new State몬스터출현01_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_11번생성 : TriggerState {
            internal State몬스터출현01_11번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {901, 904, 905}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    context.State = new State몬스터출현01_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_12번생성 : TriggerState {
            internal State몬스터출현01_12번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {903, 904, 905}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    context.State = new State몬스터출현01_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현01_종료 : TriggerState {
            internal State몬스터출현01_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__2$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째다리붕괴01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째다리붕괴01 : TriggerState {
            internal State첫번째다리붕괴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "11000", arg2: true);
                context.SetAgent(arg1: "11001", arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "99990")) {
                    context.State = new State첫번째무너짐연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째무너짐연출시작01 : TriggerState {
            internal State첫번째무너짐연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__900$");
                context.CameraSelect(arg1: 802, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_999");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째다리붕괴02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째다리붕괴02 : TriggerState {
            internal State첫번째다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013,
                        10014, 10015, 10016
                    }, arg2: false, arg3: 16, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777801}, arg2: true);
                context.SetMesh(arg1: new int[] {90001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {90000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip(arg1: "첫번째무너짐연출종료01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째무너짐연출종료01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 18, key: "clearafter", value: 1);
            }
        }

        private class State첫번째무너짐연출종료01 : TriggerState {
            internal State첫번째무너짐연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {777801}, arg2: false);
                context.CameraSelect(arg1: 802, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State술래말풍선02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선02 : TriggerState {
            internal State술래말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 16, key: "FirstBridgeOff", value: 1);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__3$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__4$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State술래패트롤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래패트롤02 : TriggerState {
            internal State술래패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1001");
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__24$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new int[] {91002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State첫번째덤불등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째덤불등장01 : TriggerState {
            internal State첫번째덤불등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003312, textID: 20003312);
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {91002})) {
                    context.State = new State첫번째덤불제거01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {777401}, arg2: true);
                context.HideGuideSummary(entityID: 20003312);
            }
        }

        private class State첫번째덤불제거01 : TriggerState {
            internal State첫번째덤불제거01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 92220, arg2: true, arg3: "Dead_A");
                context.SetMesh(arg1: new int[] {90002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__6$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째꼬마찾기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마찾기시작 : TriggerState {
            internal State첫번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 92000, arg2: false, arg3: "Dead_A");
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new int[] {100})) {
                    context.State = new State첫번째꼬마랜덤(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 92220, arg2: false, arg3: "Dead_A");
                context.SetEffect(arg1: new int[] {777401}, arg2: false);
            }
        }

        private class State첫번째꼬마랜덤 : TriggerState {
            internal State첫번째꼬마랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State첫번째힌트발견01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State첫번째힌트발견02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State첫번째힌트발견03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State첫번째힌트발견04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견01 : TriggerState {
            internal State첫번째힌트발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetRandomMesh(
                    arg1: new int[] {
                        2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016
                    }, arg2: true, arg3: 16, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000766}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State첫번째힌트수색01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State첫번째힌트수색01 : TriggerState {
            internal State첫번째힌트수색01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000766}, arg2: 0)) {
                    context.State = new State첫번째꼬마발견01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000766}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State첫번째꼬마발견01 : TriggerState {
            internal State첫번째꼬마발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000331_BF__Seeker01__11$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째꼬마만남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남01 : TriggerState {
            internal State첫번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2201");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new int[] {201})) {
                    context.State = new State첫번째꼬마교체딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체딜레이01 : TriggerState {
            internal State첫번째꼬마교체딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State첫번째꼬마교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체01 : TriggerState {
            internal State첫번째꼬마교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 201, arg2: 200);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_998");
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__13$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__14$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new int[] {100})) {
                    context.State = new State몬스터출현02_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견02 : TriggerState {
            internal State첫번째힌트발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetRandomMesh(
                    arg1: new int[] {
                        2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116,
                        2117
                    }, arg2: true, arg3: 17, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000767}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State첫번째힌트수색02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State첫번째힌트수색02 : TriggerState {
            internal State첫번째힌트수색02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000767}, arg2: 0)) {
                    context.State = new State첫번째꼬마발견02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000767}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State첫번째꼬마발견02 : TriggerState {
            internal State첫번째꼬마발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000331_BF__Seeker01__15$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째꼬마만남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남02 : TriggerState {
            internal State첫번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2202");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new int[] {202})) {
                    context.State = new State첫번째꼬마교체딜레이02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체딜레이02 : TriggerState {
            internal State첫번째꼬마교체딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State첫번째꼬마교체02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체02 : TriggerState {
            internal State첫번째꼬마교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 202, arg2: 200);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_998");
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__18$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__19$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new int[] {100})) {
                    context.State = new State몬스터출현02_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견03 : TriggerState {
            internal State첫번째힌트발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetRandomMesh(
                    arg1: new int[] {
                        2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216,
                        2217, 2218, 2219, 2220
                    }, arg2: true, arg3: 20, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000768}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State첫번째힌트수색03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State첫번째힌트수색03 : TriggerState {
            internal State첫번째힌트수색03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000768}, arg2: 0)) {
                    context.State = new State첫번째꼬마발견03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000768}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State첫번째꼬마발견03 : TriggerState {
            internal State첫번째꼬마발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {203}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000331_BF__Seeker01__16$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째꼬마만남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남03 : TriggerState {
            internal State첫번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2203");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new int[] {203})) {
                    context.State = new State첫번째꼬마교체딜레이03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체딜레이03 : TriggerState {
            internal State첫번째꼬마교체딜레이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State첫번째꼬마교체03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체03 : TriggerState {
            internal State첫번째꼬마교체03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 203, arg2: 200);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_998");
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__20$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__21$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new int[] {100})) {
                    context.State = new State몬스터출현02_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견04 : TriggerState {
            internal State첫번째힌트발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetRandomMesh(
                    arg1: new int[]
                        {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315},
                    arg2: true, arg3: 15, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10000769}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State첫번째힌트수색04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State첫번째힌트수색04 : TriggerState {
            internal State첫번째힌트수색04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000769}, arg2: 0)) {
                    context.State = new State첫번째꼬마발견04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000769}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State첫번째꼬마발견04 : TriggerState {
            internal State첫번째꼬마발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {204}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$02000331_BF__Seeker01__17$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State첫번째꼬마만남04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남04 : TriggerState {
            internal State첫번째꼬마만남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_2204");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new int[] {204})) {
                    context.State = new State첫번째꼬마교체딜레이04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체딜레이04 : TriggerState {
            internal State첫번째꼬마교체딜레이04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State첫번째꼬마교체04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체04 : TriggerState {
            internal State첫번째꼬마교체04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 204, arg2: 200);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_998");
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__22$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__23$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new int[] {100})) {
                    context.State = new State몬스터출현02_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현02_생성랜덤01 : TriggerState {
            internal State몬스터출현02_생성랜덤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현02_1번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현02_2번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현02_3번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현02_4번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현02_1번생성 : TriggerState {
            internal State몬스터출현02_1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {9223, 9224, 9225, 921, 922, 924, 925, 927, 928}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State두명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현02_2번생성 : TriggerState {
            internal State몬스터출현02_2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {9221, 9223, 9225, 920, 922, 924, 925, 926, 929}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State두명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현02_3번생성 : TriggerState {
            internal State몬스터출현02_3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {9221, 9222, 9224, 920, 922, 924, 925, 926, 928}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State두명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현02_4번생성 : TriggerState {
            internal State몬스터출현02_4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {9222, 9223, 9225, 922, 923, 925, 926, 927, 929}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State두명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두명패트롤01 : TriggerState {
            internal State두명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1003");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9016, arg2: new int[] {100})) {
                    context.State = new State두번째덤불등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째덤불등장01 : TriggerState {
            internal State두번째덤불등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003312, textID: 20003312);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__24$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new int[] {91003}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {91003})) {
                    context.State = new State두번째덤불제거01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003312);
                context.SetEffect(arg1: new int[] {777402}, arg2: true);
            }
        }

        private class State두번째덤불제거01 : TriggerState {
            internal State두번째덤불제거01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 93330, arg2: true, arg3: "Dead_A");
                context.SetMesh(arg1: new int[] {90003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째꼬마찾기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마찾기시작 : TriggerState {
            internal State두번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__25$", arg4: 3, arg5: 0);
                context.SetEffect(arg1: new int[] {777402}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1004");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2003");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9005, arg2: new int[] {100})) {
                    context.State = new State두번째몬스터발견01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 93330, arg2: false, arg3: "Dead_A");
            }
        }

        private class State두번째몬스터발견01 : TriggerState {
            internal State두번째몬스터발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__30$", arg4: 2, arg5: 0);
                context.SetAgent(arg1: "13001", arg2: false);
                context.SetAgent(arg1: "13002", arg2: false);
                context.SetAgent(arg1: "13003", arg2: false);
                context.SetAgent(arg1: "13004", arg2: false);
                context.SetAgent(arg1: "13005", arg2: false);
                context.SetAgent(arg1: "13006", arg2: false);
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__31$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {9221, 9222, 9223, 9224, 9225, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929})) {
                    context.State = new State두번째꼬마랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마랜덤 : TriggerState {
            internal State두번째꼬마랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State두번째힌트발견01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State두번째힌트발견02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State두번째힌트발견03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State두번째힌트발견04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State두번째힌트발견05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견01 : TriggerState {
            internal State두번째힌트발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(
                    arg1: new int[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018
                    }, arg2: true, arg3: 18, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new int[] {777502}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State두번째힌트수색01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State두번째힌트수색01 : TriggerState {
            internal State두번째힌트수색01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {311}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9301")) {
                    context.State = new State두번째꼬마도움01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움01 : TriggerState {
            internal State두번째꼬마도움01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 311, arg3: "$02000331_BF__Seeker01__33$", arg4: 2, arg5: 0);
                context.SetInteractObject(arg1: new int[] {10000771}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마발견01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견01 : TriggerState {
            internal State두번째꼬마발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000771}, arg2: 0)) {
                    context.State = new State두번째꼬마구출01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003313);
                context.SetInteractObject(arg1: new int[] {10000771}, arg2: 2);
            }
        }

        private class State두번째꼬마구출01 : TriggerState {
            internal State두번째꼬마구출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 311, arg2: 301);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000331_BF__Seeker01__38$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State두번째꼬마이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동01 : TriggerState {
            internal State두번째꼬마이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3301");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마만남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남01 : TriggerState {
            internal State두번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000331_BF__Seeker01__39$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마대화01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화01 : TriggerState {
            internal State두번째꼬마대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__40$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new int[] {301})) {
                    context.State = new State두번째꼬마교체딜레이01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체딜레이01 : TriggerState {
            internal State두번째꼬마교체딜레이01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__41$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째꼬마교체01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체01 : TriggerState {
            internal State두번째꼬마교체01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 301, arg2: 300);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_996");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__42$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new int[] {100})) {
                    context.State = new State세명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견02 : TriggerState {
            internal State두번째힌트발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(
                    arg1: new int[] {
                        3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116
                    }, arg2: true, arg3: 16, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new int[] {777502}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State두번째힌트수색02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State두번째힌트수색02 : TriggerState {
            internal State두번째힌트수색02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {312}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9302")) {
                    context.State = new State두번째꼬마도움02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움02 : TriggerState {
            internal State두번째꼬마도움02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 312, arg3: "$02000331_BF__Seeker01__34$", arg4: 2, arg5: 0);
                context.SetInteractObject(arg1: new int[] {10000772}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마발견02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견02 : TriggerState {
            internal State두번째꼬마발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000772}, arg2: 0)) {
                    context.State = new State두번째꼬마구출02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000772}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State두번째꼬마구출02 : TriggerState {
            internal State두번째꼬마구출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 312, arg2: 302);
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02000331_BF__Seeker01__43$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State두번째꼬마이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동02 : TriggerState {
            internal State두번째꼬마이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3302");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마만남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남02 : TriggerState {
            internal State두번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02000331_BF__Seeker01__44$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마대화02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화02 : TriggerState {
            internal State두번째꼬마대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__45$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new int[] {302})) {
                    context.State = new State두번째꼬마교체딜레이02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체딜레이02 : TriggerState {
            internal State두번째꼬마교체딜레이02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__46$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째꼬마교체02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체02 : TriggerState {
            internal State두번째꼬마교체02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 302, arg2: 300);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_996");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__47$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new int[] {100})) {
                    context.State = new State세명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견03 : TriggerState {
            internal State두번째힌트발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(
                    arg1: new int[] {
                        3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216,
                        3217, 3218, 3219, 3220, 3221
                    }, arg2: true, arg3: 21, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new int[] {777502}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State두번째힌트수색03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State두번째힌트수색03 : TriggerState {
            internal State두번째힌트수색03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {313}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9303")) {
                    context.State = new State두번째꼬마도움03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움03 : TriggerState {
            internal State두번째꼬마도움03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 313, arg3: "$02000331_BF__Seeker01__35$", arg4: 2, arg5: 0);
                context.SetInteractObject(arg1: new int[] {10000773}, arg2: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마발견03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견03 : TriggerState {
            internal State두번째꼬마발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000773}, arg2: 0)) {
                    context.State = new State두번째꼬마구출03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000773}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State두번째꼬마구출03 : TriggerState {
            internal State두번째꼬마구출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 313, arg2: 303);
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02000331_BF__Seeker01__48$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State두번째꼬마이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동03 : TriggerState {
            internal State두번째꼬마이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_3303");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마만남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남03 : TriggerState {
            internal State두번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02000331_BF__Seeker01__49$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마대화03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화03 : TriggerState {
            internal State두번째꼬마대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__50$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new int[] {303})) {
                    context.State = new State두번째꼬마교체딜레이03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체딜레이03 : TriggerState {
            internal State두번째꼬마교체딜레이03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__51$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마교체03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체03 : TriggerState {
            internal State두번째꼬마교체03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 303, arg2: 300);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_996");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__52$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new int[] {100})) {
                    context.State = new State세명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견04 : TriggerState {
            internal State두번째힌트발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(
                    arg1: new int[] {
                        3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316,
                        3317, 3318
                    }, arg2: true, arg3: 18, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new int[] {777502}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State두번째힌트수색04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State두번째힌트수색04 : TriggerState {
            internal State두번째힌트수색04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {314}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9304")) {
                    context.State = new State두번째꼬마도움04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움04 : TriggerState {
            internal State두번째꼬마도움04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000774}, arg2: 1);
                context.SetConversation(arg1: 1, arg2: 314, arg3: "$02000331_BF__Seeker01__36$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마발견04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견04 : TriggerState {
            internal State두번째꼬마발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000774}, arg2: 0)) {
                    context.State = new State두번째꼬마구출04(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000774}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State두번째꼬마구출04 : TriggerState {
            internal State두번째꼬마구출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 314, arg2: 304);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마이동04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동04 : TriggerState {
            internal State두번째꼬마이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_3304");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마만남04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남04 : TriggerState {
            internal State두번째꼬마만남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 304, arg3: "$02000331_BF__Seeker01__54$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마대화04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화04 : TriggerState {
            internal State두번째꼬마대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__55$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new int[] {304})) {
                    context.State = new State두번째꼬마교체딜레이04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체딜레이04 : TriggerState {
            internal State두번째꼬마교체딜레이04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__56$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째꼬마교체04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체04 : TriggerState {
            internal State두번째꼬마교체04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 304, arg2: 300);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_996");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__57$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new int[] {100})) {
                    context.State = new State세명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견05 : TriggerState {
            internal State두번째힌트발견05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.SetRandomMesh(
                    arg1: new int[] {
                        3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416,
                        3417, 3418, 3419
                    }, arg2: true, arg3: 19, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new int[] {777502}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State두번째힌트수색05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003313, textID: 20003313);
            }
        }

        private class State두번째힌트수색05 : TriggerState {
            internal State두번째힌트수색05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {315}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9305")) {
                    context.State = new State두번째꼬마도움05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움05 : TriggerState {
            internal State두번째꼬마도움05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000775}, arg2: 1);
                context.SetConversation(arg1: 1, arg2: 315, arg3: "$02000331_BF__Seeker01__37$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State두번째꼬마발견05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견05 : TriggerState {
            internal State두번째꼬마발견05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000775}, arg2: 0)) {
                    context.State = new State두번째꼬마구출05(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10000775}, arg2: 2);
                context.HideGuideSummary(entityID: 20003313);
            }
        }

        private class State두번째꼬마구출05 : TriggerState {
            internal State두번째꼬마구출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 315, arg2: 305);
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02000331_BF__Seeker01__58$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마이동05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동05 : TriggerState {
            internal State두번째꼬마이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_3305");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마만남05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남05 : TriggerState {
            internal State두번째꼬마만남05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02000331_BF__Seeker01__59$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State두번째꼬마대화05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화05 : TriggerState {
            internal State두번째꼬마대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__60$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new int[] {305})) {
                    context.State = new State두번째꼬마교체딜레이05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체딜레이05 : TriggerState {
            internal State두번째꼬마교체딜레이05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__61$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State두번째꼬마교체05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체05 : TriggerState {
            internal State두번째꼬마교체05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 305, arg2: 300);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_996");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__62$", arg4: 3, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new int[] {100})) {
                    context.State = new State세명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세명패트롤01 : TriggerState {
            internal State세명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1005");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2004");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9008, arg2: new int[] {100})) {
                    context.State = new State세명패트롤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세명패트롤02 : TriggerState {
            internal State세명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__70$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세번째덤불등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째덤불등장01 : TriggerState {
            internal State세번째덤불등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003312, textID: 20003312);
                context.CreateMonster(arg1: new int[] {91004}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {91004})) {
                    context.State = new State세번째덤불등장02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {777403}, arg2: true);
            }
        }

        private class State세번째덤불등장02 : TriggerState {
            internal State세번째덤불등장02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1006");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2005");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3003");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__71$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new int[] {91005}, arg2: false);
                context.SetMesh(arg1: new int[] {90004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 94440, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {91005})) {
                    context.State = new State세번째덤불등장03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003312);
                context.SetEffect(arg1: new int[] {777404}, arg2: true);
            }
        }

        private class State세번째덤불등장03 : TriggerState {
            internal State세번째덤불등장03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__72$", arg4: 2, arg5: 0);
                context.SetMesh(arg1: new int[] {90005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 94450, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세번째꼬마찾기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마찾기시작 : TriggerState {
            internal State세번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {777403}, arg2: false);
                context.SetEffect(arg1: new int[] {777404}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__73$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1016");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2015");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3013");
                context.SetActor(arg1: 94440, arg2: false, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State꼬마셋대화연출01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 94450, arg2: false, arg3: "Dead_A");
            }
        }

        private class State꼬마셋대화연출01 : TriggerState {
            internal State꼬마셋대화연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__74$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State세명패트롤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세명패트롤03 : TriggerState {
            internal State세명패트롤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9009, arg2: new int[] {100})) {
                    context.State = new State세번째스위치랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째스위치랜덤 : TriggerState {
            internal State세번째스위치랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State세번째스위치출현01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State세번째스위치출현02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State세번째스위치출현03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State세번째스위치출현04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State세번째스위치출현05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째스위치출현01 : TriggerState {
            internal State세번째스위치출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000784}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State고립연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출시작01 : TriggerState {
            internal State고립연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State고립연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출종료01 : TriggerState {
            internal State고립연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내01_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State구출안내01_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내01_01 : TriggerState {
            internal State구출안내01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구출안내01_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }
        }

        private class State구출안내01_02 : TriggerState {
            internal State구출안내01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내01_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내01_03 : TriggerState {
            internal State구출안내01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내01_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내01_04 : TriggerState {
            internal State구출안내01_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000784}, arg2: 0)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State세번째스위치출현02 : TriggerState {
            internal State세번째스위치출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000792}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State고립연출시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출시작02 : TriggerState {
            internal State고립연출시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State고립연출종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출종료02 : TriggerState {
            internal State고립연출종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내02_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State구출안내02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내02_01 : TriggerState {
            internal State구출안내02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구출안내02_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }
        }

        private class State구출안내02_02 : TriggerState {
            internal State구출안내02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내02_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내02_03 : TriggerState {
            internal State구출안내02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내02_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내02_04 : TriggerState {
            internal State구출안내02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000792}, arg2: 0)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State세번째스위치출현03 : TriggerState {
            internal State세번째스위치출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000793}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State고립연출시작03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출시작03 : TriggerState {
            internal State고립연출시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State고립연출종료03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출종료03 : TriggerState {
            internal State고립연출종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내03_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State구출안내03_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내03_01 : TriggerState {
            internal State구출안내03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구출안내03_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }
        }

        private class State구출안내03_02 : TriggerState {
            internal State구출안내03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내03_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내03_03 : TriggerState {
            internal State구출안내03_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내03_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내03_04 : TriggerState {
            internal State구출안내03_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000793}, arg2: 0)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State세번째스위치출현04 : TriggerState {
            internal State세번째스위치출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000794}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State고립연출시작04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출시작04 : TriggerState {
            internal State고립연출시작04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State고립연출종료04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출종료04 : TriggerState {
            internal State고립연출종료04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내04_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State구출안내04_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내04_01 : TriggerState {
            internal State구출안내04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구출안내04_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }
        }

        private class State구출안내04_02 : TriggerState {
            internal State구출안내04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내04_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내04_03 : TriggerState {
            internal State구출안내04_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내04_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내04_04 : TriggerState {
            internal State구출안내04_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000794}, arg2: 0)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State세번째스위치출현05 : TriggerState {
            internal State세번째스위치출현05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000795}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State고립연출시작05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출시작05 : TriggerState {
            internal State고립연출시작05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State고립연출종료05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State고립연출종료05 : TriggerState {
            internal State고립연출종료05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내05_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State구출안내05_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내05_01 : TriggerState {
            internal State구출안내05_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State구출안내05_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }
        }

        private class State구출안내05_02 : TriggerState {
            internal State구출안내05_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내05_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내05_03 : TriggerState {
            internal State구출안내05_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State구출안내05_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State구출안내05_04 : TriggerState {
            internal State구출안내05_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000795}, arg2: 0)) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 401, arg2: 400);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State세번째꼬마탈출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마탈출 : TriggerState {
            internal State세번째꼬마탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__83$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4001");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9010, arg2: new int[] {400})) {
                    context.State = new State세번째꼬마만남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마만남01 : TriggerState {
            internal State세번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1008");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2007");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3005");
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__84$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세번째꼬마만남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마만남02 : TriggerState {
            internal State세번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__85$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State세번째꼬마만남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마만남03 : TriggerState {
            internal State세번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__86$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State네명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네명패트롤01 : TriggerState {
            internal State네명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__87$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1009");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9011, arg2: new int[] {100})) {
                    context.State = new State네명패트롤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네명패트롤02 : TriggerState {
            internal State네명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2008");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3006");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4002");
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__88$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9017, arg2: new int[] {100})) {
                    context.State = new State네번째덤불등장01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째덤불등장01 : TriggerState {
            internal State네번째덤불등장01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003312, textID: 20003312);
                context.CreateMonster(arg1: new int[] {91006}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {91006})) {
                    context.State = new State네번째덤불제거01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003312);
                context.SetEffect(arg1: new int[] {777405}, arg2: true);
            }
        }

        private class State네번째덤불제거01 : TriggerState {
            internal State네번째덤불제거01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 96660, arg2: true, arg3: "Dead_A");
                context.SetMesh(arg1: new int[] {90006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State네번째꼬마찾기시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마찾기시작 : TriggerState {
            internal State네번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "401", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__89$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new int[] {777405}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1010");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2009");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3007");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4003");
                context.SetActor(arg1: 96660, arg2: false, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9013, arg2: new int[] {100})) {
                    context.State = new State몬스터출현05_꼬마생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_꼬마생성 : TriggerState {
            internal State몬스터출현05_꼬마생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {500}, arg2: false);
                context.MoveNpc(arg1: 500, arg2: "MS2PatrolData_5001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현05_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_생성랜덤01 : TriggerState {
            internal State몬스터출현05_생성랜덤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_1번대장생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_2번대장생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_3번대장생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_4번대장생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_1번대장생성 : TriggerState {
            internal State몬스터출현05_1번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {991}, arg2: false);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_905");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터출현05_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_2번대장생성 : TriggerState {
            internal State몬스터출현05_2번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {992}, arg2: false);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_905");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터출현05_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_3번대장생성 : TriggerState {
            internal State몬스터출현05_3번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {992}, arg2: false);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_905");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터출현05_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_4번대장생성 : TriggerState {
            internal State몬스터출현05_4번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {991}, arg2: false);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_905");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터출현05_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_생성랜덤02 : TriggerState {
            internal State몬스터출현05_생성랜덤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_1번자코생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_2번자코생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_3번자코생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_4번자코생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_1번자코생성 : TriggerState {
            internal State몬스터출현05_1번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5001", arg2: 1);
                context.CreateMonster(arg1: new int[] {930}, arg2: false);
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new int[] {935}, arg2: false);
                context.MoveNpc(arg1: 935, arg2: "MS2PatrolData_904");
                context.CreateMonster(arg1: new int[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_906");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5001")) {
                    context.State = new State몬스터출현05_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_2번자코생성 : TriggerState {
            internal State몬스터출현05_2번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5002", arg2: 1);
                context.CreateMonster(arg1: new int[] {931}, arg2: false);
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_902");
                context.CreateMonster(arg1: new int[] {936}, arg2: false);
                context.MoveNpc(arg1: 936, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new int[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_907");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5002")) {
                    context.State = new State몬스터출현05_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_3번자코생성 : TriggerState {
            internal State몬스터출현05_3번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5003", arg2: 1);
                context.CreateMonster(arg1: new int[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_903");
                context.CreateMonster(arg1: new int[] {938}, arg2: false);
                context.MoveNpc(arg1: 938, arg2: "MS2PatrolData_907");
                context.CreateMonster(arg1: new int[] {936}, arg2: false);
                context.MoveNpc(arg1: 936, arg2: "MS2PatrolData_901");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5003")) {
                    context.State = new State몬스터출현05_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_4번자코생성 : TriggerState {
            internal State몬스터출현05_4번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5004", arg2: 1);
                context.CreateMonster(arg1: new int[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_905");
                context.CreateMonster(arg1: new int[] {934}, arg2: false);
                context.MoveNpc(arg1: 934, arg2: "MS2PatrolData_903");
                context.CreateMonster(arg1: new int[] {938}, arg2: false);
                context.MoveNpc(arg1: 938, arg2: "MS2PatrolData_906");
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5004")) {
                    context.State = new State몬스터출현05_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_생성랜덤03 : TriggerState {
            internal State몬스터출현05_생성랜덤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_5번대장생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_6번대장생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_7번대장생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_8번대장생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_5번대장생성 : TriggerState {
            internal State몬스터출현05_5번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {991}, arg2: false);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_904");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현05_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_6번대장생성 : TriggerState {
            internal State몬스터출현05_6번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {992}, arg2: false);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_904");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현05_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_7번대장생성 : TriggerState {
            internal State몬스터출현05_7번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {993}, arg2: false);
                context.MoveNpc(arg1: 993, arg2: "MS2PatrolData_904");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현05_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_8번대장생성 : TriggerState {
            internal State몬스터출현05_8번대장생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {994}, arg2: false);
                context.MoveNpc(arg1: 994, arg2: "MS2PatrolData_904");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현05_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_생성랜덤04 : TriggerState {
            internal State몬스터출현05_생성랜덤04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_5번자코생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_6번자코생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_7번자코생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State몬스터출현05_8번자코생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_5번자코생성 : TriggerState {
            internal State몬스터출현05_5번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {930}, arg2: false);
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_902");
                context.CreateMonster(arg1: new int[] {935}, arg2: false);
                context.MoveNpc(arg1: 935, arg2: "MS2PatrolData_905");
                context.CreateMonster(arg1: new int[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_909");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State추격연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_6번자코생성 : TriggerState {
            internal State몬스터출현05_6번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {931}, arg2: false);
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new int[] {934}, arg2: false);
                context.MoveNpc(arg1: 934, arg2: "MS2PatrolData_909");
                context.CreateMonster(arg1: new int[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_907");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State추격연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_7번자코생성 : TriggerState {
            internal State몬스터출현05_7번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_903");
                context.CreateMonster(arg1: new int[] {935}, arg2: false);
                context.MoveNpc(arg1: 935, arg2: "MS2PatrolData_904");
                context.CreateMonster(arg1: new int[] {936}, arg2: false);
                context.MoveNpc(arg1: 936, arg2: "MS2PatrolData_901");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State추격연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현05_8번자코생성 : TriggerState {
            internal State몬스터출현05_8번자코생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_906");
                context.CreateMonster(arg1: new int[] {934}, arg2: false);
                context.MoveNpc(arg1: 934, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new int[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_907");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State추격연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추격연출시작01 : TriggerState {
            internal State추격연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7776}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__902$");
                context.CameraSelect(arg1: 800, arg2: true);
                context.SetSkip(arg1: "추격연출종료01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State추격연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State추격연출종료01 : TriggerState {
            internal State추격연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__803$", arg3: new int[] {2000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.CameraSelect(arg1: 800, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__90$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__91$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 500, arg3: "$02000331_BF__Seeker01__92$", arg4: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {930, 931, 932, 933, 934, 935, 936, 937, 938, 991, 992, 993, 994})) {
                    context.State = new State네번째꼬마만남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남01 : TriggerState {
            internal State네번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7776}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 500, arg3: "$02000331_BF__Seeker01__93$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State네번째꼬마만남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남02 : TriggerState {
            internal State네번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__94$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State네번째꼬마만남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남03 : TriggerState {
            internal State네번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__95$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State네번째꼬마만남04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남04 : TriggerState {
            internal State네번째꼬마만남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__96$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State다섯명패트롤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다섯명패트롤01 : TriggerState {
            internal State다섯명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__97$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1011");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9014, arg2: new int[] {100})) {
                    context.State = new State다섯명패트롤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다섯명패트롤02 : TriggerState {
            internal State다섯명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2010");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3008");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4004");
                context.MoveNpc(arg1: 500, arg2: "MS2PatrolData_5002");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9015, arg2: new int[] {100})) {
                    context.State = new State두번째무너짐연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째무너짐연출시작01 : TriggerState {
            internal State두번째무너짐연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__903$");
                context.CameraSelect(arg1: 806, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State두번째다리붕괴02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째다리붕괴02 : TriggerState {
            internal State두번째다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {
                        10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033
                    }, arg2: false, arg3: 14, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new int[] {777803}, arg2: true);
                context.SetAgent(arg1: "15000", arg2: true);
                context.SetAgent(arg1: "15001", arg2: true);
                context.SetAgent(arg1: "15002", arg2: true);
                context.SetSkip(arg1: "두번째무너짐연출종료01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State두번째무너짐연출종료01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째무너짐연출종료01 : TriggerState {
            internal State두번째무너짐연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 806, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "술래말풍선06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State술래말풍선06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선06 : TriggerState {
            internal State술래말풍선06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {777803}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1012");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2011");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State술래말풍선07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선07 : TriggerState {
            internal State술래말풍선07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__100$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__101$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 500, arg2: "MS2PatrolData_5003");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3009");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4005");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State술래말풍선08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선08 : TriggerState {
            internal State술래말풍선08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 500, arg3: "$02000331_BF__Seeker01__102$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State술래말풍선09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선09 : TriggerState {
            internal State술래말풍선09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__103$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State술래말풍선10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State술래말풍선10 : TriggerState {
            internal State술래말풍선10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__104$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__105$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State외다리생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리생성랜덤 : TriggerState {
            internal State외다리생성랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State외다리스위치출현01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State외다리스위치출현02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State외다리스위치출현03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State외다리스위치출현04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State외다리스위치출현05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리스위치출현01 : TriggerState {
            internal State외다리스위치출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000785}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000785}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State외다리스위치반응01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응01 : TriggerState {
            internal State외다리스위치반응01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000785})) {
                    context.State = new State외다리생성시작01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State외다리스위치출현02 : TriggerState {
            internal State외다리스위치출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000796}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000796}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State외다리스위치반응02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응02 : TriggerState {
            internal State외다리스위치반응02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000796})) {
                    context.State = new State외다리생성시작01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State외다리스위치출현03 : TriggerState {
            internal State외다리스위치출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000797}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000797}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State외다리스위치반응03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응03 : TriggerState {
            internal State외다리스위치반응03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000797})) {
                    context.State = new State외다리생성시작01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State외다리스위치출현04 : TriggerState {
            internal State외다리스위치출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000798}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000798}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State외다리스위치반응04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응04 : TriggerState {
            internal State외다리스위치반응04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000798})) {
                    context.State = new State외다리생성시작01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State외다리스위치출현05 : TriggerState {
            internal State외다리스위치출현05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000799}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000799}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State외다리스위치반응05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응05 : TriggerState {
            internal State외다리스위치반응05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003314, textID: 20003314);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000799})) {
                    context.State = new State외다리생성시작01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003314);
            }
        }

        private class State외다리생성시작01 : TriggerState {
            internal State외다리생성시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {90008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {777702}, arg2: true);
                context.SetRandomMesh(arg1: new int[] {10040, 10041, 10042, 10043, 10044}, arg2: true, arg3: 5,
                    arg4: 150, arg5: 150);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State다리건너갈준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너갈준비01 : TriggerState {
            internal State다리건너갈준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__805$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1013");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State다리건너갈준비02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너갈준비02 : TriggerState {
            internal State다리건너갈준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__110$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "99992")) {
                    context.State = new State다리건너가기01(context);
                    return;
                }

                if (context.UserDetected(arg1: "99993")) {
                    context.State = new State다리건너가기01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너가기01 : TriggerState {
            internal State다리건너가기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1014");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2014");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3010");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4006");
                context.MoveNpc(arg1: 500, arg2: "MS2PatrolData_5004");
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__111$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State다리건너가기02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너가기02 : TriggerState {
            internal State다리건너가기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "99996")) {
                    context.State = new State다리건너가기03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너가기03 : TriggerState {
            internal State다리건너가기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 610, arg3: "$02000331_BF__Seeker01__112$", arg4: 3, arg5: 0);
                context.SetMesh(arg1: new int[] {90008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State다리건너가기04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State다리건너가기04 : TriggerState {
            internal State다리건너가기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9018, arg2: new int[] {300})) {
                    context.State = new State보스등장연출시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출시작01 : TriggerState {
            internal State보스등장연출시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {990}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__904$");
                context.SetEffect(arg1: new int[] {777901}, arg2: true);
                context.CameraSelect(arg1: 808, arg2: true);
                context.SetSkip(arg1: "보스등장연출중01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스등장연출중01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중01 : TriggerState {
            internal State보스등장연출중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__905$");
                context.SetSkip(arg1: "보스등장연출중01Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스등장연출중01Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중01Skip : TriggerState {
            internal State보스등장연출중01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State보스등장연출중02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중02 : TriggerState {
            internal State보스등장연출중02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__906$");
                context.ChangeMonster(arg1: 100, arg2: 601);
                context.ChangeMonster(arg1: 200, arg2: 602);
                context.ChangeMonster(arg1: 300, arg2: 603);
                context.ChangeMonster(arg1: 400, arg2: 604);
                context.ChangeMonster(arg1: 500, arg2: 605);
                context.CameraSelect(arg1: 809, arg2: true);
                context.SetSkip(arg1: "보스등장연출중02Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스등장연출중02Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중02Skip : TriggerState {
            internal State보스등장연출중02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State보스등장연출중03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중03 : TriggerState {
            internal State보스등장연출중03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new int[] {10040, 10041, 10042, 10043, 10044}, arg2: false, arg3: 5,
                    arg4: 150, arg5: 150);
                context.SetEffect(arg1: new int[] {777802}, arg2: true);
                context.SetAgent(arg1: "16000", arg2: true);
                context.SetAgent(arg1: "16001", arg2: true);
                context.SetAgent(arg1: "16002", arg2: true);
                context.SetAgent(arg1: "16003", arg2: true);
                context.SetAgent(arg1: "16004", arg2: true);
                context.SetSkip(arg1: "보스등장연출중03Skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스등장연출중03Skip(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중03Skip : TriggerState {
            internal State보스등장연출중03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State보스등장연출중04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출중04 : TriggerState {
            internal State보스등장연출중04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 809, arg2: false);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__907$");
                context.SetEffect(arg1: new int[] {777901}, arg2: false);
                context.SetEffect(arg1: new int[] {777902}, arg2: true);
                context.SetSkip(arg1: "보스등장연출끝01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스등장연출끝01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스등장연출끝01 : TriggerState {
            internal State보스등장연출끝01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 808, arg2: false);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new int[] {777802}, arg2: false);
                context.SetUserValue(triggerID: 15, key: "SecondBridgeOff", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마지막웨이브알림01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막웨이브알림01 : TriggerState {
            internal State마지막웨이브알림01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__806$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State몬스터출현06_생성랜덤01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_생성랜덤01 : TriggerState {
            internal State몬스터출현06_생성랜덤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_1번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_2번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_3번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_4번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_5번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_1번생성 : TriggerState {
            internal State몬스터출현06_1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {940, 941, 950, 951}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_2번생성 : TriggerState {
            internal State몬스터출현06_2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {942, 943, 952, 953}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_3번생성 : TriggerState {
            internal State몬스터출현06_3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6003", arg2: 1);
                context.CreateMonster(arg1: new int[] {944, 945, 954, 955}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_4번생성 : TriggerState {
            internal State몬스터출현06_4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {946, 947, 956, 957}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_5번생성 : TriggerState {
            internal State몬스터출현06_5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {948, 949, 958, 959}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_생성랜덤02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_생성랜덤02 : TriggerState {
            internal State몬스터출현06_생성랜덤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_6번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_7번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_8번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_9번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_10번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_6번생성 : TriggerState {
            internal State몬스터출현06_6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {960, 961, 962, 963}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State두번째웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_7번생성 : TriggerState {
            internal State몬스터출현06_7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {962, 963, 964, 965}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State두번째웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_8번생성 : TriggerState {
            internal State몬스터출현06_8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 966, 967}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State두번째웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_9번생성 : TriggerState {
            internal State몬스터출현06_9번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {966, 967, 968, 969}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State두번째웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_10번생성 : TriggerState {
            internal State몬스터출현06_10번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {968, 969, 960, 961}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State두번째웨이브대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State두번째웨이브대기 : TriggerState {
            internal State두번째웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State몬스터출현06_생성랜덤03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_생성랜덤03 : TriggerState {
            internal State몬스터출현06_생성랜덤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_11번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_12번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_13번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_14번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_15번생성_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_11번생성_01 : TriggerState {
            internal State몬스터출현06_11번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {940, 941, 971}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_11번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_11번생성_02 : TriggerState {
            internal State몬스터출현06_11번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {950, 951, 970}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_11번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_11번생성_03 : TriggerState {
            internal State몬스터출현06_11번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {960, 961, 962}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_11번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_11번생성_04 : TriggerState {
            internal State몬스터출현06_11번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {945, 946, 976}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_11번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_11번생성_05 : TriggerState {
            internal State몬스터출현06_11번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {955, 956, 957}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State몬스터출현06_11번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_11번생성_06 : TriggerState {
            internal State몬스터출현06_11번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {965, 966, 975}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State몬스터출현06_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_12번생성_01 : TriggerState {
            internal State몬스터출현06_12번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {958, 959, 978}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_12번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_12번생성_02 : TriggerState {
            internal State몬스터출현06_12번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {968, 969, 960}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_12번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_12번생성_03 : TriggerState {
            internal State몬스터출현06_12번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {948, 949, 979}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_12번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_12번생성_04 : TriggerState {
            internal State몬스터출현06_12번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {943, 944, 945, 975}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_12번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_12번생성_05 : TriggerState {
            internal State몬스터출현06_12번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {953, 954}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_12번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_12번생성_06 : TriggerState {
            internal State몬스터출현06_12번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 974}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State몬스터출현06_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_13번생성_01 : TriggerState {
            internal State몬스터출현06_13번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {946, 947}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_13번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_13번생성_02 : TriggerState {
            internal State몬스터출현06_13번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {955, 956, 957, 976}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_13번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_13번생성_03 : TriggerState {
            internal State몬스터출현06_13번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {965, 966, 967, 977}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_13번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_13번생성_04 : TriggerState {
            internal State몬스터출현06_13번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {969, 960, 979}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_13번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_13번생성_05 : TriggerState {
            internal State몬스터출현06_13번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {949, 940, 970}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_13번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_13번생성_06 : TriggerState {
            internal State몬스터출현06_13번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {950, 959}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State몬스터출현06_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_14번생성_01 : TriggerState {
            internal State몬스터출현06_14번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {941, 942, 972}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_14번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_14번생성_02 : TriggerState {
            internal State몬스터출현06_14번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {961, 962, 963}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_14번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_14번생성_03 : TriggerState {
            internal State몬스터출현06_14번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {951, 952, 953}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_14번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_14번생성_04 : TriggerState {
            internal State몬스터출현06_14번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 974}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_14번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_14번생성_05 : TriggerState {
            internal State몬스터출현06_14번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {944, 946, 975}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_14번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_14번생성_06 : TriggerState {
            internal State몬스터출현06_14번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {955, 956, 976}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State몬스터출현06_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_15번생성_01 : TriggerState {
            internal State몬스터출현06_15번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {948, 949, 979}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_15번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_15번생성_02 : TriggerState {
            internal State몬스터출현06_15번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {968, 969, 960, 978}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_15번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_15번생성_03 : TriggerState {
            internal State몬스터출현06_15번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {948, 949}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_15번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_15번생성_04 : TriggerState {
            internal State몬스터출현06_15번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {963, 964, 973}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_15번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_15번생성_05 : TriggerState {
            internal State몬스터출현06_15번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {953, 954, 955, 974}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_15번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_15번생성_06 : TriggerState {
            internal State몬스터출현06_15번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {943, 944}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State몬스터출현06_생성랜덤04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_생성랜덤04 : TriggerState {
            internal State몬스터출현06_생성랜덤04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new State몬스터출현06_16번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_17번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_18번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_19번생성_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State몬스터출현06_20번생성_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_01 : TriggerState {
            internal State몬스터출현06_16번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {941, 942, 971}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_16번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_02 : TriggerState {
            internal State몬스터출현06_16번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {951, 953}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_16번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_03 : TriggerState {
            internal State몬스터출현06_16번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {954, 955, 956, 986}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_16번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_04 : TriggerState {
            internal State몬스터출현06_16번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 985}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_16번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_05 : TriggerState {
            internal State몬스터출현06_16번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {953, 954}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_16번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_06 : TriggerState {
            internal State몬스터출현06_16번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 974}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_16번생성_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_07 : TriggerState {
            internal State몬스터출현06_16번생성_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {947, 948, 949, 988}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_16번생성_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_16번생성_08 : TriggerState {
            internal State몬스터출현06_16번생성_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {967, 968, 987}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State보스전투_준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_01 : TriggerState {
            internal State몬스터출현06_17번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {954, 955, 956, 986}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_17번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_02 : TriggerState {
            internal State몬스터출현06_17번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 985}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_17번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_03 : TriggerState {
            internal State몬스터출현06_17번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {941, 942, 971}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_17번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_04 : TriggerState {
            internal State몬스터출현06_17번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {951, 953}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_17번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_05 : TriggerState {
            internal State몬스터출현06_17번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {947, 948, 949, 988}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_17번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_06 : TriggerState {
            internal State몬스터출현06_17번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {967, 968, 987}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_17번생성_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_07 : TriggerState {
            internal State몬스터출현06_17번생성_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {953, 954}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_17번생성_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_17번생성_08 : TriggerState {
            internal State몬스터출현06_17번생성_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {964, 965, 974}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State보스전투_준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_01 : TriggerState {
            internal State몬스터출현06_18번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {959, 958}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_18번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_02 : TriggerState {
            internal State몬스터출현06_18번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {949, 940, 970}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_18번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_03 : TriggerState {
            internal State몬스터출현06_18번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {953, 954, 955, 983}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_18번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_04 : TriggerState {
            internal State몬스터출현06_18번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {943, 945, 984}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_18번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_05 : TriggerState {
            internal State몬스터출현06_18번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {961, 962}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_18번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_06 : TriggerState {
            internal State몬스터출현06_18번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {952, 953, 972}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_18번생성_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_07 : TriggerState {
            internal State몬스터출현06_18번생성_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {945, 946, 947, 985}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_18번생성_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_18번생성_08 : TriggerState {
            internal State몬스터출현06_18번생성_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {966, 967, 986}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State보스전투_준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_01 : TriggerState {
            internal State몬스터출현06_19번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {943, 944, 945, 974}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_19번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_02 : TriggerState {
            internal State몬스터출현06_19번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {963, 965}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_19번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_03 : TriggerState {
            internal State몬스터출현06_19번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {951, 950, 980}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_19번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_04 : TriggerState {
            internal State몬스터출현06_19번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {941, 942, 981}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_19번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_05 : TriggerState {
            internal State몬스터출현06_19번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {957, 958}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_19번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_06 : TriggerState {
            internal State몬스터출현06_19번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {966, 968, 977}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_19번생성_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_07 : TriggerState {
            internal State몬스터출현06_19번생성_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {948, 949, 989}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_19번생성_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_19번생성_08 : TriggerState {
            internal State몬스터출현06_19번생성_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {959, 958, 988}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State보스전투_준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_01 : TriggerState {
            internal State몬스터출현06_20번생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {967, 968, 969}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_20번생성_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_02 : TriggerState {
            internal State몬스터출현06_20번생성_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {957, 959, 978}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_20번생성_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_03 : TriggerState {
            internal State몬스터출현06_20번생성_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {953, 954, 984}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_20번생성_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_04 : TriggerState {
            internal State몬스터출현06_20번생성_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {943, 944, 983}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_20번생성_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_05 : TriggerState {
            internal State몬스터출현06_20번생성_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {951, 952, 950}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_20번생성_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_06 : TriggerState {
            internal State몬스터출현06_20번생성_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {962, 961, 970}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State몬스터출현06_20번생성_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_07 : TriggerState {
            internal State몬스터출현06_20번생성_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {946, 947, 986}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State몬스터출현06_20번생성_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터출현06_20번생성_08 : TriggerState {
            internal State몬스터출현06_20번생성_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {955, 956, 985}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959,
                    960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979,
                    980, 981, 982, 983, 984, 985, 986, 987, 988, 989
                })) {
                    context.State = new State보스전투_준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투_준비01 : TriggerState {
            internal State보스전투_준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스전투_준비02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투_준비02 : TriggerState {
            internal State보스전투_준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 811, arg2: true);
                context.SetSkip(arg1: "보스전투_준비04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State보스전투_준비03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투_준비03 : TriggerState {
            internal State보스전투_준비03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__908$");
                context.SetEffect(arg1: new int[] {777902}, arg2: false);
                context.SetEffect(arg1: new int[] {777903}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State보스전투_준비04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투_준비04 : TriggerState {
            internal State보스전투_준비04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 811, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스전투_시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투_시작01 : TriggerState {
            internal State보스전투_시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {990});
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__807$", arg3: new int[] {3000}, arg4: "0");
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
                context.CreateMonster(arg1: new int[] {999}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {999})) {
                    context.State = new State보스도망준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스도망준비01 : TriggerState {
            internal State보스도망준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State보스도망연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스도망연출01 : TriggerState {
            internal State보스도망연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {1000}, arg2: false);
                context.SetInteractObject(arg1: new int[] {10000776}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {10000776}, arg2: 1);
                context.SetActor(arg1: 97770, arg2: false, arg3: "Closed");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__909$");
                context.CameraSelect(arg1: 812, arg2: true);
                context.SetSkip(arg1: "보스도망연출03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State보스도망연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스도망연출02 : TriggerState {
            internal State보스도망연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__910$");
                context.SetEffect(arg1: new int[] {777903}, arg2: false);
                context.SetEffect(arg1: new int[] {777904}, arg2: true);
                context.SetSkip(arg1: "보스도망연출03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스도망연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스도망연출03 : TriggerState {
            internal State보스도망연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 812, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ChangeMonster(arg1: 610, arg2: 600);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State보스전투_끝01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전투_끝01 : TriggerState {
            internal State보스전투_끝01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__808$", arg3: new int[] {3000}, arg4: "0");
                context.SetConversation(arg1: 1, arg2: 600, arg3: "$02000331_BF__Seeker01__120$", arg4: 2, arg5: 1);
                context.DestroyMonster(arg1: new int[] {1000});
                context.SetEffect(arg1: new int[] {7771}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마지막연출_준비01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막연출_준비01 : TriggerState {
            internal State마지막연출_준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20003315, textID: 20003315);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000776})) {
                    context.State = new State마지막연출_포털출현01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20003315);
                context.SetInteractObject(arg1: new int[] {10000776}, arg2: 0);
            }
        }

        private class State마지막연출_포털출현01 : TriggerState {
            internal State마지막연출_포털출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$02000331_BF__Seeker01__809$", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마지막연출_포털출현02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막연출_포털출현02 : TriggerState {
            internal State마지막연출_포털출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 600, arg2: "MS2PatrolData_6001");
                context.SetEffect(arg1: new int[] {777904}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마지막연출_포털출현03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막연출_포털출현03 : TriggerState {
            internal State마지막연출_포털출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 600, arg3: "$02000331_BF__Seeker01__130$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new int[] {99999}, arg2: true);
                context.SetEffect(arg1: new int[] {7772}, arg2: true);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9020, arg2: new int[] {600})) {
                    context.State = new State마지막연출_포털출현04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막연출_포털출현04 : TriggerState {
            internal State마지막연출_포털출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {99999}, arg2: false);
                context.ChangeMonster(arg1: 601, arg2: 110);
                context.ChangeMonster(arg1: 602, arg2: 210);
                context.ChangeMonster(arg1: 603, arg2: 310);
                context.ChangeMonster(arg1: 604, arg2: 410);
                context.ChangeMonster(arg1: 605, arg2: 510);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State마지막연출_시작01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막연출_시작01 : TriggerState {
            internal State마지막연출_시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 410, arg2: "MS2PatrolData_4007");
                context.MoveNpc(arg1: 510, arg2: "MS2PatrolData_5005");
                context.MoveNpc(arg1: 110, arg2: "MS2PatrolData_1015");
                context.MoveNpc(arg1: 210, arg2: "MS2PatrolData_2012");
                context.MoveNpc(arg1: 310, arg2: "MS2PatrolData_3011");
                context.MoveNpc(arg1: 600, arg2: "MS2PatrolData_6002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State마지막연출_시작02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마지막연출_시작02 : TriggerState {
            internal State마지막연출_시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 110, arg3: "$02000331_BF__Seeker01__131$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 310, arg3: "$02000331_BF__Seeker01__132$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 410, arg3: "$02000331_BF__Seeker01__133$", arg4: 2, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 600, arg3: "$02000331_BF__Seeker01__136$", arg4: 2, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State던전클리어01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전클리어01 : TriggerState {
            internal State던전클리어01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(
                    arg1: new int[] {90090, 90091, 90092, 90093, 90094, 90095, 90096, 90097, 90098, 90099}, arg2: false,
                    arg3: 10, arg4: 100, arg5: 100);
                context.ChangeMonster(arg1: 110, arg2: 111);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State퇴장시작01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DungeonClear();
                context.SetAchievement(arg1: 99998, arg2: "trigger", arg3: "ClearHideandSeek");
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }
        }

        private class State퇴장시작01 : TriggerState {
            internal State퇴장시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 210, arg3: "$02000331_BF__Seeker01__134$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 510, arg3: "$02000331_BF__Seeker01__135$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 111, arg3: "$02000331_BF__Seeker01__137$", arg4: 2, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "11000", arg2: false);
                context.SetAgent(arg1: "11001", arg2: false);
                context.SetAgent(arg1: "15000", arg2: false);
                context.SetAgent(arg1: "15001", arg2: false);
                context.SetAgent(arg1: "15002", arg2: false);
                context.SetAgent(arg1: "16000", arg2: false);
                context.SetAgent(arg1: "16001", arg2: false);
                context.SetAgent(arg1: "16002", arg2: false);
                context.SetAgent(arg1: "16003", arg2: false);
                context.SetAgent(arg1: "16004", arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
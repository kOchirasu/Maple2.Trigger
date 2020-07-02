using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000331_bf {
    public static class _seeker01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {11000, 11001}, arg2: false);
                context.SetAgent(arg1: new[] {13001, 13002, 13003, 13004, 13005, 13006}, arg2: true);
                context.SetAgent(arg1: new[] {15000, 15001, 15002, 16000, 16001, 16002, 16003, 16004}, arg2: false);
                context.SetMesh(arg1: new[] {90000, 90001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {90002, 90003, 90004, 90005, 90006, 90007, 90008, 98880}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 4000, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {89999}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(arg1: new[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {10040, 10041, 10042, 10043, 10044, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {90090, 90091, 90092, 90093, 90094, 90095, 90096, 90097, 90098, 90099}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000766, 10000767, 10000768, 10000769, 10000771, 10000772, 10000773, 10000774, 10000775, 10000784, 10000792, 10000793, 10000794, 10000795, 10000785, 10000796, 10000797, 10000798, 10000799, 10000776}, arg2: 2);
                context.CreateMonster(arg1: new[] {401, 610}, arg2: false);
                context.SetEffect(arg1: new[] {99999, 7771, 7772, 777401, 777402, 777403, 777404, 777405, 777501, 777502, 7776, 777701, 777702, 777801, 777802, 777803, 777901, 777902, 777903, 777904}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGateOpen01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGateOpen01 : TriggerState {
            internal StateGateOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: true, arg3: "Opened");
                context.SetMesh(arg1: new[] {89999}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State술래말풍선01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래말풍선01 : TriggerState {
            internal State술래말풍선01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__0$", arg4: 2, arg5: 0);
                context.SetMesh(arg1: new[] {90000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State술래패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래패트롤01 : TriggerState {
            internal State술래패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003311, textId: 20003311);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1000");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9002, arg2: new[] {100})) {
                    return new StateMonsterSpawn01_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_시작 : TriggerState {
            internal StateMonsterSpawn01_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 4000, arg2: false, arg3: "Opened");
                context.HideGuideSummary(entityId: 20003311);
                context.CreateMonster(arg1: new[] {900}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn01_Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_Cinematic01 : TriggerState {
            internal StateMonsterSpawn01_Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateMonsterSpawn01_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_Cinematic02 : TriggerState {
            internal StateMonsterSpawn01_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMonsterSpawn01_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_CreationRandom01 : TriggerState {
            internal StateMonsterSpawn01_CreationRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_1TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_2TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_3TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_4TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_1TimedCreation : TriggerState {
            internal StateMonsterSpawn01_1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn01_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_2TimedCreation : TriggerState {
            internal StateMonsterSpawn01_2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {902, 904}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn01_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_3TimedCreation : TriggerState {
            internal StateMonsterSpawn01_3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {903, 905}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn01_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_4TimedCreation : TriggerState {
            internal StateMonsterSpawn01_4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 905}, arg2: false);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__801$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn01_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_CreationRandom02 : TriggerState {
            internal StateMonsterSpawn01_CreationRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_5TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_6TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_7TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_8TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_5TimedCreation : TriggerState {
            internal StateMonsterSpawn01_5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {905, 906, 907}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonsterSpawn01_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_6TimedCreation : TriggerState {
            internal StateMonsterSpawn01_6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {906, 907, 909}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn01_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_7TimedCreation : TriggerState {
            internal StateMonsterSpawn01_7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {907, 909, 910}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonsterSpawn01_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_8TimedCreation : TriggerState {
            internal StateMonsterSpawn01_8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {907, 908, 909}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn01_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_CreationRandom03 : TriggerState {
            internal StateMonsterSpawn01_CreationRandom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_9TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_10TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_11TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn01_12TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_9TimedCreation : TriggerState {
            internal StateMonsterSpawn01_9TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 902, 903}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_10TimedCreation : TriggerState {
            internal StateMonsterSpawn01_10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {902, 903, 904}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_11TimedCreation : TriggerState {
            internal StateMonsterSpawn01_11TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {901, 904, 905}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_12TimedCreation : TriggerState {
            internal StateMonsterSpawn01_12TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {903, 904, 905}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_종료 : TriggerState {
            internal StateMonsterSpawn01_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째다리붕괴01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째다리붕괴01 : TriggerState {
            internal State첫번째다리붕괴01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {11000, 11001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {99990})) {
                    return new State첫번째무너짐StartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째무너짐StartCinematic01 : TriggerState {
            internal State첫번째무너짐StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__900$");
                context.CameraSelect(arg1: 802, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_999");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째다리붕괴02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째다리붕괴02 : TriggerState {
            internal State첫번째다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016}, arg2: false, arg3: 16, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new[] {777801}, arg2: true);
                context.SetMesh(arg1: new[] {90001, 90000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip(arg1: "첫번째무너짐연출종료01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째무너짐StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 18, key: "clearafter", value: 1);
            }
        }

        private class State첫번째무너짐StopCinematic01 : TriggerState {
            internal State첫번째무너짐StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {777801}, arg2: false);
                context.CameraSelect(arg1: 802, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State술래말풍선02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래말풍선02 : TriggerState {
            internal State술래말풍선02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 16, key: "FirstBridgeOff", value: 1);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__3$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State술래패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래패트롤02 : TriggerState {
            internal State술래패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1001");
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__5$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__24$", arg4: 2, arg5: 2);
                context.CreateMonster(arg1: new[] {91002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State첫번째덤불Appear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째덤불Appear01 : TriggerState {
            internal State첫번째덤불Appear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {91002})) {
                    return new State첫번째덤불Remove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {777401}, arg2: true);
                context.HideGuideSummary(entityId: 20003312);
            }
        }

        private class State첫번째덤불Remove01 : TriggerState {
            internal State첫번째덤불Remove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 92220, arg2: true, arg3: "Dead_A");
                context.SetMesh(arg1: new[] {90002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째꼬마찾기시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마찾기시작 : TriggerState {
            internal State첫번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 92000, arg2: false, arg3: "Dead_A");
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1002");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9003, arg2: new[] {100})) {
                    return new State첫번째꼬마Random(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 92220, arg2: false, arg3: "Dead_A");
                context.SetEffect(arg1: new[] {777401}, arg2: false);
            }
        }

        private class State첫번째꼬마Random : TriggerState {
            internal State첫번째꼬마Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new State첫번째힌트발견01(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State첫번째힌트발견02(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State첫번째힌트발견03(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State첫번째힌트발견04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견01 : TriggerState {
            internal State첫번째힌트발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, arg2: true, arg3: 16, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000766}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State첫번째힌트수색01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State첫번째힌트수색01 : TriggerState {
            internal State첫번째힌트수색01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000766}, arg2: 0)) {
                    return new State첫번째꼬마발견01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000766}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견01 : TriggerState {
            internal State첫번째꼬마발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$02000331_BF__Seeker01__11$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째꼬마만남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남01 : TriggerState {
            internal State첫번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_2201");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {201})) {
                    return new State첫번째꼬마교체Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay01 : TriggerState {
            internal State첫번째꼬마교체Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State첫번째꼬마교체01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new[] {100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견02 : TriggerState {
            internal State첫번째힌트발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117}, arg2: true, arg3: 17, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000767}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State첫번째힌트수색02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State첫번째힌트수색02 : TriggerState {
            internal State첫번째힌트수색02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000767}, arg2: 0)) {
                    return new State첫번째꼬마발견02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000767}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견02 : TriggerState {
            internal State첫번째꼬마발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000331_BF__Seeker01__15$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째꼬마만남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남02 : TriggerState {
            internal State첫번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_2202");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {202})) {
                    return new State첫번째꼬마교체Delay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay02 : TriggerState {
            internal State첫번째꼬마교체Delay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State첫번째꼬마교체02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new[] {100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견03 : TriggerState {
            internal State첫번째힌트발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220}, arg2: true, arg3: 20, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000768}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State첫번째힌트수색03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State첫번째힌트수색03 : TriggerState {
            internal State첫번째힌트수색03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000768}, arg2: 0)) {
                    return new State첫번째꼬마발견03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000768}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견03 : TriggerState {
            internal State첫번째꼬마발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 203, arg3: "$02000331_BF__Seeker01__16$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째꼬마만남03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남03 : TriggerState {
            internal State첫번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_2203");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {203})) {
                    return new State첫번째꼬마교체Delay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay03 : TriggerState {
            internal State첫번째꼬마교체Delay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State첫번째꼬마교체03(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new[] {100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견04 : TriggerState {
            internal State첫번째힌트발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315}, arg2: true, arg3: 15, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new[] {777501}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000769}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State첫번째힌트수색04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State첫번째힌트수색04 : TriggerState {
            internal State첫번째힌트수색04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000769}, arg2: 0)) {
                    return new State첫번째꼬마발견04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000769}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견04 : TriggerState {
            internal State첫번째꼬마발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$02000331_BF__Seeker01__17$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State첫번째꼬마만남04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마만남04 : TriggerState {
            internal State첫번째꼬마만남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_2204");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9004, arg2: new[] {204})) {
                    return new State첫번째꼬마교체Delay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay04 : TriggerState {
            internal State첫번째꼬마교체Delay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State첫번째꼬마교체04(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9012, arg2: new[] {100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_CreationRandom01 : TriggerState {
            internal StateMonsterSpawn02_CreationRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn02_1TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn02_2TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn02_3TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn02_4TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_1TimedCreation : TriggerState {
            internal StateMonsterSpawn02_1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {9223, 9224, 9225, 921, 922, 924, 925, 927, 928}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_2TimedCreation : TriggerState {
            internal StateMonsterSpawn02_2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {9221, 9223, 9225, 920, 922, 924, 925, 926, 929}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_3TimedCreation : TriggerState {
            internal StateMonsterSpawn02_3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {9221, 9222, 9224, 920, 922, 924, 925, 926, 928}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_4TimedCreation : TriggerState {
            internal StateMonsterSpawn02_4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {9222, 9223, 9225, 922, 923, 925, 926, 927, 929}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class State두명패트롤01 : TriggerState {
            internal State두명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1003");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2002");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9016, arg2: new[] {100})) {
                    return new State두번째덤불Appear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째덤불Appear01 : TriggerState {
            internal State두번째덤불Appear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__24$", arg4: 3, arg5: 0);
                context.CreateMonster(arg1: new[] {91003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {91003})) {
                    return new State두번째덤불Remove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003312);
                context.SetEffect(arg1: new[] {777402}, arg2: true);
            }
        }

        private class State두번째덤불Remove01 : TriggerState {
            internal State두번째덤불Remove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 93330, arg2: true, arg3: "Dead_A");
                context.SetMesh(arg1: new[] {90003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째꼬마찾기시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마찾기시작 : TriggerState {
            internal State두번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__25$", arg4: 3, arg5: 0);
                context.SetEffect(arg1: new[] {777402}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1004");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9005, arg2: new[] {100})) {
                    return new State두번째Monster발견01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(arg1: 93330, arg2: false, arg3: "Dead_A");
            }
        }

        private class State두번째Monster발견01 : TriggerState {
            internal State두번째Monster발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__30$", arg4: 2, arg5: 0);
                context.SetAgent(arg1: new[] {13001, 13002, 13003, 13004, 13005, 13006}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__31$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {9221, 9222, 9223, 9224, 9225, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929})) {
                    return new State두번째꼬마Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마Random : TriggerState {
            internal State두번째꼬마Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State두번째힌트발견01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State두번째힌트발견02(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State두번째힌트발견03(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State두번째힌트발견04(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State두번째힌트발견05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견01 : TriggerState {
            internal State두번째힌트발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(arg1: new[] {3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018}, arg2: true, arg3: 18, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new[] {777502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State두번째힌트수색01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State두번째힌트수색01 : TriggerState {
            internal State두번째힌트수색01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {311}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9301})) {
                    return new State두번째꼬마도움01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움01 : TriggerState {
            internal State두번째꼬마도움01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 311, arg3: "$02000331_BF__Seeker01__33$", arg4: 2, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000771}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마발견01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견01 : TriggerState {
            internal State두번째꼬마발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000771}, arg2: 0)) {
                    return new State두번째꼬마구출01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003313);
                context.SetInteractObject(arg1: new[] {10000771}, arg2: 2);
            }
        }

        private class State두번째꼬마구출01 : TriggerState {
            internal State두번째꼬마구출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 311, arg2: 301);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000331_BF__Seeker01__38$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째꼬마이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동01 : TriggerState {
            internal State두번째꼬마이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 301, arg2: "MS2PatrolData_3301");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마만남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남01 : TriggerState {
            internal State두번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000331_BF__Seeker01__39$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화01 : TriggerState {
            internal State두번째꼬마대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__40$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new[] {301})) {
                    return new State두번째꼬마교체Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay01 : TriggerState {
            internal State두번째꼬마교체Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__41$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째꼬마교체01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new[] {100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견02 : TriggerState {
            internal State두번째힌트발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(arg1: new[] {3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116}, arg2: true, arg3: 16, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new[] {777502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State두번째힌트수색02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State두번째힌트수색02 : TriggerState {
            internal State두번째힌트수색02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {312}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9302})) {
                    return new State두번째꼬마도움02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움02 : TriggerState {
            internal State두번째꼬마도움02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 312, arg3: "$02000331_BF__Seeker01__34$", arg4: 2, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000772}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마발견02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견02 : TriggerState {
            internal State두번째꼬마발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000772}, arg2: 0)) {
                    return new State두번째꼬마구출02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000772}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출02 : TriggerState {
            internal State두번째꼬마구출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 312, arg2: 302);
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02000331_BF__Seeker01__43$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째꼬마이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동02 : TriggerState {
            internal State두번째꼬마이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 302, arg2: "MS2PatrolData_3302");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마만남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남02 : TriggerState {
            internal State두번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$02000331_BF__Seeker01__44$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화02 : TriggerState {
            internal State두번째꼬마대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__45$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new[] {302})) {
                    return new State두번째꼬마교체Delay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay02 : TriggerState {
            internal State두번째꼬마교체Delay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__46$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째꼬마교체02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new[] {100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견03 : TriggerState {
            internal State두번째힌트발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(arg1: new[] {3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221}, arg2: true, arg3: 21, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new[] {777502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State두번째힌트수색03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State두번째힌트수색03 : TriggerState {
            internal State두번째힌트수색03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {313}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9303})) {
                    return new State두번째꼬마도움03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움03 : TriggerState {
            internal State두번째꼬마도움03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 313, arg3: "$02000331_BF__Seeker01__35$", arg4: 2, arg5: 0);
                context.SetInteractObject(arg1: new[] {10000773}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마발견03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견03 : TriggerState {
            internal State두번째꼬마발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000773}, arg2: 0)) {
                    return new State두번째꼬마구출03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000773}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출03 : TriggerState {
            internal State두번째꼬마구출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 313, arg2: 303);
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02000331_BF__Seeker01__48$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째꼬마이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동03 : TriggerState {
            internal State두번째꼬마이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 303, arg2: "MS2PatrolData_3303");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마만남03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남03 : TriggerState {
            internal State두번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 303, arg3: "$02000331_BF__Seeker01__49$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화03 : TriggerState {
            internal State두번째꼬마대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__50$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new[] {303})) {
                    return new State두번째꼬마교체Delay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay03 : TriggerState {
            internal State두번째꼬마교체Delay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__51$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마교체03(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new[] {100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견04 : TriggerState {
            internal State두번째힌트발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetRandomMesh(arg1: new[] {3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318}, arg2: true, arg3: 18, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new[] {777502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State두번째힌트수색04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State두번째힌트수색04 : TriggerState {
            internal State두번째힌트수색04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {314}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9304})) {
                    return new State두번째꼬마도움04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움04 : TriggerState {
            internal State두번째꼬마도움04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000774}, arg2: 1);
                context.SetConversation(arg1: 1, arg2: 314, arg3: "$02000331_BF__Seeker01__36$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마발견04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견04 : TriggerState {
            internal State두번째꼬마발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000774}, arg2: 0)) {
                    return new State두번째꼬마구출04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000774}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출04 : TriggerState {
            internal State두번째꼬마구출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 314, arg2: 304);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마이동04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동04 : TriggerState {
            internal State두번째꼬마이동04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 304, arg2: "MS2PatrolData_3304");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마만남04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남04 : TriggerState {
            internal State두번째꼬마만남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 304, arg3: "$02000331_BF__Seeker01__54$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화04 : TriggerState {
            internal State두번째꼬마대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__55$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new[] {304})) {
                    return new State두번째꼬마교체Delay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay04 : TriggerState {
            internal State두번째꼬마교체Delay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__56$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째꼬마교체04(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new[] {100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견05 : TriggerState {
            internal State두번째힌트발견05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_997");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2013");
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__800$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.SetRandomMesh(arg1: new[] {3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419}, arg2: true, arg3: 19, arg4: 50, arg5: 50);
                context.SetEffect(arg1: new[] {777502}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State두번째힌트수색05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003313, textId: 20003313);
            }
        }

        private class State두번째힌트수색05 : TriggerState {
            internal State두번째힌트수색05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {315}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9305})) {
                    return new State두번째꼬마도움05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움05 : TriggerState {
            internal State두번째꼬마도움05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000775}, arg2: 1);
                context.SetConversation(arg1: 1, arg2: 315, arg3: "$02000331_BF__Seeker01__37$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                return new State두번째꼬마발견05(context);
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견05 : TriggerState {
            internal State두번째꼬마발견05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000775}, arg2: 0)) {
                    return new State두번째꼬마구출05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10000775}, arg2: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출05 : TriggerState {
            internal State두번째꼬마구출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 315, arg2: 305);
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02000331_BF__Seeker01__58$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마이동05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마이동05 : TriggerState {
            internal State두번째꼬마이동05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 305, arg2: "MS2PatrolData_3305");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마만남05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마만남05 : TriggerState {
            internal State두번째꼬마만남05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 305, arg3: "$02000331_BF__Seeker01__59$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State두번째꼬마대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마대화05 : TriggerState {
            internal State두번째꼬마대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__60$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9006, arg2: new[] {305})) {
                    return new State두번째꼬마교체Delay05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay05 : TriggerState {
            internal State두번째꼬마교체Delay05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__61$", arg4: 2, arg5: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State두번째꼬마교체05(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9007, arg2: new[] {100})) {
                    return new State세명패트롤01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9008, arg2: new[] {100})) {
                    return new State세명패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세명패트롤02 : TriggerState {
            internal State세명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__70$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세번째덤불Appear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째덤불Appear01 : TriggerState {
            internal State세번째덤불Appear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.CreateMonster(arg1: new[] {91004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {91004})) {
                    return new State세번째덤불Appear02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {777403}, arg2: true);
            }
        }

        private class State세번째덤불Appear02 : TriggerState {
            internal State세번째덤불Appear02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1006");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2005");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3003");
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__71$", arg4: 2, arg5: 0);
                context.CreateMonster(arg1: new[] {91005}, arg2: false);
                context.SetMesh(arg1: new[] {90004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 94440, arg2: true, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {91005})) {
                    return new State세번째덤불Appear03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003312);
                context.SetEffect(arg1: new[] {777404}, arg2: true);
            }
        }

        private class State세번째덤불Appear03 : TriggerState {
            internal State세번째덤불Appear03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__72$", arg4: 2, arg5: 0);
                context.SetMesh(arg1: new[] {90005}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 94450, arg2: true, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세번째꼬마찾기시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마찾기시작 : TriggerState {
            internal State세번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {777403, 777404}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__73$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1016");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2015");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3013");
                context.SetActor(arg1: 94440, arg2: false, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State꼬마셋대화연출01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State세명패트롤03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세명패트롤03 : TriggerState {
            internal State세명패트롤03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9009, arg2: new[] {100})) {
                    return new State세번째스위치Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째스위치Random : TriggerState {
            internal State세번째스위치Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State세번째스위치출현01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State세번째스위치출현02(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State세번째스위치출현03(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State세번째스위치출현04(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State세번째스위치출현05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째스위치출현01 : TriggerState {
            internal State세번째스위치출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000784}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new State고립StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic01 : TriggerState {
            internal State고립StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State고립StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고립StopCinematic01 : TriggerState {
            internal State고립StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내01_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State구출안내01_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내01_01 : TriggerState {
            internal State구출안내01_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구출안내01_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }
        }

        private class State구출안내01_02 : TriggerState {
            internal State구출안내01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내01_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내01_03 : TriggerState {
            internal State구출안내01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내01_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내01_04 : TriggerState {
            internal State구출안내01_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000784}, arg2: 0)) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State세번째스위치출현02 : TriggerState {
            internal State세번째스위치출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000792}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new State고립StartCinematic02(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic02 : TriggerState {
            internal State고립StartCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료02");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State고립StopCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고립StopCinematic02 : TriggerState {
            internal State고립StopCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내02_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State구출안내02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내02_01 : TriggerState {
            internal State구출안내02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구출안내02_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }
        }

        private class State구출안내02_02 : TriggerState {
            internal State구출안내02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내02_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내02_03 : TriggerState {
            internal State구출안내02_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내02_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내02_04 : TriggerState {
            internal State구출안내02_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000792}, arg2: 0)) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State세번째스위치출현03 : TriggerState {
            internal State세번째스위치출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000793}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new State고립StartCinematic03(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic03 : TriggerState {
            internal State고립StartCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State고립StopCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고립StopCinematic03 : TriggerState {
            internal State고립StopCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내03_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State구출안내03_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내03_01 : TriggerState {
            internal State구출안내03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구출안내03_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }
        }

        private class State구출안내03_02 : TriggerState {
            internal State구출안내03_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내03_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내03_03 : TriggerState {
            internal State구출안내03_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내03_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내03_04 : TriggerState {
            internal State구출안내03_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000793}, arg2: 0)) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State세번째스위치출현04 : TriggerState {
            internal State세번째스위치출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000794}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new State고립StartCinematic04(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic04 : TriggerState {
            internal State고립StartCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료04");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State고립StopCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고립StopCinematic04 : TriggerState {
            internal State고립StopCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내04_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State구출안내04_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내04_01 : TriggerState {
            internal State구출안내04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구출안내04_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }
        }

        private class State구출안내04_02 : TriggerState {
            internal State구출안내04_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내04_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내04_03 : TriggerState {
            internal State구출안내04_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내04_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내04_04 : TriggerState {
            internal State구출안내04_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000794}, arg2: 0)) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State세번째스위치출현05 : TriggerState {
            internal State세번째스위치출현05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000795}, arg2: 1);
            }

            public override TriggerState Execute() {
                return new State고립StartCinematic05(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic05 : TriggerState {
            internal State고립StartCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(arg1: 804, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1007");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2006");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3004");
                context.SetSkip(arg1: "고립연출종료05");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State고립StopCinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State고립StopCinematic05 : TriggerState {
            internal State고립StopCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 804, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "구출안내05_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State구출안내05_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내05_01 : TriggerState {
            internal State구출안내05_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__802$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구출안내05_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }
        }

        private class State구출안내05_02 : TriggerState {
            internal State구출안내05_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내05_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내05_03 : TriggerState {
            internal State구출안내05_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구출안내05_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구출안내05_04 : TriggerState {
            internal State구출안내05_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000795}, arg2: 0)) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(arg1: 401, arg2: 400);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State세번째꼬마탈출(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마탈출 : TriggerState {
            internal State세번째꼬마탈출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__83$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4001");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9010, arg2: new[] {400})) {
                    return new State세번째꼬마만남01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State세번째꼬마만남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마만남02 : TriggerState {
            internal State세번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__85$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세번째꼬마만남03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마만남03 : TriggerState {
            internal State세번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__86$", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State네명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네명패트롤01 : TriggerState {
            internal State네명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__87$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1009");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9011, arg2: new[] {100})) {
                    return new State네명패트롤02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9017, arg2: new[] {100})) {
                    return new State네번째덤불Appear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째덤불Appear01 : TriggerState {
            internal State네번째덤불Appear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.CreateMonster(arg1: new[] {91006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {91006})) {
                    return new State네번째덤불Remove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003312);
                context.SetEffect(arg1: new[] {777405}, arg2: true);
            }
        }

        private class State네번째덤불Remove01 : TriggerState {
            internal State네번째덤불Remove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 96660, arg2: true, arg3: "Dead_A");
                context.SetMesh(arg1: new[] {90006}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State네번째꼬마찾기시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마찾기시작 : TriggerState {
            internal State네번째꼬마찾기시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "401", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__89$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new[] {777405}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1010");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2009");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_3007");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_4003");
                context.SetActor(arg1: 96660, arg2: false, arg3: "Dead_A");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9013, arg2: new[] {100})) {
                    return new StateMonsterSpawn05_꼬마Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_꼬마Creation : TriggerState {
            internal StateMonsterSpawn05_꼬마Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {500}, arg2: false);
                context.MoveNpc(arg1: 500, arg2: "MS2PatrolData_5001");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn05_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_CreationRandom01 : TriggerState {
            internal StateMonsterSpawn05_CreationRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_1번대장Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_2번대장Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_3번대장Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_4번대장Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_1번대장Creation : TriggerState {
            internal StateMonsterSpawn05_1번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {991}, arg2: false);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_905");
            }

            public override TriggerState Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_2번대장Creation : TriggerState {
            internal StateMonsterSpawn05_2번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {992}, arg2: false);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_905");
            }

            public override TriggerState Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_3번대장Creation : TriggerState {
            internal StateMonsterSpawn05_3번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {992}, arg2: false);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_905");
            }

            public override TriggerState Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_4번대장Creation : TriggerState {
            internal StateMonsterSpawn05_4번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {991}, arg2: false);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_905");
            }

            public override TriggerState Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_CreationRandom02 : TriggerState {
            internal StateMonsterSpawn05_CreationRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_1번자코Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_2번자코Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_3번자코Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_4번자코Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_1번자코Creation : TriggerState {
            internal StateMonsterSpawn05_1번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5001", arg2: 1);
                context.CreateMonster(arg1: new[] {930}, arg2: false);
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new[] {935}, arg2: false);
                context.MoveNpc(arg1: 935, arg2: "MS2PatrolData_904");
                context.CreateMonster(arg1: new[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_906");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5001")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_2번자코Creation : TriggerState {
            internal StateMonsterSpawn05_2번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5002", arg2: 1);
                context.CreateMonster(arg1: new[] {931}, arg2: false);
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_902");
                context.CreateMonster(arg1: new[] {936}, arg2: false);
                context.MoveNpc(arg1: 936, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_907");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5002")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_3번자코Creation : TriggerState {
            internal StateMonsterSpawn05_3번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5003", arg2: 1);
                context.CreateMonster(arg1: new[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_903");
                context.CreateMonster(arg1: new[] {938}, arg2: false);
                context.MoveNpc(arg1: 938, arg2: "MS2PatrolData_907");
                context.CreateMonster(arg1: new[] {936}, arg2: false);
                context.MoveNpc(arg1: 936, arg2: "MS2PatrolData_901");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5003")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_4번자코Creation : TriggerState {
            internal StateMonsterSpawn05_4번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5004", arg2: 1);
                context.CreateMonster(arg1: new[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_905");
                context.CreateMonster(arg1: new[] {934}, arg2: false);
                context.MoveNpc(arg1: 934, arg2: "MS2PatrolData_903");
                context.CreateMonster(arg1: new[] {938}, arg2: false);
                context.MoveNpc(arg1: 938, arg2: "MS2PatrolData_906");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5004")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_CreationRandom03 : TriggerState {
            internal StateMonsterSpawn05_CreationRandom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_5번대장Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_6번대장Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_7번대장Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_8번대장Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_5번대장Creation : TriggerState {
            internal StateMonsterSpawn05_5번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {991}, arg2: false);
                context.MoveNpc(arg1: 991, arg2: "MS2PatrolData_904");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn05_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_6번대장Creation : TriggerState {
            internal StateMonsterSpawn05_6번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {992}, arg2: false);
                context.MoveNpc(arg1: 992, arg2: "MS2PatrolData_904");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn05_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_7번대장Creation : TriggerState {
            internal StateMonsterSpawn05_7번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {993}, arg2: false);
                context.MoveNpc(arg1: 993, arg2: "MS2PatrolData_904");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn05_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_8번대장Creation : TriggerState {
            internal StateMonsterSpawn05_8번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {994}, arg2: false);
                context.MoveNpc(arg1: 994, arg2: "MS2PatrolData_904");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn05_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_CreationRandom04 : TriggerState {
            internal StateMonsterSpawn05_CreationRandom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_5번자코Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_6번자코Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_7번자코Creation(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new StateMonsterSpawn05_8번자코Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_5번자코Creation : TriggerState {
            internal StateMonsterSpawn05_5번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {930}, arg2: false);
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_902");
                context.CreateMonster(arg1: new[] {935}, arg2: false);
                context.MoveNpc(arg1: 935, arg2: "MS2PatrolData_905");
                context.CreateMonster(arg1: new[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_909");
            }

            public override TriggerState Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_6번자코Creation : TriggerState {
            internal StateMonsterSpawn05_6번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {931}, arg2: false);
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new[] {934}, arg2: false);
                context.MoveNpc(arg1: 934, arg2: "MS2PatrolData_909");
                context.CreateMonster(arg1: new[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_907");
            }

            public override TriggerState Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_7번자코Creation : TriggerState {
            internal StateMonsterSpawn05_7번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_903");
                context.CreateMonster(arg1: new[] {935}, arg2: false);
                context.MoveNpc(arg1: 935, arg2: "MS2PatrolData_904");
                context.CreateMonster(arg1: new[] {936}, arg2: false);
                context.MoveNpc(arg1: 936, arg2: "MS2PatrolData_901");
            }

            public override TriggerState Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_8번자코Creation : TriggerState {
            internal StateMonsterSpawn05_8번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {932}, arg2: false);
                context.MoveNpc(arg1: 932, arg2: "MS2PatrolData_906");
                context.CreateMonster(arg1: new[] {934}, arg2: false);
                context.MoveNpc(arg1: 934, arg2: "MS2PatrolData_901");
                context.CreateMonster(arg1: new[] {937}, arg2: false);
                context.MoveNpc(arg1: 937, arg2: "MS2PatrolData_907");
            }

            public override TriggerState Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class State추격StartCinematic01 : TriggerState {
            internal State추격StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7776}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__902$");
                context.CameraSelect(arg1: 800, arg2: true);
                context.SetSkip(arg1: "추격연출종료01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State추격StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State추격StopCinematic01 : TriggerState {
            internal State추격StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__803$", arg3: 2000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.CameraSelect(arg1: 800, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__90$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__91$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 500, arg3: "$02000331_BF__Seeker01__92$", arg4: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {930, 931, 932, 933, 934, 935, 936, 937, 938, 991, 992, 993, 994})) {
                    return new State네번째꼬마만남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남01 : TriggerState {
            internal State네번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7776}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 500, arg3: "$02000331_BF__Seeker01__93$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State네번째꼬마만남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남02 : TriggerState {
            internal State네번째꼬마만남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 200, arg3: "$02000331_BF__Seeker01__94$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State네번째꼬마만남03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남03 : TriggerState {
            internal State네번째꼬마만남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__95$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State네번째꼬마만남04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남04 : TriggerState {
            internal State네번째꼬마만남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__96$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State다섯명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯명패트롤01 : TriggerState {
            internal State다섯명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__97$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1011");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9014, arg2: new[] {100})) {
                    return new State다섯명패트롤02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9015, arg2: new[] {100})) {
                    return new State두번째무너짐StartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째무너짐StartCinematic01 : TriggerState {
            internal State두번째무너짐StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__903$");
                context.CameraSelect(arg1: 806, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째다리붕괴02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째다리붕괴02 : TriggerState {
            internal State두번째다리붕괴02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033}, arg2: false, arg3: 14, arg4: 100, arg5: 100);
                context.SetEffect(arg1: new[] {777803}, arg2: true);
                context.SetAgent(arg1: new[] {15000, 15001, 15002}, arg2: true);
                context.SetSkip(arg1: "두번째무너짐연출종료01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State두번째무너짐StopCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째무너짐StopCinematic01 : TriggerState {
            internal State두번째무너짐StopCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 806, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetSkip(arg1: "술래말풍선06");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State술래말풍선06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래말풍선06 : TriggerState {
            internal State술래말풍선06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {777803}, arg2: false);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1012");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_2011");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State술래말풍선07(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State술래말풍선08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래말풍선08 : TriggerState {
            internal State술래말풍선08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 500, arg3: "$02000331_BF__Seeker01__102$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State술래말풍선09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래말풍선09 : TriggerState {
            internal State술래말풍선09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__103$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State술래말풍선10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State술래말풍선10 : TriggerState {
            internal State술래말풍선10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 400, arg3: "$02000331_BF__Seeker01__104$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 300, arg3: "$02000331_BF__Seeker01__105$", arg4: 2, arg5: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State외다리CreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리CreationRandom : TriggerState {
            internal State외다리CreationRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State외다리스위치출현01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State외다리스위치출현02(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State외다리스위치출현03(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State외다리스위치출현04(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State외다리스위치출현05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치출현01 : TriggerState {
            internal State외다리스위치출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000785}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000785}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State외다리스위치반응01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응01 : TriggerState {
            internal State외다리스위치반응01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000785})) {
                    return new State외다리Creation시작01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State외다리스위치출현02 : TriggerState {
            internal State외다리스위치출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000796}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000796}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State외다리스위치반응02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응02 : TriggerState {
            internal State외다리스위치반응02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000796})) {
                    return new State외다리Creation시작01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State외다리스위치출현03 : TriggerState {
            internal State외다리스위치출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000797}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000797}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State외다리스위치반응03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응03 : TriggerState {
            internal State외다리스위치반응03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000797})) {
                    return new State외다리Creation시작01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State외다리스위치출현04 : TriggerState {
            internal State외다리스위치출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000798}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000798}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State외다리스위치반응04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응04 : TriggerState {
            internal State외다리스위치반응04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000798})) {
                    return new State외다리Creation시작01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State외다리스위치출현05 : TriggerState {
            internal State외다리스위치출현05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000799}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000799}, arg2: 1);
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__804$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State외다리스위치반응05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치반응05 : TriggerState {
            internal State외다리스위치반응05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003314, textId: 20003314);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000799})) {
                    return new State외다리Creation시작01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003314);
            }
        }

        private class State외다리Creation시작01 : TriggerState {
            internal State외다리Creation시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {90008}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {777702}, arg2: true);
                context.SetRandomMesh(arg1: new[] {10040, 10041, 10042, 10043, 10044}, arg2: true, arg3: 5, arg4: 150, arg5: 150);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다리건너갈준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너갈준비01 : TriggerState {
            internal State다리건너갈준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__805$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.MoveNpc(arg1: 100, arg2: "MS2PatrolData_1013");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다리건너갈준비02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너갈준비02 : TriggerState {
            internal State다리건너갈준비02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 100, arg3: "$02000331_BF__Seeker01__110$", arg4: 2, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {99992})) {
                    return new State다리건너가기01(context);
                }

                if (context.UserDetected(arg1: new[] {99993})) {
                    return new State다리건너가기01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State다리건너가기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너가기02 : TriggerState {
            internal State다리건너가기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {99996})) {
                    return new State다리건너가기03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너가기03 : TriggerState {
            internal State다리건너가기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 610, arg3: "$02000331_BF__Seeker01__112$", arg4: 3, arg5: 0);
                context.SetMesh(arg1: new[] {90008}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State다리건너가기04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너가기04 : TriggerState {
            internal State다리건너가기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9018, arg2: new[] {300})) {
                    return new StateBossSpawnStartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnStartCinematic01 : TriggerState {
            internal StateBossSpawnStartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {990}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__904$");
                context.SetEffect(arg1: new[] {777901}, arg2: true);
                context.CameraSelect(arg1: 808, arg2: true);
                context.SetSkip(arg1: "BossSpawnCinematic중01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawnCinematic중01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중01 : TriggerState {
            internal StateBossSpawnCinematic중01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__905$");
                context.SetSkip(arg1: "BossSpawnCinematic중01Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawnCinematic중01Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중01Skip : TriggerState {
            internal StateBossSpawnCinematic중01Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateBossSpawnCinematic중02(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중02 : TriggerState {
            internal StateBossSpawnCinematic중02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__906$");
                context.ChangeMonster(arg1: 100, arg2: 601);
                context.ChangeMonster(arg1: 200, arg2: 602);
                context.ChangeMonster(arg1: 300, arg2: 603);
                context.ChangeMonster(arg1: 400, arg2: 604);
                context.ChangeMonster(arg1: 500, arg2: 605);
                context.CameraSelect(arg1: 809, arg2: true);
                context.SetSkip(arg1: "BossSpawnCinematic중02Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossSpawnCinematic중02Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중02Skip : TriggerState {
            internal StateBossSpawnCinematic중02Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateBossSpawnCinematic중03(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중03 : TriggerState {
            internal StateBossSpawnCinematic중03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {10040, 10041, 10042, 10043, 10044}, arg2: false, arg3: 5, arg4: 150, arg5: 150);
                context.SetEffect(arg1: new[] {777802}, arg2: true);
                context.SetAgent(arg1: new[] {16000, 16001, 16002, 16003, 16004}, arg2: true);
                context.SetSkip(arg1: "BossSpawnCinematic중03Skip");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossSpawnCinematic중03Skip(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중03Skip : TriggerState {
            internal StateBossSpawnCinematic중03Skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateBossSpawnCinematic중04(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중04 : TriggerState {
            internal StateBossSpawnCinematic중04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 809, arg2: false);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__907$");
                context.SetEffect(arg1: new[] {777901}, arg2: false);
                context.SetEffect(arg1: new[] {777902}, arg2: true);
                context.SetSkip(arg1: "BossSpawnCinematic끝01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawnCinematic끝01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic끝01 : TriggerState {
            internal StateBossSpawnCinematic끝01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 808, arg2: false);
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new[] {777802}, arg2: false);
                context.SetUserValue(triggerId: 15, key: "SecondBridgeOff", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막웨이브알림01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막웨이브알림01 : TriggerState {
            internal State마지막웨이브알림01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__806$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMonsterSpawn06_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_CreationRandom01 : TriggerState {
            internal StateMonsterSpawn06_CreationRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_1TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_2TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_3TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_4TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_5TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_1TimedCreation : TriggerState {
            internal StateMonsterSpawn06_1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {940, 941, 950, 951}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_2TimedCreation : TriggerState {
            internal StateMonsterSpawn06_2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {942, 943, 952, 953}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_3TimedCreation : TriggerState {
            internal StateMonsterSpawn06_3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6003", arg2: 1);
                context.CreateMonster(arg1: new[] {944, 945, 954, 955}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_4TimedCreation : TriggerState {
            internal StateMonsterSpawn06_4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {946, 947, 956, 957}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_5TimedCreation : TriggerState {
            internal StateMonsterSpawn06_5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {948, 949, 958, 959}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_CreationRandom02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_CreationRandom02 : TriggerState {
            internal StateMonsterSpawn06_CreationRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_6TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_7TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_8TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_9TimedCreation(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_10TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_6TimedCreation : TriggerState {
            internal StateMonsterSpawn06_6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {960, 961, 962, 963}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_7TimedCreation : TriggerState {
            internal StateMonsterSpawn06_7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {962, 963, 964, 965}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_8TimedCreation : TriggerState {
            internal StateMonsterSpawn06_8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 966, 967}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_9TimedCreation : TriggerState {
            internal StateMonsterSpawn06_9TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {966, 967, 968, 969}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_10TimedCreation : TriggerState {
            internal StateMonsterSpawn06_10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {968, 969, 960, 961}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째웨이브대기 : TriggerState {
            internal State두번째웨이브대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMonsterSpawn06_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_CreationRandom03 : TriggerState {
            internal StateMonsterSpawn06_CreationRandom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_11TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_12TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_13TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_14TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_15TimedCreation_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {940, 941, 971}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_11TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {950, 951, 970}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_11TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {960, 961, 962}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_11TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {945, 946, 976}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_11TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {955, 956, 957}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateMonsterSpawn06_11TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {965, 966, 975}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {958, 959, 978}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_12TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {968, 969, 960}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_12TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {948, 949, 979}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_12TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {943, 944, 945, 975}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_12TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {953, 954}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_12TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 974}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {946, 947}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_13TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {955, 956, 957, 976}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_13TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {965, 966, 967, 977}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_13TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {969, 960, 979}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_13TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {949, 940, 970}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_13TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {950, 959}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {941, 942, 972}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_14TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {961, 962, 963}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_14TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {951, 952, 953}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_14TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 974}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_14TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {944, 946, 975}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_14TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {955, 956, 976}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {948, 949, 979}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_15TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {968, 969, 960, 978}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_15TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {948, 949}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_15TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {963, 964, 973}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_15TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {953, 954, 955, 974}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_15TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {943, 944}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_CreationRandom04 : TriggerState {
            internal StateMonsterSpawn06_CreationRandom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateMonsterSpawn06_16TimedCreation_01(context);

                /*if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_16TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_17TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_18TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_19TimedCreation_01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateMonsterSpawn06_20TimedCreation_01(context);
                }

                return null;*/
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {941, 942, 971}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_16TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {951, 953}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_16TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {954, 955, 956, 986}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_16TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 985}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_16TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {953, 954}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_16TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 974}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_16TimedCreation_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_07 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {947, 948, 949, 988}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_16TimedCreation_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_16TimedCreation_08 : TriggerState {
            internal StateMonsterSpawn06_16TimedCreation_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {967, 968, 987}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {954, 955, 956, 986}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_17TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 985}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_17TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {941, 942, 971}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_17TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {951, 953}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_17TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {947, 948, 949, 988}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_17TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {967, 968, 987}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_17TimedCreation_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_07 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {953, 954}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_17TimedCreation_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_08 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {964, 965, 974}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {959, 958}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_18TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {949, 940, 970}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_18TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {953, 954, 955, 983}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_18TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {943, 945, 984}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_18TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {961, 962}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_18TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {952, 953, 972}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_18TimedCreation_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_07 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {945, 946, 947, 985}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_18TimedCreation_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_08 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {966, 967, 986}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {943, 944, 945, 974}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_19TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {963, 965}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_19TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {951, 950, 980}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_19TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {941, 942, 981}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_19TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {957, 958}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_19TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {966, 968, 977}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_19TimedCreation_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_07 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {948, 949, 989}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_19TimedCreation_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_08 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {959, 958, 988}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {967, 968, 969}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_20TimedCreation_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_02 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {957, 959, 978}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_20TimedCreation_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_03 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {953, 954, 984}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_20TimedCreation_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_04 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {943, 944, 983}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_20TimedCreation_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_05 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {951, 952, 950}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_20TimedCreation_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_06 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {962, 961, 970}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateMonsterSpawn06_20TimedCreation_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_07 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {946, 947, 986}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonsterSpawn06_20TimedCreation_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_08 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {955, 956, 985}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatSetup01 : TriggerState {
            internal StateBossCombatSetup01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossCombatSetup02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatSetup02 : TriggerState {
            internal StateBossCombatSetup02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 811, arg2: true);
                context.SetSkip(arg1: "Boss투_준비04");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBossCombatSetup03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatSetup03 : TriggerState {
            internal StateBossCombatSetup03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__908$");
                context.SetEffect(arg1: new[] {777902}, arg2: false);
                context.SetEffect(arg1: new[] {777903}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossCombatSetup04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatSetup04 : TriggerState {
            internal StateBossCombatSetup04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 811, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossCombatStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatStart01 : TriggerState {
            internal StateBossCombatStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {990});
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__807$", arg3: 3000, arg4: "0");
                context.SetEffect(arg1: new[] {7771}, arg2: true);
                context.CreateMonster(arg1: new[] {999}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {999})) {
                    return new StateBoss도망준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망준비01 : TriggerState {
            internal StateBoss도망준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss도망연출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망연출01 : TriggerState {
            internal StateBoss도망연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1000}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000776}, arg2: 0);
                context.SetInteractObject(arg1: new[] {10000776}, arg2: 1);
                context.SetActor(arg1: 97770, arg2: false, arg3: "Closed");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__909$");
                context.CameraSelect(arg1: 812, arg2: true);
                context.SetSkip(arg1: "Boss도망연출03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss도망연출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망연출02 : TriggerState {
            internal StateBoss도망연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3, arg2: "$02000331_BF__Seeker01__910$");
                context.SetEffect(arg1: new[] {777903}, arg2: false);
                context.SetEffect(arg1: new[] {777904}, arg2: true);
                context.SetSkip(arg1: "Boss도망연출03");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss도망연출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망연출03 : TriggerState {
            internal StateBoss도망연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 812, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ChangeMonster(arg1: 610, arg2: 600);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBossCombatEnd01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatEnd01 : TriggerState {
            internal StateBossCombatEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000331_BF__Seeker01__808$", arg3: 3000, arg4: "0");
                context.SetConversation(arg1: 1, arg2: 600, arg3: "$02000331_BF__Seeker01__120$", arg4: 2, arg5: 1);
                context.DestroyMonster(arg1: new[] {1000});
                context.SetEffect(arg1: new[] {7771}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막연출_준비01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막연출_준비01 : TriggerState {
            internal State마지막연출_준비01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003315, textId: 20003315);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000776})) {
                    return new State마지막연출_포털출현01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003315);
                context.SetInteractObject(arg1: new[] {10000776}, arg2: 0);
            }
        }

        private class State마지막연출_포털출현01 : TriggerState {
            internal State마지막연출_포털출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "$02000331_BF__Seeker01__809$", arg3: 3000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막연출_포털출현02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막연출_포털출현02 : TriggerState {
            internal State마지막연출_포털출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 600, arg2: "MS2PatrolData_6001");
                context.SetEffect(arg1: new[] {777904}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막연출_포털출현03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막연출_포털출현03 : TriggerState {
            internal State마지막연출_포털출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 600, arg3: "$02000331_BF__Seeker01__130$", arg4: 2, arg5: 0);
                context.SetEffect(arg1: new[] {99999, 7772}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9020, arg2: new[] {600})) {
                    return new State마지막연출_포털출현04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막연출_포털출현04 : TriggerState {
            internal State마지막연출_포털출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {99999}, arg2: false);
                context.ChangeMonster(arg1: 601, arg2: 110);
                context.ChangeMonster(arg1: 602, arg2: 210);
                context.ChangeMonster(arg1: 603, arg2: 310);
                context.ChangeMonster(arg1: 604, arg2: 410);
                context.ChangeMonster(arg1: 605, arg2: 510);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막연출_시작01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막연출_시작02(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateDungeonClear01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonClear01 : TriggerState {
            internal StateDungeonClear01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {90090, 90091, 90092, 90093, 90094, 90095, 90096, 90097, 90098, 90099}, arg2: false, arg3: 10, arg4: 100, arg5: 100);
                context.ChangeMonster(arg1: 110, arg2: 111);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State퇴장시작01(context);
                }

                return null;
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {11000, 11001, 15000, 15001, 15002, 16000, 16001, 16002, 16003, 16004}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
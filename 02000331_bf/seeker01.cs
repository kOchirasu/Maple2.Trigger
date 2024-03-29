using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000331_bf {
    public static class _seeker01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{11000, 11001}, visible: false);
                context.SetAgent(triggerIds: new []{13001, 13002, 13003, 13004, 13005, 13006}, visible: true);
                context.SetAgent(triggerIds: new []{15000, 15001, 15002, 16000, 16001, 16002, 16003, 16004}, visible: false);
                context.SetMesh(triggerIds: new []{90000, 90001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{90002, 90003, 90004, 90005, 90006, 90007, 90008, 98880}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{89999}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 92220, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 92221, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 92222, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 92223, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 92224, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 93330, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 93331, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 93332, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 93333, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 93334, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94440, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94441, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94442, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94443, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94444, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94445, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94446, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94447, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94448, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94449, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94450, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94451, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94452, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94453, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 94454, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 96660, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 96661, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 96662, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 96663, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 96664, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 97770, visible: true, initialSequence: "Closed");
                context.SetMesh(triggerIds: new []{10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{10040, 10041, 10042, 10043, 10044, 2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{90090, 90091, 90092, 90093, 90094, 90095, 90096, 90097, 90098, 90099}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000766, 10000767, 10000768, 10000769, 10000771, 10000772, 10000773, 10000774, 10000775, 10000784, 10000792, 10000793, 10000794, 10000795, 10000785, 10000796, 10000797, 10000798, 10000799, 10000776}, state: 2);
                context.CreateMonster(spawnIds: new []{401, 610}, arg2: false);
                context.SetEffect(triggerIds: new []{99999, 7771, 7772, 777401, 777402, 777403, 777404, 777405, 777501, 777502, 7776, 777701, 777702, 777801, 777802, 777803, 777901, 777902, 777903, 777904}, visible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{100}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 4000, visible: true, initialSequence: "Opened");
                context.SetMesh(triggerIds: new []{89999}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__0$", arg4: 2, arg5: 0);
                context.SetMesh(triggerIds: new []{90000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9002, spawnIds: new []{100})) {
                    return new StateMonsterSpawn01_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_시작 : TriggerState {
            internal StateMonsterSpawn01_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4000, visible: false, initialSequence: "Opened");
                context.HideGuideSummary(entityId: 20003311);
                context.CreateMonster(spawnIds: new []{900}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__1$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateMonsterSpawn01_Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_Cinematic02 : TriggerState {
            internal StateMonsterSpawn01_Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_1TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_2TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_3TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_4TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_1TimedCreation : TriggerState {
            internal StateMonsterSpawn01_1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902}, arg2: false);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__801$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{902, 904}, arg2: false);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__801$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{903, 905}, arg2: false);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__801$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{901, 905}, arg2: false);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__801$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_5TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_6TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_7TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_8TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_5TimedCreation : TriggerState {
            internal StateMonsterSpawn01_5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{905, 906, 907}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{906, 907, 909}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{907, 909, 910}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{907, 908, 909}, arg2: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_9TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_10TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_11TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn01_12TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_9TimedCreation : TriggerState {
            internal StateMonsterSpawn01_9TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 902, 903}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_10TimedCreation : TriggerState {
            internal StateMonsterSpawn01_10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{902, 903, 904}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_11TimedCreation : TriggerState {
            internal StateMonsterSpawn01_11TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{901, 904, 905}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_12TimedCreation : TriggerState {
            internal StateMonsterSpawn01_12TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{903, 904, 905}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910})) {
                    return new StateMonsterSpawn01_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn01_종료 : TriggerState {
            internal StateMonsterSpawn01_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__2$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetAgent(triggerIds: new []{11000, 11001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99990})) {
                    return new State첫번째무너짐StartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째무너짐StartCinematic01 : TriggerState {
            internal State첫번째무너짐StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__900$");
                context.CameraSelect(triggerId: 802, enabled: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_999");
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016}, visible: false, meshCount: 16, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777801}, visible: true);
                context.SetMesh(triggerIds: new []{90001, 90000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkip(state: new State첫번째무너짐StopCinematic01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{777801}, visible: false);
                context.CameraSelect(triggerId: 802, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip();
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__3$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__4$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1001");
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__24$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{91002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State첫번째덤불Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째덤불Spawn01 : TriggerState {
            internal State첫번째덤불Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91002})) {
                    return new State첫번째덤불Remove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{777401}, visible: true);
                context.HideGuideSummary(entityId: 20003312);
            }
        }

        private class State첫번째덤불Remove01 : TriggerState {
            internal State첫번째덤불Remove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 92220, visible: true, initialSequence: "Dead_A");
                context.SetMesh(triggerIds: new []{90002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__6$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetActor(triggerId: 92000, visible: false, initialSequence: "Dead_A");
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9003, spawnIds: new []{100})) {
                    return new State첫번째꼬마Random(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 92220, visible: false, initialSequence: "Dead_A");
                context.SetEffect(triggerIds: new []{777401}, visible: false);
            }
        }

        private class State첫번째꼬마Random : TriggerState {
            internal State첫번째꼬마Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new State첫번째힌트발견01(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State첫번째힌트발견02(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State첫번째힌트발견03(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new State첫번째힌트발견04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견01 : TriggerState {
            internal State첫번째힌트발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2001, 2002, 2003, 2004, 2005, 2006, 2007, 2008, 2009, 2010, 2011, 2012, 2013, 2014, 2015, 2016}, visible: true, meshCount: 16, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777501}, visible: true);
                context.SetInteractObject(interactIds: new []{10000766}, state: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000766}, arg2: 0)) {
                    return new State첫번째꼬마발견01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000766}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견01 : TriggerState {
            internal State첫번째꼬마발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.SetConversation(type: 1, spawnId: 201, script: "$02000331_BF__Seeker01__11$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_2201");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{201})) {
                    return new State첫번째꼬마교체Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay01 : TriggerState {
            internal State첫번째꼬마교체Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 201, addSpawnId: 200);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_998");
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__13$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__14$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9012, spawnIds: new []{100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견02 : TriggerState {
            internal State첫번째힌트발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108, 2109, 2110, 2111, 2112, 2113, 2114, 2115, 2116, 2117}, visible: true, meshCount: 17, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777501}, visible: true);
                context.SetInteractObject(interactIds: new []{10000767}, state: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000767}, arg2: 0)) {
                    return new State첫번째꼬마발견02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000767}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견02 : TriggerState {
            internal State첫번째꼬마발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: false);
                context.SetConversation(type: 1, spawnId: 202, script: "$02000331_BF__Seeker01__15$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_2202");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{202})) {
                    return new State첫번째꼬마교체Delay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay02 : TriggerState {
            internal State첫번째꼬마교체Delay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 202, addSpawnId: 200);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_998");
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__18$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__19$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9012, spawnIds: new []{100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견03 : TriggerState {
            internal State첫번째힌트발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208, 2209, 2210, 2211, 2212, 2213, 2214, 2215, 2216, 2217, 2218, 2219, 2220}, visible: true, meshCount: 20, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777501}, visible: true);
                context.SetInteractObject(interactIds: new []{10000768}, state: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000768}, arg2: 0)) {
                    return new State첫번째꼬마발견03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000768}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견03 : TriggerState {
            internal State첫번째꼬마발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
                context.SetConversation(type: 1, spawnId: 203, script: "$02000331_BF__Seeker01__16$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_2203");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{203})) {
                    return new State첫번째꼬마교체Delay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay03 : TriggerState {
            internal State첫번째꼬마교체Delay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 203, addSpawnId: 200);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_998");
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__20$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__21$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9012, spawnIds: new []{100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째힌트발견04 : TriggerState {
            internal State첫번째힌트발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308, 2309, 2310, 2311, 2312, 2313, 2314, 2315}, visible: true, meshCount: 15, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777501}, visible: true);
                context.SetInteractObject(interactIds: new []{10000769}, state: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000769}, arg2: 0)) {
                    return new State첫번째꼬마발견04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000769}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State첫번째꼬마발견04 : TriggerState {
            internal State첫번째꼬마발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204}, arg2: false);
                context.SetConversation(type: 1, spawnId: 204, script: "$02000331_BF__Seeker01__17$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__12$", arg4: 2, arg5: 1);
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_2204");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9004, spawnIds: new []{204})) {
                    return new State첫번째꼬마교체Delay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State첫번째꼬마교체Delay04 : TriggerState {
            internal State첫번째꼬마교체Delay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 204, addSpawnId: 200);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_998");
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__22$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__23$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9012, spawnIds: new []{100})) {
                    return new StateMonsterSpawn02_CreationRandom01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_CreationRandom01 : TriggerState {
            internal StateMonsterSpawn02_CreationRandom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn02_1TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn02_2TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn02_3TimedCreation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn02_4TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_1TimedCreation : TriggerState {
            internal StateMonsterSpawn02_1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{9223, 9224, 9225, 921, 922, 924, 925, 927, 928}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_2TimedCreation : TriggerState {
            internal StateMonsterSpawn02_2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{9221, 9223, 9225, 920, 922, 924, 925, 926, 929}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_3TimedCreation : TriggerState {
            internal StateMonsterSpawn02_3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{9221, 9222, 9224, 920, 922, 924, 925, 926, 928}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn02_4TimedCreation : TriggerState {
            internal StateMonsterSpawn02_4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{9222, 9223, 9225, 922, 923, 925, 926, 927, 929}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new State두명패트롤01(context);
            }

            public override void OnExit() { }
        }

        private class State두명패트롤01 : TriggerState {
            internal State두명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1003");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9016, spawnIds: new []{100})) {
                    return new State두번째덤불Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째덤불Spawn01 : TriggerState {
            internal State두번째덤불Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__24$", arg4: 3, arg5: 0);
                context.CreateMonster(spawnIds: new []{91003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91003})) {
                    return new State두번째덤불Remove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003312);
                context.SetEffect(triggerIds: new []{777402}, visible: true);
            }
        }

        private class State두번째덤불Remove01 : TriggerState {
            internal State두번째덤불Remove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 93330, visible: true, initialSequence: "Dead_A");
                context.SetMesh(triggerIds: new []{90003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__25$", arg4: 3, arg5: 0);
                context.SetEffect(triggerIds: new []{777402}, visible: false);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1004");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9005, spawnIds: new []{100})) {
                    return new State두번째Monster발견01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 93330, visible: false, initialSequence: "Dead_A");
            }
        }

        private class State두번째Monster발견01 : TriggerState {
            internal State두번째Monster발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__30$", arg4: 2, arg5: 0);
                context.SetAgent(triggerIds: new []{13001, 13002, 13003, 13004, 13005, 13006}, visible: false);
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__31$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{9221, 9222, 9223, 9224, 9225, 920, 921, 922, 923, 924, 925, 926, 927, 928, 929})) {
                    return new State두번째꼬마Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마Random : TriggerState {
            internal State두번째꼬마Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State두번째힌트발견01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State두번째힌트발견02(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State두번째힌트발견03(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State두번째힌트발견04(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State두번째힌트발견05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견01 : TriggerState {
            internal State두번째힌트발견01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_997");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2013");
                context.SetRandomMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018}, visible: true, meshCount: 18, arg4: 50, delay: 50);
                context.SetEffect(triggerIds: new []{777502}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{311}, arg2: false);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9301})) {
                    return new State두번째꼬마도움01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움01 : TriggerState {
            internal State두번째꼬마도움01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 311, script: "$02000331_BF__Seeker01__33$", arg4: 2, arg5: 0);
                context.SetInteractObject(interactIds: new []{10000771}, state: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000771}, arg2: 0)) {
                    return new State두번째꼬마구출01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003313);
                context.SetInteractObject(interactIds: new []{10000771}, state: 2);
            }
        }

        private class State두번째꼬마구출01 : TriggerState {
            internal State두번째꼬마구출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 311, addSpawnId: 301);
                context.SetConversation(type: 1, spawnId: 301, script: "$02000331_BF__Seeker01__38$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3301");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 301, script: "$02000331_BF__Seeker01__39$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__40$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9006, spawnIds: new []{301})) {
                    return new State두번째꼬마교체Delay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay01 : TriggerState {
            internal State두번째꼬마교체Delay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__41$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 301, addSpawnId: 300);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_996");
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__42$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9007, spawnIds: new []{100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견02 : TriggerState {
            internal State두번째힌트발견02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_997");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2013");
                context.SetRandomMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110, 3111, 3112, 3113, 3114, 3115, 3116}, visible: true, meshCount: 16, arg4: 50, delay: 50);
                context.SetEffect(triggerIds: new []{777502}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{312}, arg2: false);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9302})) {
                    return new State두번째꼬마도움02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움02 : TriggerState {
            internal State두번째꼬마도움02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 312, script: "$02000331_BF__Seeker01__34$", arg4: 2, arg5: 0);
                context.SetInteractObject(interactIds: new []{10000772}, state: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000772}, arg2: 0)) {
                    return new State두번째꼬마구출02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000772}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출02 : TriggerState {
            internal State두번째꼬마구출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 312, addSpawnId: 302);
                context.SetConversation(type: 1, spawnId: 302, script: "$02000331_BF__Seeker01__43$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3302");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 302, script: "$02000331_BF__Seeker01__44$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__45$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9006, spawnIds: new []{302})) {
                    return new State두번째꼬마교체Delay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay02 : TriggerState {
            internal State두번째꼬마교체Delay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__46$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 302, addSpawnId: 300);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_996");
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__47$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9007, spawnIds: new []{100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견03 : TriggerState {
            internal State두번째힌트발견03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_997");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2013");
                context.SetRandomMesh(triggerIds: new []{3201, 3202, 3203, 3204, 3205, 3206, 3207, 3208, 3209, 3210, 3211, 3212, 3213, 3214, 3215, 3216, 3217, 3218, 3219, 3220, 3221}, visible: true, meshCount: 21, arg4: 50, delay: 50);
                context.SetEffect(triggerIds: new []{777502}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{313}, arg2: false);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9303})) {
                    return new State두번째꼬마도움03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움03 : TriggerState {
            internal State두번째꼬마도움03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 313, script: "$02000331_BF__Seeker01__35$", arg4: 2, arg5: 0);
                context.SetInteractObject(interactIds: new []{10000773}, state: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000773}, arg2: 0)) {
                    return new State두번째꼬마구출03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000773}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출03 : TriggerState {
            internal State두번째꼬마구출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 313, addSpawnId: 303);
                context.SetConversation(type: 1, spawnId: 303, script: "$02000331_BF__Seeker01__48$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 303, patrolName: "MS2PatrolData_3303");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 303, script: "$02000331_BF__Seeker01__49$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__50$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9006, spawnIds: new []{303})) {
                    return new State두번째꼬마교체Delay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay03 : TriggerState {
            internal State두번째꼬마교체Delay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__51$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 303, addSpawnId: 300);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_996");
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__52$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9007, spawnIds: new []{100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견04 : TriggerState {
            internal State두번째힌트발견04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_997");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2013");
                context.SetRandomMesh(triggerIds: new []{3301, 3302, 3303, 3304, 3305, 3306, 3307, 3308, 3309, 3310, 3311, 3312, 3313, 3314, 3315, 3316, 3317, 3318}, visible: true, meshCount: 18, arg4: 50, delay: 50);
                context.SetEffect(triggerIds: new []{777502}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{314}, arg2: false);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9304})) {
                    return new State두번째꼬마도움04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움04 : TriggerState {
            internal State두번째꼬마도움04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000774}, state: 1);
                context.SetConversation(type: 1, spawnId: 314, script: "$02000331_BF__Seeker01__36$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000774}, arg2: 0)) {
                    return new State두번째꼬마구출04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000774}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출04 : TriggerState {
            internal State두번째꼬마구출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 314, addSpawnId: 304);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 304, patrolName: "MS2PatrolData_3304");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 304, script: "$02000331_BF__Seeker01__54$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__55$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9006, spawnIds: new []{304})) {
                    return new State두번째꼬마교체Delay04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay04 : TriggerState {
            internal State두번째꼬마교체Delay04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__56$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 304, addSpawnId: 300);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_996");
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__57$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9007, spawnIds: new []{100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째힌트발견05 : TriggerState {
            internal State두번째힌트발견05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_997");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2013");
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__800$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.SetRandomMesh(triggerIds: new []{3401, 3402, 3403, 3404, 3405, 3406, 3407, 3408, 3409, 3410, 3411, 3412, 3413, 3414, 3415, 3416, 3417, 3418, 3419}, visible: true, meshCount: 19, arg4: 50, delay: 50);
                context.SetEffect(triggerIds: new []{777502}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{315}, arg2: false);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__32$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9305})) {
                    return new State두번째꼬마도움05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마도움05 : TriggerState {
            internal State두번째꼬마도움05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000775}, state: 1);
                context.SetConversation(type: 1, spawnId: 315, script: "$02000331_BF__Seeker01__37$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                return new State두번째꼬마발견05(context);
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마발견05 : TriggerState {
            internal State두번째꼬마발견05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000775}, arg2: 0)) {
                    return new State두번째꼬마구출05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetInteractObject(interactIds: new []{10000775}, state: 2);
                context.HideGuideSummary(entityId: 20003313);
            }
        }

        private class State두번째꼬마구출05 : TriggerState {
            internal State두번째꼬마구출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ChangeMonster(removeSpawnId: 315, addSpawnId: 305);
                context.SetConversation(type: 1, spawnId: 305, script: "$02000331_BF__Seeker01__58$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.MoveNpc(spawnId: 305, patrolName: "MS2PatrolData_3305");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 305, script: "$02000331_BF__Seeker01__59$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__60$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9006, spawnIds: new []{305})) {
                    return new State두번째꼬마교체Delay05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째꼬마교체Delay05 : TriggerState {
            internal State두번째꼬마교체Delay05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__61$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
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
                context.ChangeMonster(removeSpawnId: 305, addSpawnId: 300);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_996");
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__62$", arg4: 3, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9007, spawnIds: new []{100})) {
                    return new State세명패트롤01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세명패트롤01 : TriggerState {
            internal State세명패트롤01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1005");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2004");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9008, spawnIds: new []{100})) {
                    return new State세명패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세명패트롤02 : TriggerState {
            internal State세명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__70$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State세번째덤불Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째덤불Spawn01 : TriggerState {
            internal State세번째덤불Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.CreateMonster(spawnIds: new []{91004}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91004})) {
                    return new State세번째덤불Spawn02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{777403}, visible: true);
            }
        }

        private class State세번째덤불Spawn02 : TriggerState {
            internal State세번째덤불Spawn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1006");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2005");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3003");
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__71$", arg4: 2, arg5: 0);
                context.CreateMonster(spawnIds: new []{91005}, arg2: false);
                context.SetMesh(triggerIds: new []{90004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 94440, visible: true, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91005})) {
                    return new State세번째덤불Spawn03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003312);
                context.SetEffect(triggerIds: new []{777404}, visible: true);
            }
        }

        private class State세번째덤불Spawn03 : TriggerState {
            internal State세번째덤불Spawn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__72$", arg4: 2, arg5: 0);
                context.SetMesh(triggerIds: new []{90005}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 94450, visible: true, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{777403, 777404}, visible: false);
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__73$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1016");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2015");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3013");
                context.SetActor(triggerId: 94440, visible: false, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State꼬마셋대화Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 94450, visible: false, initialSequence: "Dead_A");
            }
        }

        private class State꼬마셋대화Cinematic01 : TriggerState {
            internal State꼬마셋대화Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__74$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9009, spawnIds: new []{100})) {
                    return new State세번째스위치Random(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째스위치Random : TriggerState {
            internal State세번째스위치Random(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State세번째스위치출현01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State세번째스위치출현02(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State세번째스위치출현03(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State세번째스위치출현04(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State세번째스위치출현05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째스위치출현01 : TriggerState {
            internal State세번째스위치출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000784}, state: 1);
            }

            public override TriggerState? Execute() {
                return new State고립StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic01 : TriggerState {
            internal State고립StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(triggerId: 804, enabled: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3004");
                context.SetSkip(state: new State고립StopCinematic01(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 804, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip(state: new State구출안내01_01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__802$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000784}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000792}, state: 1);
            }

            public override TriggerState? Execute() {
                return new State고립StartCinematic02(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic02 : TriggerState {
            internal State고립StartCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(triggerId: 804, enabled: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3004");
                context.SetSkip(state: new State고립StopCinematic02(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 804, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip(state: new State구출안내02_01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__802$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000792}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000793}, state: 1);
            }

            public override TriggerState? Execute() {
                return new State고립StartCinematic03(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic03 : TriggerState {
            internal State고립StartCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(triggerId: 804, enabled: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3004");
                context.SetSkip(state: new State고립StopCinematic03(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 804, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip(state: new State구출안내03_01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__802$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000793}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000794}, state: 1);
            }

            public override TriggerState? Execute() {
                return new State고립StartCinematic04(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic04 : TriggerState {
            internal State고립StartCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(triggerId: 804, enabled: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3004");
                context.SetSkip(state: new State고립StopCinematic04(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 804, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip(state: new State구출안내04_01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__802$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000794}, arg2: 0)) {
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
                context.SetInteractObject(interactIds: new []{10000795}, state: 1);
            }

            public override TriggerState? Execute() {
                return new State고립StartCinematic05(context);
            }

            public override void OnExit() { }
        }

        private class State고립StartCinematic05 : TriggerState {
            internal State고립StartCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__901$");
                context.CameraSelect(triggerId: 804, enabled: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1007");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2006");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3004");
                context.SetSkip(state: new State고립StopCinematic05(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 804, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip(state: new State구출안내05_01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__802$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__80$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__81$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__82$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000795}, arg2: 0)) {
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
                context.ChangeMonster(removeSpawnId: 401, addSpawnId: 400);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 400, script: "$02000331_BF__Seeker01__83$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_4001");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9010, spawnIds: new []{400})) {
                    return new State세번째꼬마만남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State세번째꼬마만남01 : TriggerState {
            internal State세번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1008");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2007");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3005");
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__84$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 400, script: "$02000331_BF__Seeker01__85$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__86$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__87$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1009");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9011, spawnIds: new []{100})) {
                    return new State네명패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네명패트롤02 : TriggerState {
            internal State네명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2008");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3006");
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_4002");
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__88$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9017, spawnIds: new []{100})) {
                    return new State네번째덤불Spawn01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째덤불Spawn01 : TriggerState {
            internal State네번째덤불Spawn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003312, textId: 20003312);
                context.CreateMonster(spawnIds: new []{91006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91006})) {
                    return new State네번째덤불Remove01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003312);
                context.SetEffect(triggerIds: new []{777405}, visible: true);
            }
        }

        private class State네번째덤불Remove01 : TriggerState {
            internal State네번째덤불Remove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 96660, visible: true, initialSequence: "Dead_A");
                context.SetMesh(triggerIds: new []{90006}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "401", seconds: 2);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__89$", arg4: 2, arg5: 0);
                context.SetEffect(triggerIds: new []{777405}, visible: false);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1010");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2009");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3007");
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_4003");
                context.SetActor(triggerId: 96660, visible: false, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9013, spawnIds: new []{100})) {
                    return new StateMonsterSpawn05_꼬마Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_꼬마Creation : TriggerState {
            internal StateMonsterSpawn05_꼬마Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{500}, arg2: false);
                context.MoveNpc(spawnId: 500, patrolName: "MS2PatrolData_5001");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_1번대장Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_2번대장Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_3번대장Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_4번대장Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_1번대장Creation : TriggerState {
            internal StateMonsterSpawn05_1번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{991}, arg2: false);
                context.MoveNpc(spawnId: 991, patrolName: "MS2PatrolData_905");
            }

            public override TriggerState? Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_2번대장Creation : TriggerState {
            internal StateMonsterSpawn05_2번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{992}, arg2: false);
                context.MoveNpc(spawnId: 992, patrolName: "MS2PatrolData_905");
            }

            public override TriggerState? Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_3번대장Creation : TriggerState {
            internal StateMonsterSpawn05_3번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{992}, arg2: false);
                context.MoveNpc(spawnId: 992, patrolName: "MS2PatrolData_905");
            }

            public override TriggerState? Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_4번대장Creation : TriggerState {
            internal StateMonsterSpawn05_4번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{991}, arg2: false);
                context.MoveNpc(spawnId: 991, patrolName: "MS2PatrolData_905");
            }

            public override TriggerState? Execute() {
                return new StateMonsterSpawn05_CreationRandom02(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_CreationRandom02 : TriggerState {
            internal StateMonsterSpawn05_CreationRandom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_1번자코Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_2번자코Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_3번자코Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_4번자코Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_1번자코Creation : TriggerState {
            internal StateMonsterSpawn05_1번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5001", seconds: 1);
                context.CreateMonster(spawnIds: new []{930}, arg2: false);
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_901");
                context.CreateMonster(spawnIds: new []{935}, arg2: false);
                context.MoveNpc(spawnId: 935, patrolName: "MS2PatrolData_904");
                context.CreateMonster(spawnIds: new []{937}, arg2: false);
                context.MoveNpc(spawnId: 937, patrolName: "MS2PatrolData_906");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5001")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_2번자코Creation : TriggerState {
            internal StateMonsterSpawn05_2번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5002", seconds: 1);
                context.CreateMonster(spawnIds: new []{931}, arg2: false);
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_902");
                context.CreateMonster(spawnIds: new []{936}, arg2: false);
                context.MoveNpc(spawnId: 936, patrolName: "MS2PatrolData_901");
                context.CreateMonster(spawnIds: new []{937}, arg2: false);
                context.MoveNpc(spawnId: 937, patrolName: "MS2PatrolData_907");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5002")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_3번자코Creation : TriggerState {
            internal StateMonsterSpawn05_3번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5003", seconds: 1);
                context.CreateMonster(spawnIds: new []{932}, arg2: false);
                context.MoveNpc(spawnId: 932, patrolName: "MS2PatrolData_903");
                context.CreateMonster(spawnIds: new []{938}, arg2: false);
                context.MoveNpc(spawnId: 938, patrolName: "MS2PatrolData_907");
                context.CreateMonster(spawnIds: new []{936}, arg2: false);
                context.MoveNpc(spawnId: 936, patrolName: "MS2PatrolData_901");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5003")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_4번자코Creation : TriggerState {
            internal StateMonsterSpawn05_4번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5004", seconds: 1);
                context.CreateMonster(spawnIds: new []{932}, arg2: false);
                context.MoveNpc(spawnId: 932, patrolName: "MS2PatrolData_905");
                context.CreateMonster(spawnIds: new []{934}, arg2: false);
                context.MoveNpc(spawnId: 934, patrolName: "MS2PatrolData_903");
                context.CreateMonster(spawnIds: new []{938}, arg2: false);
                context.MoveNpc(spawnId: 938, patrolName: "MS2PatrolData_906");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5004")) {
                    return new StateMonsterSpawn05_CreationRandom03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_CreationRandom03 : TriggerState {
            internal StateMonsterSpawn05_CreationRandom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_5번대장Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_6번대장Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_7번대장Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_8번대장Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_5번대장Creation : TriggerState {
            internal StateMonsterSpawn05_5번대장Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{991}, arg2: false);
                context.MoveNpc(spawnId: 991, patrolName: "MS2PatrolData_904");
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{992}, arg2: false);
                context.MoveNpc(spawnId: 992, patrolName: "MS2PatrolData_904");
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{993}, arg2: false);
                context.MoveNpc(spawnId: 993, patrolName: "MS2PatrolData_904");
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{994}, arg2: false);
                context.MoveNpc(spawnId: 994, patrolName: "MS2PatrolData_904");
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_5번자코Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_6번자코Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_7번자코Creation(context);
                }

                if (context.RandomCondition(rate: 25)) {
                    return new StateMonsterSpawn05_8번자코Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_5번자코Creation : TriggerState {
            internal StateMonsterSpawn05_5번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{930}, arg2: false);
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_902");
                context.CreateMonster(spawnIds: new []{935}, arg2: false);
                context.MoveNpc(spawnId: 935, patrolName: "MS2PatrolData_905");
                context.CreateMonster(spawnIds: new []{937}, arg2: false);
                context.MoveNpc(spawnId: 937, patrolName: "MS2PatrolData_909");
            }

            public override TriggerState? Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_6번자코Creation : TriggerState {
            internal StateMonsterSpawn05_6번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{931}, arg2: false);
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_901");
                context.CreateMonster(spawnIds: new []{934}, arg2: false);
                context.MoveNpc(spawnId: 934, patrolName: "MS2PatrolData_909");
                context.CreateMonster(spawnIds: new []{937}, arg2: false);
                context.MoveNpc(spawnId: 937, patrolName: "MS2PatrolData_907");
            }

            public override TriggerState? Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_7번자코Creation : TriggerState {
            internal StateMonsterSpawn05_7번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{932}, arg2: false);
                context.MoveNpc(spawnId: 932, patrolName: "MS2PatrolData_903");
                context.CreateMonster(spawnIds: new []{935}, arg2: false);
                context.MoveNpc(spawnId: 935, patrolName: "MS2PatrolData_904");
                context.CreateMonster(spawnIds: new []{936}, arg2: false);
                context.MoveNpc(spawnId: 936, patrolName: "MS2PatrolData_901");
            }

            public override TriggerState? Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn05_8번자코Creation : TriggerState {
            internal StateMonsterSpawn05_8번자코Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{932}, arg2: false);
                context.MoveNpc(spawnId: 932, patrolName: "MS2PatrolData_906");
                context.CreateMonster(spawnIds: new []{934}, arg2: false);
                context.MoveNpc(spawnId: 934, patrolName: "MS2PatrolData_901");
                context.CreateMonster(spawnIds: new []{937}, arg2: false);
                context.MoveNpc(spawnId: 937, patrolName: "MS2PatrolData_907");
            }

            public override TriggerState? Execute() {
                return new State추격StartCinematic01(context);
            }

            public override void OnExit() { }
        }

        private class State추격StartCinematic01 : TriggerState {
            internal State추격StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7776}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__902$");
                context.CameraSelect(triggerId: 800, enabled: true);
                context.SetSkip(state: new State추격StopCinematic01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__803$", duration: 2000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.CameraSelect(triggerId: 800, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__90$", arg4: 2);
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__91$", arg4: 2);
                context.SetConversation(type: 1, spawnId: 500, script: "$02000331_BF__Seeker01__92$", arg4: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{930, 931, 932, 933, 934, 935, 936, 937, 938, 991, 992, 993, 994})) {
                    return new State네번째꼬마만남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State네번째꼬마만남01 : TriggerState {
            internal State네번째꼬마만남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7776}, visible: false);
                context.SetConversation(type: 1, spawnId: 500, script: "$02000331_BF__Seeker01__93$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__94$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__95$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 400, script: "$02000331_BF__Seeker01__96$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__97$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1011");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9014, spawnIds: new []{100})) {
                    return new State다섯명패트롤02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다섯명패트롤02 : TriggerState {
            internal State다섯명패트롤02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2010");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3008");
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_4004");
                context.MoveNpc(spawnId: 500, patrolName: "MS2PatrolData_5002");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9015, spawnIds: new []{100})) {
                    return new State두번째무너짐StartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째무너짐StartCinematic01 : TriggerState {
            internal State두번째무너짐StartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__903$");
                context.CameraSelect(triggerId: 806, enabled: true);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 10030, 10031, 10032, 10033}, visible: false, meshCount: 14, arg4: 100, delay: 100);
                context.SetEffect(triggerIds: new []{777803}, visible: true);
                context.SetAgent(triggerIds: new []{15000, 15001, 15002}, visible: true);
                context.SetSkip(state: new State두번째무너짐StopCinematic01(context));
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 806, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetSkip(state: new State술래말풍선06(context));
            }

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{777803}, visible: false);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1012");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2011");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__100$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 200, script: "$02000331_BF__Seeker01__101$", arg4: 2, arg5: 1);
                context.MoveNpc(spawnId: 500, patrolName: "MS2PatrolData_5003");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3009");
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_4005");
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 500, script: "$02000331_BF__Seeker01__102$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__103$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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
                context.SetConversation(type: 1, spawnId: 400, script: "$02000331_BF__Seeker01__104$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 300, script: "$02000331_BF__Seeker01__105$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new State외다리스위치출현01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State외다리스위치출현02(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State외다리스위치출현03(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State외다리스위치출현04(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State외다리스위치출현05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State외다리스위치출현01 : TriggerState {
            internal State외다리스위치출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000785}, state: 0);
                context.SetInteractObject(interactIds: new []{10000785}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__804$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000785})) {
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
                context.SetInteractObject(interactIds: new []{10000796}, state: 0);
                context.SetInteractObject(interactIds: new []{10000796}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__804$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000796})) {
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
                context.SetInteractObject(interactIds: new []{10000797}, state: 0);
                context.SetInteractObject(interactIds: new []{10000797}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__804$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000797})) {
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
                context.SetInteractObject(interactIds: new []{10000798}, state: 0);
                context.SetInteractObject(interactIds: new []{10000798}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__804$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000798})) {
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
                context.SetInteractObject(interactIds: new []{10000799}, state: 0);
                context.SetInteractObject(interactIds: new []{10000799}, state: 1);
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__804$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000799})) {
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
                context.SetMesh(triggerIds: new []{90008}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{777702}, visible: true);
                context.SetRandomMesh(triggerIds: new []{10040, 10041, 10042, 10043, 10044}, visible: true, meshCount: 5, arg4: 150, delay: 150);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다리건너갈Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너갈Prepare01 : TriggerState {
            internal State다리건너갈Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__805$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1013");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State다리건너갈Prepare02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너갈Prepare02 : TriggerState {
            internal State다리건너갈Prepare02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__110$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99992})) {
                    return new State다리건너가기01(context);
                }

                if (context.UserDetected(boxIds: new []{99993})) {
                    return new State다리건너가기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너가기01 : TriggerState {
            internal State다리건너가기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 100, patrolName: "MS2PatrolData_1014");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_2014");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_3010");
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_4006");
                context.MoveNpc(spawnId: 500, patrolName: "MS2PatrolData_5004");
                context.SetConversation(type: 1, spawnId: 100, script: "$02000331_BF__Seeker01__111$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99996})) {
                    return new State다리건너가기03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리건너가기03 : TriggerState {
            internal State다리건너가기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 610, script: "$02000331_BF__Seeker01__112$", arg4: 3, arg5: 0);
                context.SetMesh(triggerIds: new []{90008}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9018, spawnIds: new []{300})) {
                    return new StateBossSpawnStartCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnStartCinematic01 : TriggerState {
            internal StateBossSpawnStartCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{990}, arg2: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__904$");
                context.SetEffect(triggerIds: new []{777901}, visible: true);
                context.CameraSelect(triggerId: 808, enabled: true);
                context.SetSkip(state: new StateBossSpawnCinematic중01(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__905$");
                context.SetSkip(state: new StateBossSpawnCinematic중01Skip(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateBossSpawnCinematic중02(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중02 : TriggerState {
            internal StateBossSpawnCinematic중02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__906$");
                context.ChangeMonster(removeSpawnId: 100, addSpawnId: 601);
                context.ChangeMonster(removeSpawnId: 200, addSpawnId: 602);
                context.ChangeMonster(removeSpawnId: 300, addSpawnId: 603);
                context.ChangeMonster(removeSpawnId: 400, addSpawnId: 604);
                context.ChangeMonster(removeSpawnId: 500, addSpawnId: 605);
                context.CameraSelect(triggerId: 809, enabled: true);
                context.SetSkip(state: new StateBossSpawnCinematic중02Skip(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateBossSpawnCinematic중03(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중03 : TriggerState {
            internal StateBossSpawnCinematic중03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{10040, 10041, 10042, 10043, 10044}, visible: false, meshCount: 5, arg4: 150, delay: 150);
                context.SetEffect(triggerIds: new []{777802}, visible: true);
                context.SetAgent(triggerIds: new []{16000, 16001, 16002, 16003, 16004}, visible: true);
                context.SetSkip(state: new StateBossSpawnCinematic중03Skip(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateBossSpawnCinematic중04(context);
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnCinematic중04 : TriggerState {
            internal StateBossSpawnCinematic중04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 809, enabled: false);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__907$");
                context.SetEffect(triggerIds: new []{777901}, visible: false);
                context.SetEffect(triggerIds: new []{777902}, visible: true);
                context.SetSkip(state: new StateBossSpawnEndCinematic01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateBossSpawnEndCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossSpawnEndCinematic01 : TriggerState {
            internal StateBossSpawnEndCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 808, enabled: false);
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(triggerIds: new []{777802}, visible: false);
                context.SetUserValue(triggerId: 15, key: "SecondBridgeOff", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__806$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_1TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_2TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_3TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_4TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_5TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_1TimedCreation : TriggerState {
            internal StateMonsterSpawn06_1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{940, 941, 950, 951}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{942, 943, 952, 953}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "6003", seconds: 1);
                context.CreateMonster(spawnIds: new []{944, 945, 954, 955}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{946, 947, 956, 957}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{948, 949, 958, 959}, arg2: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_6TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_7TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_8TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_9TimedCreation(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_10TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_6TimedCreation : TriggerState {
            internal StateMonsterSpawn06_6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{960, 961, 962, 963}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_7TimedCreation : TriggerState {
            internal StateMonsterSpawn06_7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{962, 963, 964, 965}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_8TimedCreation : TriggerState {
            internal StateMonsterSpawn06_8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{964, 965, 966, 967}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_9TimedCreation : TriggerState {
            internal StateMonsterSpawn06_9TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{966, 967, 968, 969}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_10TimedCreation : TriggerState {
            internal StateMonsterSpawn06_10TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{968, 969, 960, 961}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new State두번째웨이브Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State두번째웨이브Wait : TriggerState {
            internal State두번째웨이브Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_11TimedCreation_01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_12TimedCreation_01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_13TimedCreation_01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_14TimedCreation_01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateMonsterSpawn06_15TimedCreation_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_11TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_11TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{940, 941, 971}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{950, 951, 970}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{960, 961, 962}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{945, 946, 976}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{955, 956, 957}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{965, 966, 975}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_12TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_12TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{958, 959, 978}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{968, 969, 960}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{948, 949, 979}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{943, 944, 945, 975}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{953, 954}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{964, 965, 974}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_13TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_13TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{946, 947}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{955, 956, 957, 976}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{965, 966, 967, 977}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{969, 960, 979}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{949, 940, 970}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{950, 959}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_14TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_14TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{941, 942, 972}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{961, 962, 963}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{951, 952, 953}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{964, 965, 974}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{944, 946, 975}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{955, 956, 976}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_15TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_15TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{948, 949, 979}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{968, 969, 960, 978}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{948, 949}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{963, 964, 973}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{953, 954, 955, 974}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{943, 944}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateMonsterSpawn06_CreationRandom04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_CreationRandom04 : TriggerState {
            internal StateMonsterSpawn06_CreationRandom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{941, 942, 971}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{951, 953}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{954, 955, 956, 986}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{964, 965, 985}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{953, 954}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{964, 965, 974}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{947, 948, 949, 988}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{967, 968, 987}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_17TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_17TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{954, 955, 956, 986}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{964, 965, 985}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{941, 942, 971}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{951, 953}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{947, 948, 949, 988}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{967, 968, 987}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{953, 954}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{964, 965, 974}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_18TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_18TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{959, 958}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{949, 940, 970}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{953, 954, 955, 983}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{943, 945, 984}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{961, 962}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{952, 953, 972}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{945, 946, 947, 985}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{966, 967, 986}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_19TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_19TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{943, 944, 945, 974}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{963, 965}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{951, 950, 980}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{941, 942, 981}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{957, 958}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{966, 968, 977}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{948, 949, 989}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{959, 958, 988}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn06_20TimedCreation_01 : TriggerState {
            internal StateMonsterSpawn06_20TimedCreation_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{967, 968, 969}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{957, 959, 978}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{953, 954, 984}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{943, 944, 983}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{951, 952, 950}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{962, 961, 970}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{946, 947, 986}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.CreateMonster(spawnIds: new []{955, 956, 985}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949, 950, 951, 952, 953, 954, 955, 956, 957, 958, 959, 960, 961, 962, 963, 964, 965, 966, 967, 968, 969, 970, 971, 972, 973, 974, 975, 976, 977, 978, 979, 980, 981, 982, 983, 984, 985, 986, 987, 988, 989})) {
                    return new StateBossCombatSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossCombatSetup01 : TriggerState {
            internal StateBossCombatSetup01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 811, enabled: true);
                context.SetSkip(state: new StateBossCombatSetup04(context));
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__908$");
                context.SetEffect(triggerIds: new []{777902}, visible: false);
                context.SetEffect(triggerIds: new []{777903}, visible: true);
            }

            public override TriggerState? Execute() {
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
                context.CameraSelect(triggerId: 811, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
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
                context.DestroyMonster(spawnIds: new []{990});
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__807$", duration: 3000, boxId: 0);
                context.SetEffect(triggerIds: new []{7771}, visible: true);
                context.CreateMonster(spawnIds: new []{999}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{999})) {
                    return new StateBoss도망Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망Prepare01 : TriggerState {
            internal StateBoss도망Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss도망Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망Cinematic01 : TriggerState {
            internal StateBoss도망Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1000}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000776}, state: 0);
                context.SetInteractObject(interactIds: new []{10000776}, state: 1);
                context.SetActor(triggerId: 97770, visible: false, initialSequence: "Closed");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__909$");
                context.CameraSelect(triggerId: 812, enabled: true);
                context.SetSkip(state: new StateBoss도망Cinematic03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateBoss도망Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망Cinematic02 : TriggerState {
            internal StateBoss도망Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3, script: "$02000331_BF__Seeker01__910$");
                context.SetEffect(triggerIds: new []{777903}, visible: false);
                context.SetEffect(triggerIds: new []{777904}, visible: true);
                context.SetSkip(state: new StateBoss도망Cinematic03(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateBoss도망Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss도망Cinematic03 : TriggerState {
            internal StateBoss도망Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 812, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ChangeMonster(removeSpawnId: 610, addSpawnId: 600);
            }

            public override TriggerState? Execute() {
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
                context.SetEventUI(arg1: 1, script: "$02000331_BF__Seeker01__808$", duration: 3000, boxId: 0);
                context.SetConversation(type: 1, spawnId: 600, script: "$02000331_BF__Seeker01__120$", arg4: 2, arg5: 1);
                context.DestroyMonster(spawnIds: new []{1000});
                context.SetEffect(triggerIds: new []{7771}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막Cinematic_Prepare01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_Prepare01 : TriggerState {
            internal State마지막Cinematic_Prepare01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003315, textId: 20003315);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000776})) {
                    return new State마지막Cinematic_포털출현01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20003315);
                context.SetInteractObject(interactIds: new []{10000776}, state: 0);
            }
        }

        private class State마지막Cinematic_포털출현01 : TriggerState {
            internal State마지막Cinematic_포털출현01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, script: "$02000331_BF__Seeker01__809$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막Cinematic_포털출현02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_포털출현02 : TriggerState {
            internal State마지막Cinematic_포털출현02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 600, patrolName: "MS2PatrolData_6001");
                context.SetEffect(triggerIds: new []{777904}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마지막Cinematic_포털출현03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_포털출현03 : TriggerState {
            internal State마지막Cinematic_포털출현03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 600, script: "$02000331_BF__Seeker01__130$", arg4: 2, arg5: 0);
                context.SetEffect(triggerIds: new []{99999, 7772}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9020, spawnIds: new []{600})) {
                    return new State마지막Cinematic_포털출현04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_포털출현04 : TriggerState {
            internal State마지막Cinematic_포털출현04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{99999}, visible: false);
                context.ChangeMonster(removeSpawnId: 601, addSpawnId: 110);
                context.ChangeMonster(removeSpawnId: 602, addSpawnId: 210);
                context.ChangeMonster(removeSpawnId: 603, addSpawnId: 310);
                context.ChangeMonster(removeSpawnId: 604, addSpawnId: 410);
                context.ChangeMonster(removeSpawnId: 605, addSpawnId: 510);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State마지막Cinematic_시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_시작01 : TriggerState {
            internal State마지막Cinematic_시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 410, patrolName: "MS2PatrolData_4007");
                context.MoveNpc(spawnId: 510, patrolName: "MS2PatrolData_5005");
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_1015");
                context.MoveNpc(spawnId: 210, patrolName: "MS2PatrolData_2012");
                context.MoveNpc(spawnId: 310, patrolName: "MS2PatrolData_3011");
                context.MoveNpc(spawnId: 600, patrolName: "MS2PatrolData_6002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State마지막Cinematic_시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마지막Cinematic_시작02 : TriggerState {
            internal State마지막Cinematic_시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 110, script: "$02000331_BF__Seeker01__131$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 310, script: "$02000331_BF__Seeker01__132$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 410, script: "$02000331_BF__Seeker01__133$", arg4: 2, arg5: 4);
                context.SetConversation(type: 1, spawnId: 600, script: "$02000331_BF__Seeker01__136$", arg4: 2, arg5: 6);
            }

            public override TriggerState? Execute() {
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
                context.SetRandomMesh(triggerIds: new []{90090, 90091, 90092, 90093, 90094, 90095, 90096, 90097, 90098, 90099}, visible: false, meshCount: 10, arg4: 100, delay: 100);
                context.ChangeMonster(removeSpawnId: 110, addSpawnId: 111);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State퇴장시작01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DungeonClear();
                context.SetAchievement(triggerId: 99998, type: "trigger", code: "ClearHideandSeek");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }
        }

        private class State퇴장시작01 : TriggerState {
            internal State퇴장시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 210, script: "$02000331_BF__Seeker01__134$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 510, script: "$02000331_BF__Seeker01__135$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 111, script: "$02000331_BF__Seeker01__137$", arg4: 2, arg5: 3);
            }

            public override TriggerState? Execute() {
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
                context.SetAgent(triggerIds: new []{11000, 11001, 15000, 15001, 15002, 16000, 16001, 16002, 16003, 16004}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

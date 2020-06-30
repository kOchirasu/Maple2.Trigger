using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _901_mobwave_01round {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "MobWaveStart", value: 1)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart : TriggerState {
            internal State1stWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__901_MOBWAVE_01ROUND__0$", arg3: new int[] {6000},
                    arg4: "0");
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.CreateMonster(arg1: new int[] {90100, 90102, 90104}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90101, 90103, 90105}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay3000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay4000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay5000(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay3000 : TriggerState {
            internal State1stWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay4000 : TriggerState {
            internal State1stWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay5000 : TriggerState {
            internal State1stWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart : TriggerState {
            internal State2ndWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 2);
                context.CreateMonster(arg1: new int[] {90110, 90112, 90114}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90111, 90113, 90115}, arg2: false);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay2000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay3000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay4000(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay2000 : TriggerState {
            internal State2ndWaveDelay2000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay3000 : TriggerState {
            internal State2ndWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay4000 : TriggerState {
            internal State2ndWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveStart : TriggerState {
            internal State3rdWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 3);
                context.CreateMonster(arg1: new int[] {90120, 90122, 90124}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay : TriggerState {
            internal State3rdWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90131, 90133, 90135}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thWaveStart : TriggerState {
            internal State5thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 5);
                context.CreateMonster(arg1: new int[] {90190, 90192, 90194}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State5thWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90191, 90193, 90195}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess01 : TriggerState {
            internal StateDefenceSucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    90100, 90101, 90102, 90103, 90104, 90105, 90106, 90107, 90108, 90109, 90110, 90111, 90112, 90113,
                    90114, 90115, 90116, 90117, 90118, 90119, 90120, 90121, 90122, 90123, 90124, 90125, 90126, 90127,
                    90128, 90129, 90130, 90131, 90132, 90133, 90134, 90135, 90136, 90137, 90138, 90139, 90180, 90181,
                    90182, 90183, 90184, 90185, 90186, 90187, 90188, 90189, 90190, 90191, 90192, 90193, 90194, 90195,
                    90196, 90197, 90198, 90199
                })) {
                    context.State = new StateDefenceSucess02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1001})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetUserValue(triggerID: 1, key: "01RoundSuccess", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcDownPenaltyStart : TriggerState {
            internal StateNpcDownPenaltyStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 801, key: "PenaltyMob", value: 1);
                context.DestroyMonster(arg1: new int[] {1001});
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__901_MOBWAVE_01ROUND__1$", arg3: new int[] {4000},
                    arg4: "0");
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000378_BF__901_MOBWAVE_01ROUND__2$", arg4: 4,
                    arg5: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateNpcDownPenaltyEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcDownPenaltyEnd : TriggerState {
            internal StateNpcDownPenaltyEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "PenaltyFinish", value: 1)) {
                    context.State = new StateReturnToWave(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnToWave : TriggerState {
            internal StateReturnToWave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__901_MOBWAVE_01ROUND__3$", arg3: new int[] {4000},
                    arg4: "0");
                context.DestroyMonster(arg1: new int[] {1101});
                context.CreateMonster(arg1: new int[] {1001}, arg2: false);
                context.RemoveBalloonTalk(spawnPointID: 1101);
            }

            public override void Execute() {
                if (context.UserValue(key: "WaveTime", value: 1)) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "WaveTime", value: 2)) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "WaveTime", value: 3)) {
                    context.State = new State5thWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "WaveTime", value: 5)) {
                    context.State = new State5thWaveStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
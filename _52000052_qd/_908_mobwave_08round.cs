namespace Maple2.Trigger._52000052_qd {
    public static class _908_mobwave_08round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(arg1: new[] {5108}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MobWaveStart") == 1) {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52000052_QD__901_MOBWAVE_01ROUND__0$", arg3: 6000,
                    arg4: "0");
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(arg1: new[] {5108}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirectionRandom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirectionRandom : TriggerState {
            internal State1stWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State1stWaveDirection10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State1stWaveDirection20(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State1stWaveDirection30(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State1stWaveDirection40(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State1stWaveDirection50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection10 : TriggerState {
            internal State1stWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90800, 90802, 90804, 90806, 90808}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection11 : TriggerState {
            internal State1stWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90801, 90803, 90805, 90807, 90809}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection20 : TriggerState {
            internal State1stWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90810, 90812, 90814, 90816, 90818}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection21 : TriggerState {
            internal State1stWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90811, 90813, 90815, 90817, 90819}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection30 : TriggerState {
            internal State1stWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90820, 90822, 90824, 90826, 90828}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection31 : TriggerState {
            internal State1stWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90821, 90823, 90825, 90827, 90829}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection40 : TriggerState {
            internal State1stWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90830, 90832, 90834, 90836, 90838}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection41 : TriggerState {
            internal State1stWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90831, 90833, 90835, 90837, 90839}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection50 : TriggerState {
            internal State1stWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90840, 90842, 90844, 90846, 90848}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection51 : TriggerState {
            internal State1stWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90841, 90843, 90845, 90847, 90849}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay5000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay6000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay7000(context);
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

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay6000 : TriggerState {
            internal State1stWaveDelay6000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay7000 : TriggerState {
            internal State1stWaveDelay7000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
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
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirectionRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirectionRandom : TriggerState {
            internal State2ndWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State2ndWaveDirection10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State2ndWaveDirection20(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State2ndWaveDirection30(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State2ndWaveDirection40(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State2ndWaveDirection50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection10 : TriggerState {
            internal State2ndWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90800, 90802, 90804, 90806, 90808}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection11 : TriggerState {
            internal State2ndWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90801, 90803, 90805, 90807, 90809}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection20 : TriggerState {
            internal State2ndWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90810, 90812, 90814, 90816, 90818}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection21 : TriggerState {
            internal State2ndWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90811, 90813, 90815, 90817, 90819}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection30 : TriggerState {
            internal State2ndWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90820, 90822, 90824, 90826, 90828}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection31 : TriggerState {
            internal State2ndWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90821, 90823, 90825, 90827, 90829}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection40 : TriggerState {
            internal State2ndWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90830, 90832, 90834, 90836, 90838}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection41 : TriggerState {
            internal State2ndWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90831, 90833, 90835, 90837, 90839}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection50 : TriggerState {
            internal State2ndWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90840, 90842, 90844, 90846, 90848}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection51 : TriggerState {
            internal State2ndWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90841, 90843, 90845, 90847, 90849}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay4000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay5000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay6000(context);
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

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay5000 : TriggerState {
            internal State2ndWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay6000 : TriggerState {
            internal State2ndWaveDelay6000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
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
            }

            public override void Execute() {
                if (true) {
                    context.State = new State3rdWaveDirectionRandom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirectionRandom : TriggerState {
            internal State3rdWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3rdWaveDirection10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3rdWaveDirection20(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3rdWaveDirection30(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3rdWaveDirection40(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State3rdWaveDirection50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection10 : TriggerState {
            internal State3rdWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90800, 90802, 90804, 90806, 90808}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90801, 90803, 90805, 90807, 90809}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90810, 90812, 90814, 90816, 90818}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90811, 90813, 90815, 90817, 90819}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90820, 90822, 90824, 90826, 90828}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90821, 90823, 90825, 90827, 90829}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90830, 90832, 90834, 90836, 90838}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90831, 90833, 90835, 90837, 90839}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90840, 90842, 90844, 90846, 90848}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90841, 90843, 90845, 90847, 90849}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay : TriggerState {
            internal State3rdWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90841, 90843, 90845}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
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
                context.CreateMonster(arg1: new[] {90890, 90892, 90894, 90896, 90898}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State5thWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90891, 90893, 90895, 90897, 90899}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
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
                if (context.MonsterDead(arg1: new[] {
                    90800, 90801, 90802, 90803, 90804, 90805, 90806, 90807, 90808, 90810, 90810, 90811, 90812, 90813,
                    90814, 90815, 90816, 90817, 90818, 90819, 90820, 90821, 90822, 90823, 90824, 90825, 90826, 90827,
                    90828, 90829, 90830, 90831, 90832, 90833, 90834, 90835, 90836, 90837, 90838, 90839, 90840, 90841,
                    90842, 90843, 90844, 90845, 90846, 90847, 90848, 90849, 90880, 90881, 90882, 90883, 90884, 90885,
                    90886, 90887, 90888, 90889, 90890, 90891, 90892, 90893, 90894, 90895, 90896, 90897, 90898, 90899
                })) {
                    context.State = new StateDefenceSucess02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1008})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5108}, arg2: false);
                context.SetUserValue(triggerId: 8, key: "08RoundSuccess", value: 1);
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
                context.SetUserValue(triggerId: 808, key: "PenaltyMob", value: 1);
                context.DestroyMonster(arg1: new[] {1008});
                context.CreateMonster(arg1: new[] {1108}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52000052_QD__901_MOBWAVE_01ROUND__1$", arg3: 4000,
                    arg4: "0");
                context.SetConversation(arg1: 1, arg2: 1108, arg3: "$52000052_QD__901_MOBWAVE_01ROUND__2$", arg4: 4,
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
                if (context.GetUserValue(key: "PenaltyFinish") == 1) {
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
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$52000052_QD__901_MOBWAVE_01ROUND__3$", arg3: 4000,
                    arg4: "0");
                context.DestroyMonster(arg1: new[] {1108});
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 1108);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "WaveTime") == 1) {
                    context.State = new State2ndWaveStart(context);
                    return;
                }

                if (context.GetUserValue(key: "WaveTime") == 2) {
                    context.State = new State3rdWaveStart(context);
                    return;
                }

                if (context.GetUserValue(key: "WaveTime") == 3) {
                    context.State = new State5thWaveStart(context);
                    return;
                }

                if (context.GetUserValue(key: "WaveTime") == 5) {
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
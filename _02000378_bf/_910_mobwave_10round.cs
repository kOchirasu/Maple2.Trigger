namespace Maple2.Trigger._02000378_bf {
    public static class _910_mobwave_10round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(arg1: new[] {5110}, arg2: false);
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
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__910_MOBWAVE_10ROUND__0$", arg3: 6000,
                    arg4: "0");
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(arg1: new[] {5110}, arg2: true);
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
                context.CreateMonster(arg1: new[] {91004, 91006, 91008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection11 : TriggerState {
            internal State1stWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91005, 91007, 91010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection20 : TriggerState {
            internal State1stWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91014, 91016, 91018}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection21 : TriggerState {
            internal State1stWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91015, 91017, 91019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection30 : TriggerState {
            internal State1stWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91024, 91026, 91028}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection31 : TriggerState {
            internal State1stWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91025, 91027, 91029}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection40 : TriggerState {
            internal State1stWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91034, 91036, 91038}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection41 : TriggerState {
            internal State1stWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91035, 91037, 91039}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection50 : TriggerState {
            internal State1stWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91044, 91046, 91048}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection51 : TriggerState {
            internal State1stWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91045, 91047, 91049}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
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
                    context.State = new State1stWaveDelay4000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay5000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State1stWaveDelay6000(context);
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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
                context.CreateMonster(arg1: new[] {91000, 91002, 91004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection11 : TriggerState {
            internal State2ndWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91001, 91003, 91005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection20 : TriggerState {
            internal State2ndWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91010, 91012, 91014}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection21 : TriggerState {
            internal State2ndWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91011, 91013, 91015}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection30 : TriggerState {
            internal State2ndWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91020, 91022, 91024}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection31 : TriggerState {
            internal State2ndWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91021, 91023, 91025}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection40 : TriggerState {
            internal State2ndWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91030, 91032, 91034}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection41 : TriggerState {
            internal State2ndWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91031, 91033, 91035}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection50 : TriggerState {
            internal State2ndWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91040, 91042, 91044}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection51 : TriggerState {
            internal State2ndWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91041, 91043, 91045}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
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
                    context.State = new State2ndWaveDelay3000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay4000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State2ndWaveDelay5000(context);
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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

                if (context.MonsterDead(arg1: new[] {1010})) {
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
                context.CreateMonster(arg1: new[] {91000, 91002, 91008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91001, 91003, 91010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91010, 91012, 91018}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91011, 91013, 91019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91020, 91022, 91028}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91021, 91023, 91029}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91030, 91032, 91038}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91031, 91033, 91039}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91040, 91042, 91048}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91041, 91043, 91049}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelayRandom : TriggerState {
            internal State3rdWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State3rdWaveDelay2000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State3rdWaveDelay3000(context);
                    return;
                }

                if (context.RandomCondition(arg1: 30f)) {
                    context.State = new State3rdWaveDelay4000(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay2000 : TriggerState {
            internal State3rdWaveDelay2000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State4thWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay3000 : TriggerState {
            internal State3rdWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State4thWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay4000 : TriggerState {
            internal State3rdWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State4thWaveStart(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveStart : TriggerState {
            internal State4thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 4);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State4thWaveDirectionRandom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirectionRandom : TriggerState {
            internal State4thWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State4thWaveDirection10(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State4thWaveDirection20(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State4thWaveDirection30(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State4thWaveDirection40(context);
                    return;
                }

                if (context.RandomCondition(arg1: 20f)) {
                    context.State = new State4thWaveDirection50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection10 : TriggerState {
            internal State4thWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91000, 91006, 91008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection11 : TriggerState {
            internal State4thWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91001, 91007, 91010}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection20 : TriggerState {
            internal State4thWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91010, 91016, 91018}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection21 : TriggerState {
            internal State4thWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91011, 91017, 91019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection30 : TriggerState {
            internal State4thWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91020, 91026, 91028}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection31 : TriggerState {
            internal State4thWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91021, 91027, 91029}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection40 : TriggerState {
            internal State4thWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91030, 91036, 91038}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection41 : TriggerState {
            internal State4thWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91031, 91037, 91039}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection50 : TriggerState {
            internal State4thWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91040, 91046, 91048}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection51 : TriggerState {
            internal State4thWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91041, 91047, 91049}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
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
                context.CreateMonster(arg1: new[] {91090, 91092, 91094}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State5thWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {91091, 91093, 91095}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
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
                    91000, 91001, 91002, 91003, 91004, 91005, 91006, 91007, 91008, 91010, 91010, 91011, 91012, 91013,
                    91014, 91015, 91016, 91017, 91018, 91019, 91020, 91021, 91022, 91023, 91024, 91025, 91026, 91027,
                    91028, 91029, 91030, 91031, 91032, 91033, 91034, 91035, 91036, 91037, 91038, 91039, 91040, 91041,
                    91042, 91043, 91044, 91045, 91046, 91047, 91048, 91049, 91080, 91081, 91082, 91083, 91084, 91085,
                    91086, 91087, 91088, 91089, 91090, 91091, 91092, 91093, 91094, 91095, 91096, 91097, 91098, 91099
                })) {
                    context.State = new StateDefenceSucess02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1010})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5110}, arg2: false);
                context.SetUserValue(triggerId: 10, key: "10RoundSuccess", value: 1);
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
                context.SetUserValue(triggerId: 810, key: "PenaltyMob", value: 1);
                context.DestroyMonster(arg1: new[] {1010});
                context.CreateMonster(arg1: new[] {1110}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__910_MOBWAVE_10ROUND__1$", arg3: 4000,
                    arg4: "0");
                context.SetConversation(arg1: 1, arg2: 1110, arg3: "$02000378_BF__910_MOBWAVE_10ROUND__2$", arg4: 4,
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
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__910_MOBWAVE_10ROUND__3$", arg3: 4000,
                    arg4: "0");
                context.DestroyMonster(arg1: new[] {1110});
                context.CreateMonster(arg1: new[] {1010}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 1110);
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
                    context.State = new State4thWaveStart(context);
                    return;
                }

                if (context.GetUserValue(key: "WaveTime") == 4) {
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
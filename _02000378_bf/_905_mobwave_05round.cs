namespace Maple2.Trigger._02000378_bf {
    public static class _905_mobwave_05round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(arg1: new[] {5105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MobWaveStart") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart : TriggerState {
            internal State1stWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__905_MOBWAVE_05ROUND__0$", arg3: 6000, arg4: "0");
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(arg1: new[] {5105}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirectionRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirectionRandom : TriggerState {
            internal State1stWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State1stWaveDirection10(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State1stWaveDirection20(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State1stWaveDirection30(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State1stWaveDirection40(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State1stWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection10 : TriggerState {
            internal State1stWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90500, 90502, 90504}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection11(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection11 : TriggerState {
            internal State1stWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90501, 90503, 90505}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection20 : TriggerState {
            internal State1stWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90510, 90512, 90514}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection21(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection21 : TriggerState {
            internal State1stWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90511, 90513, 90515}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection30 : TriggerState {
            internal State1stWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90520, 90522, 90524}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection31(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection31 : TriggerState {
            internal State1stWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90521, 90523, 90525}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection40 : TriggerState {
            internal State1stWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90530, 90532, 90534}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection41(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection41 : TriggerState {
            internal State1stWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90531, 90533, 90535}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection50 : TriggerState {
            internal State1stWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90540, 90542, 90544}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection51(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection51 : TriggerState {
            internal State1stWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90541, 90543, 90545}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new State1stWaveDelay3000(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State1stWaveDelay4000(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State1stWaveDelay5000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay3000 : TriggerState {
            internal State1stWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay4000 : TriggerState {
            internal State1stWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay5000 : TriggerState {
            internal State1stWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart : TriggerState {
            internal State2ndWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirectionRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirectionRandom : TriggerState {
            internal State2ndWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State2ndWaveDirection10(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State2ndWaveDirection20(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State2ndWaveDirection30(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State2ndWaveDirection40(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State2ndWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection10 : TriggerState {
            internal State2ndWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90500, 90502, 90504}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection11(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection11 : TriggerState {
            internal State2ndWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90501, 90503, 90505}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection20 : TriggerState {
            internal State2ndWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90510, 90512, 90514}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection21(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection21 : TriggerState {
            internal State2ndWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90511, 90513, 90515}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection30 : TriggerState {
            internal State2ndWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90520, 90522, 90524}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection31(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection31 : TriggerState {
            internal State2ndWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90521, 90523, 90525}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection40 : TriggerState {
            internal State2ndWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90530, 90532, 90534}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection41(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection41 : TriggerState {
            internal State2ndWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90531, 90533, 90535}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection50 : TriggerState {
            internal State2ndWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90540, 90542, 90544}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection51(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection51 : TriggerState {
            internal State2ndWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90541, 90543, 90545}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new State2ndWaveDelay3000(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State2ndWaveDelay4000(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State2ndWaveDelay5000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay3000 : TriggerState {
            internal State2ndWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay4000 : TriggerState {
            internal State2ndWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay5000 : TriggerState {
            internal State2ndWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveStart : TriggerState {
            internal State3rdWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 3);
            }

            public override TriggerState Execute() {
                return new State3rdWaveDirectionRandom(context);
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirectionRandom : TriggerState {
            internal State3rdWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State3rdWaveDirection10(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3rdWaveDirection20(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3rdWaveDirection30(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3rdWaveDirection40(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State3rdWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection10 : TriggerState {
            internal State3rdWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90500, 90502, 90504}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection11(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90501, 90503, 90505}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90510, 90512, 90514}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection21(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90511, 90513, 90515}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90520, 90522, 90524}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection31(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90521, 90523, 90525}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90530, 90532, 90534}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection41(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90531, 90533, 90535}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90540, 90542, 90544}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection51(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90541, 90543, 90545}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelayRandom : TriggerState {
            internal State3rdWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 30f)) {
                    return new State3rdWaveDelay2000(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State3rdWaveDelay3000(context);
                }

                if (context.RandomCondition(arg1: 30f)) {
                    return new State3rdWaveDelay4000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay2000 : TriggerState {
            internal State3rdWaveDelay2000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay3000 : TriggerState {
            internal State3rdWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay4000 : TriggerState {
            internal State3rdWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveStart : TriggerState {
            internal State4thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 4);
            }

            public override TriggerState Execute() {
                return new State4thWaveDirectionRandom(context);
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirectionRandom : TriggerState {
            internal State4thWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new State4thWaveDirection10(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State4thWaveDirection20(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State4thWaveDirection30(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State4thWaveDirection40(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new State4thWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection10 : TriggerState {
            internal State4thWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90500, 90502, 90504}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection11(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection11 : TriggerState {
            internal State4thWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90501, 90503, 90505}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection20 : TriggerState {
            internal State4thWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90510, 90512, 90514}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection21(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection21 : TriggerState {
            internal State4thWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90511, 90513, 90515}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection30 : TriggerState {
            internal State4thWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90520, 90522, 90524}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection31(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection31 : TriggerState {
            internal State4thWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90521, 90523, 90525}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection40 : TriggerState {
            internal State4thWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90530, 90532, 90534}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection41(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection41 : TriggerState {
            internal State4thWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90531, 90533, 90535}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection50 : TriggerState {
            internal State4thWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90540, 90542, 90544}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection51 : TriggerState {
            internal State4thWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90541, 90543, 90545}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thWaveStart : TriggerState {
            internal State5thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 5);
                context.CreateMonster(arg1: new[] {90590, 90592, 90594}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5thWaveDelay(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90591, 90593, 90595}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess01 : TriggerState {
            internal StateDefenceSucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {90500, 90501, 90502, 90503, 90504, 90505, 90506, 90507, 90508, 90510, 90510, 90511, 90512, 90513, 90514, 90515, 90516, 90517, 90518, 90519, 90520, 90521, 90522, 90523, 90524, 90525, 90526, 90527, 90528, 90529, 90530, 90531, 90532, 90533, 90534, 90535, 90536, 90537, 90538, 90539, 90540, 90541, 90542, 90543, 90544, 90545, 90546, 90547, 90548, 90549, 90580, 90581, 90582, 90583, 90584, 90585, 90586, 90587, 90588, 90589, 90590, 90591, 90592, 90593, 90594, 90595, 90596, 90597, 90598, 90599})) {
                    return new StateDefenceSucess02(context);
                }

                if (context.MonsterDead(arg1: new[] {1005})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5105}, arg2: false);
                context.SetUserValue(triggerId: 5, key: "05RoundSuccess", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDownPenaltyStart : TriggerState {
            internal StateNpcDownPenaltyStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 805, key: "PenaltyMob", value: 1);
                context.DestroyMonster(arg1: new[] {1005});
                context.CreateMonster(arg1: new[] {1105}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__905_MOBWAVE_05ROUND__1$", arg3: 4000, arg4: "0");
                context.SetConversation(arg1: 1, arg2: 1105, arg3: "$02000378_BF__905_MOBWAVE_05ROUND__2$", arg4: 4, arg5: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateNpcDownPenaltyEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcDownPenaltyEnd : TriggerState {
            internal StateNpcDownPenaltyEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PenaltyFinish") == 1) {
                    return new StateReturnToWave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnToWave : TriggerState {
            internal StateReturnToWave(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__905_MOBWAVE_05ROUND__3$", arg3: 4000, arg4: "0");
                context.DestroyMonster(arg1: new[] {1105});
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 1105);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WaveTime") == 1) {
                    return new State2ndWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 2) {
                    return new State3rdWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 3) {
                    return new State4thWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 4) {
                    return new State5thWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 5) {
                    return new State5thWaveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
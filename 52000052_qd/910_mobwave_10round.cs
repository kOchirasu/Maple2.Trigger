namespace Maple2.Trigger._52000052_qd {
    public static class _910_mobwave_10round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(triggerIds: new []{5110}, visible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$52000052_QD__901_MOBWAVE_01ROUND__0$", duration: 6000, boxId: 0);
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(triggerIds: new []{5110}, visible: true);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20f)) {
                    return new State1stWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State1stWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State1stWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State1stWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State1stWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection10 : TriggerState {
            internal State1stWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91000, 91002, 91004, 91006, 91008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection11 : TriggerState {
            internal State1stWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91001, 91003, 91005, 91007, 91010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection20 : TriggerState {
            internal State1stWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91010, 91012, 91014, 91016, 91018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection21 : TriggerState {
            internal State1stWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91011, 91013, 91015, 91017, 91019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection30 : TriggerState {
            internal State1stWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91020, 91022, 91024, 91026, 91028}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection31 : TriggerState {
            internal State1stWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91021, 91023, 91025, 91027, 91029}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection40 : TriggerState {
            internal State1stWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91030, 91032, 91034, 91036, 91038}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection41 : TriggerState {
            internal State1stWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91031, 91033, 91035, 91037, 91039}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection50 : TriggerState {
            internal State1stWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91040, 91042, 91044, 91046, 91048}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection51 : TriggerState {
            internal State1stWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91041, 91043, 91045, 91047, 91049}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30f)) {
                    return new State1stWaveDelay7000(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    return new State1stWaveDelay8000(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    return new State1stWaveDelay9000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay7000 : TriggerState {
            internal State1stWaveDelay7000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay8000 : TriggerState {
            internal State1stWaveDelay8000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay9000 : TriggerState {
            internal State1stWaveDelay9000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
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

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirectionRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirectionRandom : TriggerState {
            internal State2ndWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20f)) {
                    return new State2ndWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State2ndWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State2ndWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State2ndWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State2ndWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection10 : TriggerState {
            internal State2ndWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91000, 91002, 91004, 91006, 91008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection11 : TriggerState {
            internal State2ndWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91001, 91003, 91005, 91007, 91010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection20 : TriggerState {
            internal State2ndWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91010, 91012, 91014, 91016, 91018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection21 : TriggerState {
            internal State2ndWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91011, 91013, 91015, 91017, 91019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection30 : TriggerState {
            internal State2ndWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91020, 91022, 91024, 91026, 91028}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection31 : TriggerState {
            internal State2ndWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91021, 91023, 91025, 91027, 91029}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection40 : TriggerState {
            internal State2ndWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91030, 91032, 91034, 91036, 91038}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection41 : TriggerState {
            internal State2ndWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91031, 91033, 91035, 91037, 91039}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection50 : TriggerState {
            internal State2ndWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91040, 91042, 91044, 91046, 91048}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection51 : TriggerState {
            internal State2ndWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91041, 91043, 91045, 91047, 91049}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30f)) {
                    return new State2ndWaveDelay5000(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    return new State2ndWaveDelay6000(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    return new State2ndWaveDelay7000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay5000 : TriggerState {
            internal State2ndWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay6000 : TriggerState {
            internal State2ndWaveDelay6000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay7000 : TriggerState {
            internal State2ndWaveDelay7000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
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

            public override TriggerState? Execute() {
                return new State3rdWaveDirectionRandom(context);
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirectionRandom : TriggerState {
            internal State3rdWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20f)) {
                    return new State3rdWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3rdWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3rdWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3rdWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State3rdWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection10 : TriggerState {
            internal State3rdWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91000, 91002, 91004, 91006, 91008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91001, 91003, 91005, 91007, 91010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91010, 91012, 91014, 91016, 91018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91011, 91013, 91015, 91017, 91019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91020, 91022, 91024, 91026, 91028}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91021, 91023, 91025, 91027, 91029}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91030, 91032, 91034, 91036, 91038}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91031, 91033, 91035, 91037, 91039}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91040, 91042, 91044, 91046, 91048}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91041, 91043, 91045, 91047, 91049}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelayRandom : TriggerState {
            internal State3rdWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30f)) {
                    return new State3rdWaveDelay3000(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    return new State3rdWaveDelay4000(context);
                }

                if (context.RandomCondition(rate: 30f)) {
                    return new State3rdWaveDelay5000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay3000 : TriggerState {
            internal State3rdWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay4000 : TriggerState {
            internal State3rdWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay5000 : TriggerState {
            internal State3rdWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
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

            public override TriggerState? Execute() {
                return new State4thWaveDirectionRandom(context);
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirectionRandom : TriggerState {
            internal State4thWaveDirectionRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20f)) {
                    return new State4thWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State4thWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State4thWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State4thWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new State4thWaveDirection50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection10 : TriggerState {
            internal State4thWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91000, 91002, 91004, 91006, 91008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection11 : TriggerState {
            internal State4thWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91001, 91003, 91005, 91007, 91010}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection20 : TriggerState {
            internal State4thWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91010, 91012, 91014, 91016, 91018}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection21 : TriggerState {
            internal State4thWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91011, 91013, 91015, 91017, 91019}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection30 : TriggerState {
            internal State4thWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91020, 91022, 91024, 91026, 91028}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection31 : TriggerState {
            internal State4thWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91021, 91023, 91025, 91027, 91029}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection40 : TriggerState {
            internal State4thWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91030, 91032, 91034, 91036, 91038}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection41 : TriggerState {
            internal State4thWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91031, 91033, 91035, 91037, 91039}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection50 : TriggerState {
            internal State4thWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91040, 91042, 91044, 91046, 91048}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection51 : TriggerState {
            internal State4thWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91041, 91043, 91045, 91047, 91049}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
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
                context.CreateMonster(spawnIds: new []{91090, 91092, 91094, 91096, 91098}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{91091, 91093, 91095, 91097, 91099}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess01 : TriggerState {
            internal StateDefenceSucess01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{91000, 91001, 91002, 91003, 91004, 91005, 91006, 91007, 91008, 91010, 91010, 91011, 91012, 91013, 91014, 91015, 91016, 91017, 91018, 91019, 91020, 91021, 91022, 91023, 91024, 91025, 91026, 91027, 91028, 91029, 91030, 91031, 91032, 91033, 91034, 91035, 91036, 91037, 91038, 91039, 91040, 91041, 91042, 91043, 91044, 91045, 91046, 91047, 91048, 91049, 91080, 91081, 91082, 91083, 91084, 91085, 91086, 91087, 91088, 91089, 91090, 91091, 91092, 91093, 91094, 91095, 91096, 91097, 91098, 91099})) {
                    return new StateDefenceSucess02(context);
                }

                if (context.MonsterDead(spawnIds: new []{1010})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5110}, visible: false);
                context.SetUserValue(triggerId: 10, key: "10RoundSuccess", value: 1);
            }

            public override TriggerState? Execute() {
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
                context.SetUserValue(triggerId: 810, key: "PenaltyMob", value: 1);
                context.DestroyMonster(spawnIds: new []{1010});
                context.CreateMonster(spawnIds: new []{1110}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$52000052_QD__901_MOBWAVE_01ROUND__1$", duration: 4000, boxId: 0);
                context.SetConversation(type: 1, spawnId: 1110, script: "$52000052_QD__901_MOBWAVE_01ROUND__2$", arg4: 4, arg5: 4);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$52000052_QD__901_MOBWAVE_01ROUND__3$", duration: 4000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{1110});
                context.CreateMonster(spawnIds: new []{1010}, arg2: false);
                context.RemoveBalloonTalk(spawnId: 1110);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

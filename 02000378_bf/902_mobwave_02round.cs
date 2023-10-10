namespace Maple2.Trigger._02000378_bf {
    public static class _902_mobwave_02round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(triggerIds: new []{5102}, visible: false);
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
                context.SetEventUI(arg1: 1, script: "$02000378_BF__902_MOBWAVE_02ROUND__0$", duration: 6000, boxId: 0);
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(triggerIds: new []{5102}, visible: true);
                context.CreateMonster(spawnIds: new []{90200, 90202, 90204}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90201, 90203, 90205}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new State1stWaveDelay3000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State1stWaveDelay4000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State1stWaveDelay5000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay3000 : TriggerState {
            internal State1stWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay4000 : TriggerState {
            internal State1stWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelay5000 : TriggerState {
            internal State1stWaveDelay5000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State2ndWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
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
                context.CreateMonster(spawnIds: new []{90210, 90212, 90214}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90211, 90213, 90215}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 30)) {
                    return new State2ndWaveDelay3000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State2ndWaveDelay4000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State2ndWaveDelay2000(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay3000 : TriggerState {
            internal State2ndWaveDelay3000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay4000 : TriggerState {
            internal State2ndWaveDelay4000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelay2000 : TriggerState {
            internal State2ndWaveDelay2000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State3rdWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
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
                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection50(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State3rdWaveDirection60(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection10 : TriggerState {
            internal State3rdWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90220, 90222, 90224}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90221, 90223, 90225}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90230, 90232, 90234}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90231, 90233, 90235}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90240, 90242, 90244}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90241, 90243, 90245}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90250, 90252, 90254}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90251, 90253, 90255}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90260, 90262, 90264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90261, 90263, 90265}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection60 : TriggerState {
            internal State3rdWaveDirection60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90270, 90272, 90274}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDirection61(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection61 : TriggerState {
            internal State3rdWaveDirection61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90271, 90273, 90275}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelayRandom(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
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
                if (context.RandomCondition(rate: 30)) {
                    return new State3rdWaveDelay3000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State3rdWaveDelay4000(context);
                }

                if (context.RandomCondition(rate: 30)) {
                    return new State3rdWaveDelay2000(context);
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

                if (context.MonsterDead(spawnIds: new []{1002})) {
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

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay2000 : TriggerState {
            internal State3rdWaveDelay2000(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State4thWaveStart(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
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
                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection10(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection20(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection30(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection40(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection50(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new State4thWaveDirection60(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection10 : TriggerState {
            internal State4thWaveDirection10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90220, 90222, 90224}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection11(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection11 : TriggerState {
            internal State4thWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90221, 90223, 90225}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection20 : TriggerState {
            internal State4thWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90230, 90232, 90234}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection21(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection21 : TriggerState {
            internal State4thWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90231, 90233, 90235}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection30 : TriggerState {
            internal State4thWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90240, 90242, 90244}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection31(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection31 : TriggerState {
            internal State4thWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90241, 90243, 90245}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection40 : TriggerState {
            internal State4thWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90250, 90252, 90254}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection41(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection41 : TriggerState {
            internal State4thWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90251, 90253, 90255}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection50 : TriggerState {
            internal State4thWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90260, 90262, 90264}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection51(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection51 : TriggerState {
            internal State4thWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90261, 90263, 90265}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection60 : TriggerState {
            internal State4thWaveDirection60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90270, 90272, 90274}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDirection61(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection61 : TriggerState {
            internal State4thWaveDirection61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90271, 90273, 90275}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State4thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4thWaveDelay : TriggerState {
            internal State4thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90220, 90222, 90224}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6thWaveStart : TriggerState {
            internal State6thWaveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "WaveTime", value: 6);
                context.CreateMonster(spawnIds: new []{90290, 90292, 90294}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State6thWaveDelay(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6thWaveDelay : TriggerState {
            internal State6thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90291, 90293, 90295}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
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
                if (context.MonsterDead(spawnIds: new []{90200, 90201, 90202, 90203, 90204, 90205, 90206, 90207, 90208, 90209, 90210, 90211, 90212, 90213, 90214, 90215, 90216, 90217, 90218, 90219, 90220, 90221, 90222, 90223, 90224, 90225, 90226, 90227, 90228, 90229, 90230, 90231, 90232, 90233, 90234, 90235, 90236, 90237, 90238, 90239, 90240, 90241, 90242, 90243, 90244, 90245, 90246, 90247, 90248, 90249, 90250, 90251, 90252, 90253, 90254, 90255, 90256, 90257, 90258, 90259, 90260, 90261, 90262, 90263, 90264, 90265, 90266, 90267, 90268, 90269, 90270, 90271, 90272, 90273, 90274, 90275, 90276, 90277, 90278, 90279, 90280, 90281, 90282, 90283, 90284, 90285, 90286, 90287, 90288, 90289, 90290, 90291, 90292, 90293, 90294, 90295, 90296, 90297, 90298, 90299})) {
                    return new StateDefenceSucess02(context);
                }

                if (context.MonsterDead(spawnIds: new []{1002})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5102}, visible: false);
                context.SetUserValue(triggerId: 2, key: "02RoundSuccess", value: 1);
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
                context.SetUserValue(triggerId: 802, key: "PenaltyMob", value: 1);
                context.DestroyMonster(spawnIds: new []{1002});
                context.CreateMonster(spawnIds: new []{1102}, arg2: false);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetEventUI(arg1: 1, script: "$02000378_BF__902_MOBWAVE_02ROUND__1$", duration: 4000, boxId: 0);
                context.SetConversation(type: 1, spawnId: 1102, script: "$02000378_BF__902_MOBWAVE_02ROUND__2$", arg4: 4, arg5: 4);
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
                context.SetEventUI(arg1: 1, script: "$02000378_BF__902_MOBWAVE_02ROUND__3$", duration: 4000, boxId: 0);
                context.DestroyMonster(spawnIds: new []{1102});
                context.CreateMonster(spawnIds: new []{1002}, arg2: false);
                context.RemoveBalloonTalk(spawnId: 1102);
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
                    return new State6thWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 6) {
                    return new State6thWaveStart(context);
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

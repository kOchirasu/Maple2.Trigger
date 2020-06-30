using System;

namespace Maple2.Trigger._02000378_bf {
    public static class _906_mobwave_06round {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(arg1: new int[] {5106}, arg2: false);
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
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__906_MOBWAVE_06ROUND__0$", arg3: new int[] {6000},
                    arg4: "0");
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(arg1: new int[] {5106}, arg2: true);
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
                context.CreateMonster(arg1: new int[] {90600, 90602, 90604}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection11 : TriggerState {
            internal State1stWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90601, 90603, 90605}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection20 : TriggerState {
            internal State1stWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90610, 90612, 90614}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection21 : TriggerState {
            internal State1stWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90611, 90613, 90615}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection30 : TriggerState {
            internal State1stWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90620, 90622, 90624}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection31 : TriggerState {
            internal State1stWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90621, 90623, 90625}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection40 : TriggerState {
            internal State1stWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90630, 90632, 90634}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection41 : TriggerState {
            internal State1stWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90631, 90633, 90635}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection50 : TriggerState {
            internal State1stWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90640, 90642, 90644}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveDirection51 : TriggerState {
            internal State1stWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90641, 90643, 90645}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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
                context.CreateMonster(arg1: new int[] {90600, 90602, 90604}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection11 : TriggerState {
            internal State2ndWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90601, 90603, 90605}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection20 : TriggerState {
            internal State2ndWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90610, 90612, 90614}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection21 : TriggerState {
            internal State2ndWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90611, 90613, 90615}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection30 : TriggerState {
            internal State2ndWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90620, 90622, 90624}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection31 : TriggerState {
            internal State2ndWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90621, 90623, 90625}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection40 : TriggerState {
            internal State2ndWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90630, 90632, 90634}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection41 : TriggerState {
            internal State2ndWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90631, 90633, 90635}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection50 : TriggerState {
            internal State2ndWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90640, 90642, 90644}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDirection51 : TriggerState {
            internal State2ndWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90641, 90643, 90645}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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
                context.CreateMonster(arg1: new int[] {90600, 90602, 90604}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection11 : TriggerState {
            internal State3rdWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90601, 90603, 90605}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection20 : TriggerState {
            internal State3rdWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90610, 90612, 90614}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection21 : TriggerState {
            internal State3rdWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90611, 90613, 90615}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection30 : TriggerState {
            internal State3rdWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90620, 90622, 90624}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection31 : TriggerState {
            internal State3rdWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90621, 90623, 90625}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection40 : TriggerState {
            internal State3rdWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90630, 90632, 90634}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection41 : TriggerState {
            internal State3rdWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90631, 90633, 90635}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection50 : TriggerState {
            internal State3rdWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90640, 90642, 90644}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDirection51(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDirection51 : TriggerState {
            internal State3rdWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90641, 90643, 90645}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State3rdWaveDelayRandom(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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

                if (context.MonsterDead(arg1: new int[] {1006})) {
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
                context.CreateMonster(arg1: new int[] {90600, 90602, 90604}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection11(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection11 : TriggerState {
            internal State4thWaveDirection11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90601, 90603, 90605}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection20 : TriggerState {
            internal State4thWaveDirection20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90610, 90612, 90614}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection21(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection21 : TriggerState {
            internal State4thWaveDirection21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90611, 90613, 90615}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection30 : TriggerState {
            internal State4thWaveDirection30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90620, 90622, 90624}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection31(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection31 : TriggerState {
            internal State4thWaveDirection31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90621, 90623, 90625}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection40 : TriggerState {
            internal State4thWaveDirection40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90630, 90632, 90634}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State4thWaveDirection41(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection41 : TriggerState {
            internal State4thWaveDirection41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90631, 90633, 90635}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection50 : TriggerState {
            internal State4thWaveDirection50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90640, 90642, 90644}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4thWaveDirection51 : TriggerState {
            internal State4thWaveDirection51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90641, 90643, 90645}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
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
                context.CreateMonster(arg1: new int[] {90690, 90692, 90694}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State5thWaveDelay(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {90691, 90693, 90695}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDefenceSucess01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
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
                    90600, 90601, 90602, 90603, 90604, 90605, 90606, 90607, 90608, 90610, 90610, 90611, 90612, 90613,
                    90614, 90615, 90616, 90617, 90618, 90619, 90620, 90621, 90622, 90623, 90624, 90625, 90626, 90627,
                    90628, 90629, 90630, 90631, 90632, 90633, 90634, 90635, 90636, 90637, 90638, 90639, 90640, 90641,
                    90642, 90643, 90644, 90645, 90646, 90647, 90648, 90649, 90680, 90681, 90682, 90683, 90684, 90685,
                    90686, 90687, 90688, 90689, 90690, 90691, 90692, 90693, 90694, 90695, 90696, 90697, 90698, 90699
                })) {
                    context.State = new StateDefenceSucess02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1006})) {
                    context.State = new StateNpcDownPenaltyStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5106}, arg2: false);
                context.SetUserValue(triggerID: 6, key: "06RoundSuccess", value: 1);
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
                context.SetUserValue(triggerID: 806, key: "PenaltyMob", value: 1);
                context.DestroyMonster(arg1: new int[] {1006});
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__906_MOBWAVE_06ROUND__1$", arg3: new int[] {4000},
                    arg4: "0");
                context.SetConversation(arg1: 1, arg2: 1106, arg3: "$02000378_BF__906_MOBWAVE_06ROUND__2$", arg4: 4,
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
                context.SetEventUI(arg1: 1, arg2: "$02000378_BF__906_MOBWAVE_06ROUND__3$", arg3: new int[] {4000},
                    arg4: "0");
                context.DestroyMonster(arg1: new int[] {1106});
                context.CreateMonster(arg1: new int[] {1006}, arg2: false);
                context.RemoveBalloonTalk(spawnPointID: 1106);
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
                    context.State = new State4thWaveStart(context);
                    return;
                }

                if (context.UserValue(key: "WaveTime", value: 4)) {
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
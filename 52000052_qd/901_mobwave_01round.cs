namespace Maple2.Trigger._52000052_qd {
    public static class _901_mobwave_01round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyFinish", value: 0);
                context.SetUserValue(key: "WaveTime", value: 0);
                context.SetEffect(arg1: new[] {5101}, arg2: false);
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
                context.SetEventUI(arg1: 1, script: "$52000052_QD__901_MOBWAVE_01ROUND__0$", arg3: 6000, arg4: "0");
                context.SetUserValue(key: "WaveTime", value: 1);
                context.SetEffect(arg1: new[] {5101}, arg2: true);
                context.CreateMonster(arg1: new[] {90100, 90102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveDelayRandom : TriggerState {
            internal State1stWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90105, 90107, 90109}, arg2: false);
            }

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

                if (context.MonsterDead(arg1: new[] {1001})) {
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

                if (context.MonsterDead(arg1: new[] {1001})) {
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

                if (context.MonsterDead(arg1: new[] {1001})) {
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
                context.CreateMonster(arg1: new[] {90116, 90118}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveDelayRandom(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveDelayRandom : TriggerState {
            internal State2ndWaveDelayRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90113, 90115, 90117}, arg2: false);
            }

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

                if (context.MonsterDead(arg1: new[] {1001})) {
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

                if (context.MonsterDead(arg1: new[] {1001})) {
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

                if (context.MonsterDead(arg1: new[] {1001})) {
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
                context.CreateMonster(arg1: new[] {90124, 90126}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State3rdWaveDelay(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3rdWaveDelay : TriggerState {
            internal State3rdWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90121, 90125, 90129}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
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
                context.CreateMonster(arg1: new[] {90192, 90196}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State5thWaveDelay(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5thWaveDelay : TriggerState {
            internal State5thWaveDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90195, 90197, 90199}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateDefenceSucess01(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
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
                if (context.MonsterDead(arg1: new[] {90100, 90101, 90102, 90103, 90104, 90105, 90106, 90107, 90108, 90109, 90110, 90111, 90112, 90113, 90114, 90115, 90116, 90117, 90118, 90119, 90120, 90121, 90122, 90123, 90124, 90125, 90126, 90127, 90128, 90129, 90130, 90131, 90132, 90133, 90134, 90135, 90136, 90137, 90138, 90139, 90180, 90181, 90182, 90183, 90184, 90185, 90186, 90187, 90188, 90189, 90190, 90191, 90192, 90193, 90194, 90195, 90196, 90197, 90198, 90199})) {
                    return new StateDefenceSucess02(context);
                }

                if (context.MonsterDead(arg1: new[] {1001})) {
                    return new StateNpcDownPenaltyStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDefenceSucess02 : TriggerState {
            internal StateDefenceSucess02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5101}, arg2: false);
                context.SetUserValue(triggerId: 1, key: "01RoundSuccess", value: 1);
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
                context.SetUserValue(triggerId: 801, key: "PenaltyMob", value: 1);
                context.DestroyMonster(arg1: new[] {1001});
                context.CreateMonster(arg1: new[] {1101}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEventUI(arg1: 1, script: "$52000052_QD__901_MOBWAVE_01ROUND__1$", arg3: 4000, arg4: "0");
                context.SetConversation(arg1: 1, arg2: 1101, script: "$52000052_QD__901_MOBWAVE_01ROUND__2$", arg4: 4, arg5: 4);
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
                context.SetEventUI(arg1: 1, script: "$52000052_QD__901_MOBWAVE_01ROUND__3$", arg3: 4000, arg4: "0");
                context.DestroyMonster(arg1: new[] {1101});
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.RemoveBalloonTalk(spawnPointId: 1101);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "WaveTime") == 1) {
                    return new State2ndWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 2) {
                    return new State3rdWaveStart(context);
                }

                if (context.GetUserValue(key: "WaveTime") == 3) {
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
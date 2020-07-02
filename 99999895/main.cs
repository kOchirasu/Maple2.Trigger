namespace Maple2.Trigger._99999895 {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMonster스폰대기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰대기1 : TriggerState {
            internal StateMonster스폰대기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "첫 번째 상대가 곧 출현합니다. 전투 준비를 하세요!!", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCount1_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount1_1 : TriggerState {
            internal StateCount1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "3", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCount1_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount1_2 : TriggerState {
            internal StateCount1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "2", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCount1_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount1_3 : TriggerState {
            internal StateCount1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "1", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonster스폰1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰1 : TriggerState {
            internal StateMonster스폰1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "시작!!", arg3: 1000);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스폰대사1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰대사1 : TriggerState {
            internal State스폰대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "네 마음가짐과 기량을 한 번 볼까?", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.AddBalloonTalk(spawnPointId: 101, msg: "너 따위 애송이에게 지다니...", duration: 3000);
                    return new StateMonster스폰대기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰대기2 : TriggerState {
            internal StateMonster스폰대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "첫 전투에서 승리하셨습니다. 잠시만 기다려주세요 다음전투가 기다리고 있습니다!!", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCount2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount2_1 : TriggerState {
            internal StateCount2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "3", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCount2_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount2_2 : TriggerState {
            internal StateCount2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "2", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCount2_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount2_3 : TriggerState {
            internal StateCount2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "1", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonster스폰2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰2 : TriggerState {
            internal StateMonster스폰2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "시작!!", arg3: 1000);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스폰대사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰대사2 : TriggerState {
            internal State스폰대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "와라!! 얼마나 성장했는지 보겠다!", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    context.AddBalloonTalk(spawnPointId: 102, msg: "꽤 하는군. 즐거운 싸움이었다.", duration: 3000);
                    return new StateMonster스폰대기3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰대기3 : TriggerState {
            internal StateMonster스폰대기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "두 번째 전투에서 승리하셨습니다. 잠시만 기다려주세요 마지막 전투가 기다리고 있습니다!!", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCount3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount3_1 : TriggerState {
            internal StateCount3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "3", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCount3_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount3_2 : TriggerState {
            internal StateCount3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "2", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCount3_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount3_3 : TriggerState {
            internal StateCount3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "1", arg3: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateMonster스폰3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster스폰3 : TriggerState {
            internal StateMonster스폰3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "시작!!", arg3: 1000);
                context.CreateMonster(arg1: new[] {103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State스폰대사3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰대사3 : TriggerState {
            internal State스폰대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 103, msg: "그동안 어떤 성과를 이루셨는지 보여주세요.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103})) {
                    context.AddBalloonTalk(spawnPointId: 103, msg: "좋은 실력입니다. 엘리넬 학생들에게 귀감이 될 분이시군요.", duration: 3000);
                    return new State대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대사 : TriggerState {
            internal State대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, arg2: "SUCCESS", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State안내(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "곧 다시 전투가 시작됩니다. 준비하세요!!", arg3: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
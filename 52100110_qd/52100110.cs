namespace Maple2.Trigger._52100110_qd {
    public static class _52100110 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10000}, arg2: false);
                context.SetEffect(arg1: new[] {601}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1000})) {
                    return new StateQuest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101040}, arg3: new byte[] {1})) {
                    return new State화이트박스Remove(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101030}, arg3: new byte[] {3})) {
                    return new State52100105로텔레포트(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101030}, arg3: new byte[] {2})) {
                    return new StateQuest용MonsterSpawn(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101030}, arg3: new byte[] {1})) {
                    return new StateQuest용MonsterSpawn(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101020}, arg3: new byte[] {3})) {
                    return new StateQuest용MonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크2 : TriggerState {
            internal StateQuest체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101040}, arg3: new byte[] {1})) {
                    return new State화이트박스Remove(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {50101030}, arg3: new byte[] {3})) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52100105로텔레포트 : TriggerState {
            internal State52100105로텔레포트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10000}, arg2: true);
                context.MoveUser(arg1: 52100105, arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest용MonsterSpawn : TriggerState {
            internal StateQuest용MonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State화이트박스Creation2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화이트박스Creation2 : TriggerState {
            internal State화이트박스Creation2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest체크2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State화이트박스Remove : TriggerState {
            internal State화이트박스Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10000}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
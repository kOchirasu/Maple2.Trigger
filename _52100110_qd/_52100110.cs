using System;

namespace Maple2.Trigger._52100110_qd {
    public static class _52100110 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: false);
                context.SetEffect(arg1: new int[] {601}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {1000})) {
                    context.State = new State퀘스트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트체크 : TriggerState {
            internal State퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101040},
                    arg3: new byte[] {1})) {
                    context.State = new State화이트박스제거(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101030},
                    arg3: new byte[] {3})) {
                    context.State = new State52100105로텔레포트(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101030},
                    arg3: new byte[] {2})) {
                    context.State = new State퀘스트용몬스터스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101030},
                    arg3: new byte[] {1})) {
                    context.State = new State퀘스트용몬스터스폰(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101020},
                    arg3: new byte[] {3})) {
                    context.State = new State퀘스트용몬스터스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트체크2 : TriggerState {
            internal State퀘스트체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101040},
                    arg3: new byte[] {1})) {
                    context.State = new State화이트박스제거(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50101030},
                    arg3: new byte[] {3})) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State52100105로텔레포트 : TriggerState {
            internal State52100105로텔레포트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: true);
                context.MoveUser(arg1: 52100105, arg2: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State퀘스트용몬스터스폰 : TriggerState {
            internal State퀘스트용몬스터스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State화이트박스생성2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화이트박스생성2 : TriggerState {
            internal State화이트박스생성2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State퀘스트체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State화이트박스제거 : TriggerState {
            internal State화이트박스제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
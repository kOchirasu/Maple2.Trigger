namespace Maple2.Trigger._02000037_bf {
    public static class _trigger_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}, arg2: true, arg3: 0, arg4: 0);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2000})) {
                    context.State = new State발판(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    context.State = new State발판(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판 : TriggerState {
            internal State발판(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}, arg2: false, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State포털등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포털등장 : TriggerState {
            internal State포털등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: true, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2000, 2001})) {
                    context.State = new State발록죽음(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발록죽음 : TriggerState {
            internal State발록죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 10, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25}, arg2: true, arg3: 0, arg4: 200);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
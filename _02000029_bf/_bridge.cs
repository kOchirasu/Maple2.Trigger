namespace Maple2.Trigger._02000029_bf {
    public static class _bridge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {99})) {
                    context.State = new State발판01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판01 : TriggerState {
            internal State발판01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322
                    }, arg2: false, arg3: 0, arg4: 200, arg5: 2f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {99})) {
                    context.State = new State해모칸죽음(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State해모칸죽음 : TriggerState {
            internal State해모칸죽음(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319,
                        320, 321, 322
                    }, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02010055_bf {
    public static class _barricade {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2099})) {
                    context.State = new State카운트(context);
                    return;
                }

                if (context.MonsterInCombat(arg1: new[] {2199})) {
                    context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000384_BF__BARRICADE__0$", arg3: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State차단(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단 : TriggerState {
            internal State차단(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetEffect(arg1: new[] {602}, arg2: true);
                context.SetEffect(arg1: new[] {603}, arg2: true);
                context.SetMesh(arg1: new[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2099, 2199})) {
                    context.State = new State차단해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단해제 : TriggerState {
            internal State차단해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
                context.SetEffect(arg1: new[] {602}, arg2: false);
                context.SetEffect(arg1: new[] {603}, arg2: false);
                context.SetMesh(arg1: new[] {3000}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
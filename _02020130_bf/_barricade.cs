namespace Maple2.Trigger._02020130_bf {
    public static class _barricade {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {701, 702, 703})) {
                    context.State = new State카운트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트 : TriggerState {
            internal State카운트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020130_BF__BARRICADE__0$", arg3: 5500);
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
                context.SetMesh(
                    arg1: new[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {701, 702, 703})) {
                    context.State = new State차단해제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State차단해제 : TriggerState {
            internal State차단해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016,
                        3017, 3018, 3019, 3020, 3021, 3022
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
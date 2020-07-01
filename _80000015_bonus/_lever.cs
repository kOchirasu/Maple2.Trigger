namespace Maple2.Trigger._80000015_bonus {
    public static class _lever {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7101}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001314}, arg2: 1);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State안내(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10001314}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$80000015_bonus__lever__0$", arg3: 2000, arg4: "101");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001314}, arg2: 0)) {
                    context.State = new State문열림(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State반응대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {2001}, isAutoTargeting: false, score: 1500);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 0f);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999101, key: "Dead_A", value: 1);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetSkill(arg1: new[] {7101}, arg2: true);
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
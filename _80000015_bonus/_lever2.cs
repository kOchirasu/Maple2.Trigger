namespace Maple2.Trigger._80000015_bonus {
    public static class _lever2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {7102}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001315}, arg2: 1);
                context.SetMesh(arg1: new[] {3006, 3007, 3008, 3009, 3010, 3011}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State반응대기 : TriggerState {
            internal State반응대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State안내(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10001315}, arg2: 0)) {
                    return new State문열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내 : TriggerState {
            internal State안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$80000015_bonus__lever2__0$", arg3: 2000, arg4: "102");
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001315}, arg2: 0)) {
                    return new State문열림(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new State반응대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State문열림 : TriggerState {
            internal State문열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {2002}, isAutoTargeting: false, score: 1500);
                context.SetMesh(arg1: new[] {3006, 3007, 3008, 3009, 3010, 3011}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2002})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 999101, key: "Dead_B", value: 1);
                context.SetEffect(arg1: new[] {6000}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetSkill(arg1: new[] {7102}, arg2: true);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
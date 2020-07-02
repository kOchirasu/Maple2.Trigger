namespace Maple2.Trigger._02010054_bf {
    public static class _star_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000860}, arg2: 2);
                context.SetEffect(arg1: new[] {605}, arg2: false);
                context.SetMesh(arg1: new[] {3306, 3307, 3308, 3309}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3125}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3306, 3307, 3308, 3309}, arg2: true, arg3: 0, arg4: 500, arg5: 3f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3306, 3307, 3308, 3309}, arg2: false, arg3: 0, arg4: 900, arg5: 3f);
                context.SetMesh(arg1: new[] {3125}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                context.SetEffect(arg1: new[] {605}, arg2: true);
                context.CreateMonster(arg1: new[] {2004}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2004})) {
                    context.SetInteractObject(arg1: new[] {10000860}, arg2: 1);
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
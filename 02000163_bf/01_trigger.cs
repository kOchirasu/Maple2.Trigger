namespace Maple2.Trigger._02000163_bf {
    public static class _01_trigger {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.SetEffect(arg1: new[] {201, 202, 203, 204}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000079}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000079}, arg2: 0)) {
                    context.DestroyMonster(arg1: new[] {101});
                    context.SetEffect(arg1: new[] {201, 202, 203, 204}, arg2: false);
                    return new State매킨Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨Creation : TriggerState {
            internal State매킨Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102});
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State매킨대사(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨대사 : TriggerState {
            internal State매킨대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, script: "$02000163_BF__01_TRIGGER__0$", arg4: 3);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_102");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 301, arg2: new[] {102})) {
                    return new State매킨이동302(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨이동302 : TriggerState {
            internal State매킨이동302(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(arg1: new[] {201}, arg2: 0, arg3: 10000079);
                context.SetTimer(id: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State매킨이동304(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State매킨이동304 : TriggerState {
            internal State매킨이동304(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 304, arg2: new[] {102})) {
                    return new StateTriggerReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTriggerReset : TriggerState {
            internal StateTriggerReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
                context.SetTimer(id: "1", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
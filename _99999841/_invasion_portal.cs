namespace Maple2.Trigger._99999841 {
    public static class _invasion_portal {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈열림 : TriggerState {
            internal State포탈열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 30, arg3: true);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 1, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.ResetTimer(arg1: "1");
                    return new State포탈닫힘(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002184}, arg2: 2)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.GetDungeonVariable(id: 1000) == true) {
                    return new State포탈열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State포탈닫힘 : TriggerState {
            internal State포탈닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetTimer(arg1: "2", arg2: 60, arg3: true);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new State종료(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.ResetTimer(arg1: "2");
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
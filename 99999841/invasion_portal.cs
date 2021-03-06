namespace Maple2.Trigger._99999841 {
    public static class _invasion_portal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal열림 : TriggerState {
            internal StatePortal열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 30, arg3: true);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 1, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.ResetTimer(id: "1");
                    return new StatePortal닫힘(context);
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
                    return new StateEnd(context);
                }

                if (context.GetDungeonVariable(id: 1000) == true) {
                    return new StatePortal열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal닫힘 : TriggerState {
            internal StatePortal닫힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990010, key: "PCmove", value: 0);
                context.SetTimer(id: "2", arg2: 60, arg3: true);
                context.SetInteractObject(arg1: new[] {10002184}, arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 2) == true) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.ResetTimer(id: "2");
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

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
namespace Maple2.Trigger._02000345_bf {
    public static class _dress {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002}, arg2: true, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new[] {10001067}, arg2: 1);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 60002) == 1) {
                    context.State = new Stateready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20003441, textId: 20003441, duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000345_BF__DRESS__0$", arg3: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new Statestart_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart_02 : TriggerState {
            internal Statestart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2001, 2002}, arg2: false, arg3: 0, arg4: 200);
                context.ShowGuideSummary(entityId: 20003444, textId: 20003444, duration: 5000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
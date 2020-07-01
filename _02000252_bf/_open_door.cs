namespace Maple2.Trigger._02000252_bf {
    public static class _open_door {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8903}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 909) == 1) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20002526, textId: 20002526);
                context.SetEffect(arg1: new[] {8903}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000402}, arg2: 0)) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002526);
                context.SetEffect(arg1: new[] {8903}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
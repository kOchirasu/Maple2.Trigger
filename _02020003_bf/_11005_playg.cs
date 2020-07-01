namespace Maple2.Trigger._02020003_bf {
    public static class _11005_playg {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PlayG", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PlayG") == 1) {
                    context.State = new StateActorOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActorOff : TriggerState {
            internal StateActorOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000062}, arg2: 0)) {
                    context.State = new StateActorOn(context);
                    return;
                }

                if (context.GetUserValue(key: "PlayG") == 0) {
                    context.State = new StateResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActorOn : TriggerState {
            internal StateActorOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_blue");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateResetDelay(context);
                    return;
                }

                if (context.GetUserValue(key: "PlayG") == 0) {
                    context.State = new StateResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11005, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateActorOff(context);
                    return;
                }

                if (context.GetUserValue(key: "PlayG") == 0) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
namespace Maple2.Trigger._02020071_bf {
    public static class _11006_playa {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PlayA", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PlayA") == 1) {
                    context.State = new StateActorOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActorOff : TriggerState {
            internal StateActorOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000063}, arg2: 0)) {
                    context.State = new StateActorOn(context);
                    return;
                }

                if (context.GetUserValue(key: "PlayA") == 0) {
                    context.State = new StateResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActorOn : TriggerState {
            internal StateActorOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_navy");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateResetDelay(context);
                    return;
                }

                if (context.GetUserValue(key: "PlayA") == 0) {
                    context.State = new StateResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11006, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateActorOff(context);
                    return;
                }

                if (context.GetUserValue(key: "PlayA") == 0) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
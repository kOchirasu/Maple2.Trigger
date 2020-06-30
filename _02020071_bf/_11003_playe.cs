using System;

namespace Maple2.Trigger._02020071_bf {
    public static class _11003_playe {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PlayE", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "PlayE", value: 1)) {
                    context.State = new StateActorOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActorOff : TriggerState {
            internal StateActorOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000060}, arg2: 0)) {
                    context.State = new StateActorOn(context);
                    return;
                }

                if (context.UserValue(key: "PlayE", value: 0)) {
                    context.State = new StateResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateActorOn : TriggerState {
            internal StateActorOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_yellow");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateResetDelay(context);
                    return;
                }

                if (context.UserValue(key: "PlayE", value: 0)) {
                    context.State = new StateResetDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResetDelay : TriggerState {
            internal StateResetDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 11003, arg2: true, arg3: "ks_quest_musical_B01_off");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateActorOff(context);
                    return;
                }

                if (context.UserValue(key: "PlayE", value: 0)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
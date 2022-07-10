namespace Maple2.Trigger._02000139_bf {
    public static class _01_trigger01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{401, 402, 403, 404}, visible: false);
                context.SetInteractObject(interactIds: new []{10000131}, state: 1);
                context.SetMesh(triggerIds: new []{201, 202, 203}, visible: false);
                context.SetLadder(triggerId: 301, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 302, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 303, visible: false, animationEffect: false);
                context.SetLadder(triggerId: 304, visible: false, animationEffect: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000131}, arg2: 0)) {
                    return new StateSetupSpawn1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn1 : TriggerState {
            internal StateSetupSpawn1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{201}, visible: true);
                context.SetTimer(timerId: "2", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateSetupSpawn2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn2 : TriggerState {
            internal StateSetupSpawn2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{202}, visible: true);
                context.SetTimer(timerId: "3", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateSetupSpawn3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupSpawn3 : TriggerState {
            internal StateSetupSpawn3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{203}, visible: true);
                context.SetTimer(timerId: "4", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateLadder(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadder : TriggerState {
            internal StateLadder(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 301, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{401}, visible: true);
                context.SetLadder(triggerId: 302, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{402}, visible: true);
                context.SetLadder(triggerId: 303, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{403}, visible: true);
                context.SetLadder(triggerId: 304, visible: true, animationEffect: true);
                context.SetEffect(triggerIds: new []{404}, visible: true);
                context.SetTimer(timerId: "4", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

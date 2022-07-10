namespace Maple2.Trigger._02000346_bf {
    public static class _triggerwater {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 60001) == 1) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014}, visible: true, arg3: 0, arg4: 0, arg5: 5f);
                context.SetTimer(timerId: "15", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "15")) {
                    return new StateSetupRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupRandom : TriggerState {
            internal StateSetupRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
                context.SetRandomMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014}, visible: false, meshCount: 8, arg4: 0, delay: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new State유저체크(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    // return new StateEnd(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저체크 : TriggerState {
            internal State유저체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{60002})) {
                    context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateWaitTime(context);
                }

                if (context.MonsterDead(spawnIds: new []{101})) {
                    // return new StateEnd(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

namespace Maple2.Trigger._02000206_bf {
    public static class _barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 402, spawnIds: new []{101})) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateBlock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock : TriggerState {
            internal StateBlock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516}, visible: true, arg3: 0, arg4: 200);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateUnblock(context);
                }

                if (!context.UserDetected(boxIds: new []{402})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnblock : TriggerState {
            internal StateUnblock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510, 511, 512, 513, 514, 515, 516}, visible: false, arg3: 0, arg4: 200);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{402})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

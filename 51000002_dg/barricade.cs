namespace Maple2.Trigger._51000002_dg {
    public static class _barricade {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{99})) {
                    return new StateCount(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCount : TriggerState {
            internal StateCount(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "90", seconds: 90);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "90")) {
                    return new StateBlock(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock : TriggerState {
            internal StateBlock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301}, visible: true, arg3: 0, arg4: 200);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{99})) {
                    return new StateUnblock(context);
                }

                if (!context.UserDetected(boxIds: new []{102})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUnblock : TriggerState {
            internal StateUnblock(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301}, visible: false, arg3: 0, arg4: 0);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{102})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

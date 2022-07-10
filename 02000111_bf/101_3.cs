namespace Maple2.Trigger._02000111_bf {
    public static class _101_3 {
        public class StateWaitStart1 : TriggerState {
            internal StateWaitStart1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000166}, state: 1);
                context.SetMesh(triggerIds: new []{303}, visible: false);
                context.SetEffect(triggerIds: new []{403}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000166}, arg2: 0)) {
                    return new State열기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitStart2 : TriggerState {
            internal StateWaitStart2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000166}, state: 1);
                context.SetMesh(triggerIds: new []{303}, visible: false);
                context.SetEffect(triggerIds: new []{403}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000166}, arg2: 0)) {
                    return new State열기1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열기1 : TriggerState {
            internal State열기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{303}, visible: true);
                context.SetEffect(triggerIds: new []{403}, visible: true);
                context.SetTimer(timerId: "1", seconds: 30);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 203, spawnIds: new []{103})) {
                    return new State아이템1(context);
                }

                if (context.NpcDetected(boxId: 203, spawnIds: new []{104})) {
                    return new State아이템2(context);
                }

                if (context.NpcDetected(boxId: 203, spawnIds: new []{105})) {
                    return new State아이템3(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이템1 : TriggerState {
            internal State아이템1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{503}, triggerId: 0, itemId: 10000166);
                context.SetMesh(triggerIds: new []{303}, visible: false);
                context.SetInteractObject(interactIds: new []{10000166}, state: 1);
                context.SetEffect(triggerIds: new []{403}, visible: true);
                context.DestroyMonster(spawnIds: new []{103});
            }

            public override TriggerState? Execute() {
                return new State빠지기1(context);
            }

            public override void OnExit() { }
        }

        private class State아이템2 : TriggerState {
            internal State아이템2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{503}, triggerId: 0, itemId: 10000166);
                context.SetMesh(triggerIds: new []{303}, visible: false);
                context.SetInteractObject(interactIds: new []{10000166}, state: 1);
                context.SetEffect(triggerIds: new []{403}, visible: true);
                context.DestroyMonster(spawnIds: new []{104});
            }

            public override TriggerState? Execute() {
                return new State빠지기2(context);
            }

            public override void OnExit() { }
        }

        private class State아이템3 : TriggerState {
            internal State아이템3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{503}, triggerId: 0, itemId: 10000166);
                context.SetMesh(triggerIds: new []{303}, visible: false);
                context.SetInteractObject(interactIds: new []{10000166}, state: 1);
                context.SetEffect(triggerIds: new []{403}, visible: true);
                context.DestroyMonster(spawnIds: new []{105});
            }

            public override TriggerState? Execute() {
                return new State빠지기3(context);
            }

            public override void OnExit() { }
        }

        private class State빠지기1 : TriggerState {
            internal State빠지기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateWaitStart2(context);
            }

            public override void OnExit() { }
        }

        private class State빠지기2 : TriggerState {
            internal State빠지기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateWaitStart2(context);
            }

            public override void OnExit() { }
        }

        private class State빠지기3 : TriggerState {
            internal State빠지기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateWaitStart2(context);
            }

            public override void OnExit() { }
        }
    }
}

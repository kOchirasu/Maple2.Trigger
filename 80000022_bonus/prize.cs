namespace Maple2.Trigger._80000022_bonus {
    public static class _prize {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, visible: true);
                context.SetActor(triggerId: 3000, visible: false, initialSequence: "or_functobj_mortar_A01_off");
                context.SetInteractObject(interactIds: new []{11000119}, state: 1);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{301})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{201});
                context.CreateItem(spawnIds: new []{202});
                context.CreateItem(spawnIds: new []{203});
                context.CreateItem(spawnIds: new []{204});
                context.CreateItem(spawnIds: new []{205});
                context.CreateItem(spawnIds: new []{206});
                context.CreateItem(spawnIds: new []{207});
                context.CreateItem(spawnIds: new []{208});
                context.CreateItem(spawnIds: new []{209});
                context.CreateItem(spawnIds: new []{210});
                context.CreateItem(spawnIds: new []{211});
                context.CreateItem(spawnIds: new []{212});
                context.CreateItem(spawnIds: new []{213});
                context.CreateItem(spawnIds: new []{216});
                context.CreateItem(spawnIds: new []{217});
                context.CreateItem(spawnIds: new []{218});
                context.CreateItem(spawnIds: new []{219});
                context.CreateItem(spawnIds: new []{220});
                context.CreateItem(spawnIds: new []{221});
                context.CreateItem(spawnIds: new []{222});
                context.CreateItem(spawnIds: new []{226});
                context.CreateItem(spawnIds: new []{227});
                context.CreateItem(spawnIds: new []{228});
                context.CreateItem(spawnIds: new []{229});
                context.CreateItem(spawnIds: new []{230});
                context.CreateItem(spawnIds: new []{231});
                context.CreateItem(spawnIds: new []{232});
                context.CreateItem(spawnIds: new []{233});
                context.CreateItem(spawnIds: new []{234});
                context.CreateItem(spawnIds: new []{235});
                context.CreateItem(spawnIds: new []{243});
                context.CreateItem(spawnIds: new []{244});
                context.CreateItem(spawnIds: new []{245});
                context.CreateItem(spawnIds: new []{246});
                context.CreateItem(spawnIds: new []{247});
                context.CreateItem(spawnIds: new []{248});
                context.CreateItem(spawnIds: new []{250});
                context.CreateItem(spawnIds: new []{251});
                context.CreateItem(spawnIds: new []{255});
                context.CreateItem(spawnIds: new []{256});
                context.CreateItem(spawnIds: new []{257});
                context.CreateItem(spawnIds: new []{258});
                context.CreateItem(spawnIds: new []{259});
                context.CreateItem(spawnIds: new []{260});
                context.CreateItem(spawnIds: new []{261});
                context.CreateItem(spawnIds: new []{262});
                context.CreateItem(spawnIds: new []{263});
                context.CreateItem(spawnIds: new []{264});
                context.CreateItem(spawnIds: new []{265});
                context.CreateItem(spawnIds: new []{266});
                context.CreateItem(spawnIds: new []{267});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckObject : TriggerState {
            internal StateCheckObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{11000119}, arg2: 0)) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{11000119}, state: 2);
                context.SetActor(triggerId: 3000, visible: true, initialSequence: "or_functobj_mortar_A01_off");
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

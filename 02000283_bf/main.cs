namespace Maple2.Trigger._02000283_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000427, 10000430, 10000431, 10000432, 10000433}, state: 2);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000427}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000427}, arg2: 0)) {
                    return new StateEliteSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEliteSpawn : TriggerState {
            internal StateEliteSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                context.ShowGuideSummary(entityId: 20002818, textId: 20002818, duration: 5000);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetRandomMesh(triggerIds: new []{301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 313, 314, 315, 316, 317, 318, 319, 320, 321, 322, 323, 324, 325, 326, 327, 328, 329, 330, 331, 332, 333, 334, 335, 336, 337, 338, 339, 340, 341, 342, 343, 344, 345, 346, 347, 348, 349, 350, 351, 352, 353, 354, 355}, visible: false, meshCount: 56, arg4: 0, delay: 30);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    context.ShowGuideSummary(entityId: 20002813, textId: 20002813);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    context.SetMesh(triggerIds: new []{400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416}, visible: true, arg3: 0, arg4: 100, arg5: 0f);
                    return new StateWaitDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitDestroy : TriggerState {
            internal StateWaitDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20002813);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

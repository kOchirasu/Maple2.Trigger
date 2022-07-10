namespace Maple2.Trigger._02000328_bf {
    public static class _event3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{201}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{999998})) {
                    return new State진행1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행1 : TriggerState {
            internal State진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State진행2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행2 : TriggerState {
            internal State진행2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271, 272, 273, 274, 275, 276}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1301, 1302, 1303, 1304, 1305})) {
                    return new State진행3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{201, 202}, visible: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{203, 204, 205, 206}, visible: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{207, 208, 209, 210, 211, 212}, visible: true, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{213, 214, 215, 216, 217, 218, 219, 220}, visible: true, arg3: 400, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{221, 222, 223, 224, 225, 226, 227, 228, 229, 230}, visible: true, arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{231, 232, 233, 234, 235, 236, 237, 238, 239, 240, 241, 242}, visible: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{243, 244, 245, 246, 247, 248, 249, 250, 251, 252, 253, 254}, visible: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{255, 256, 257, 258, 259, 260, 261, 262, 263, 264}, visible: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{265, 266, 267, 268, 269, 270, 271, 272}, visible: true, arg3: 900, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{273, 274, 275, 276}, visible: true, arg3: 1000, arg4: 50, arg5: 2f);
                context.ShowGuideSummary(entityId: 20003281, textId: 20003281);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetTimer(timerId: "100", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "100")) {
                    return new StateEnd2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd2 : TriggerState {
            internal StateEnd2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 20003281);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

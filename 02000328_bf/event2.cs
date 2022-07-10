namespace Maple2.Trigger._02000328_bf {
    public static class _event2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159, 160, 161, 162, 163, 164, 165, 166, 167, 168, 169, 170, 171, 172, 173, 174, 175, 176}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1201, 1202, 1203, 1204, 1205})) {
                    return new State진행3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State진행3 : TriggerState {
            internal State진행3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{101, 102}, visible: true, arg3: 100, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{103, 104, 105, 106}, visible: true, arg3: 200, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{107, 108, 109, 110, 111, 112}, visible: true, arg3: 300, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{113, 114, 115, 116, 117, 118, 119, 120}, visible: true, arg3: 400, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{121, 122, 123, 124, 125, 126, 127, 128, 129, 130}, visible: true, arg3: 500, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142}, visible: true, arg3: 600, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154}, visible: true, arg3: 700, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{155, 156, 157, 158, 159, 160, 161, 162, 163, 164}, visible: true, arg3: 800, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{165, 166, 167, 168, 169, 170, 171, 172}, visible: true, arg3: 900, arg4: 50, arg5: 2f);
                context.SetMesh(triggerIds: new []{173, 174, 175, 176}, visible: true, arg3: 1000, arg4: 50, arg5: 2f);
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

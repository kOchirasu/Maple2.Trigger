namespace Maple2.Trigger._02000328_bf {
    public static class _level_01_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCube(triggerIds: new []{5104}, visible: false);
                context.SetMesh(triggerIds: new []{31401, 31402, 31403, 31404, 31405, 31406, 31407, 31408, 31409, 31410, 31411, 31412, 31413, 31414, 31415, 31416, 31417, 31418, 31419}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{41401, 41402}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{10002})) {
                    context.SetMesh(triggerIds: new []{31401, 31402, 31403, 31404, 31405, 31406, 31407, 31408, 31409, 31410, 31411, 31412, 31413, 31414, 31415, 31416, 31417, 31418, 31419}, visible: true, arg3: 0, arg4: 200, arg5: 2f);
                    context.SetMesh(triggerIds: new []{41401, 41402}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

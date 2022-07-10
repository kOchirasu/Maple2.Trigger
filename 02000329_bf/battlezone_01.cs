namespace Maple2.Trigger._02000329_bf {
    public static class _battlezone_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6602, 6601}, visible: false);
                context.SetMesh(triggerIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510}, visible: true, arg3: 0, arg4: 1000, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new State애플몽키소환(context);
                }

                if (context.MonsterDead(spawnIds: new []{1101, 1102})) {
                    return new State섹터개방(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State애플몽키소환 : TriggerState {
            internal State애플몽키소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 101, textId: 20000030);
                context.SetEffect(triggerIds: new []{6602, 6601}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1101, 1102})) {
                    return new State섹터개방(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 101);
            }
        }

        private class State섹터개방 : TriggerState {
            internal State섹터개방(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3, display: false);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 102, textId: 40011);
                context.SetMesh(triggerIds: new []{19991}, visible: false);
                context.SetMesh(triggerIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 102);
            }
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

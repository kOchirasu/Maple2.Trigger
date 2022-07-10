namespace Maple2.Trigger._02000329_bf {
    public static class _battlezone_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6603, 6604}, visible: false);
                context.SetMesh(triggerIds: new []{1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520}, visible: true, arg3: 0, arg4: 1000, arg5: 0f);
                context.SetMesh(triggerIds: new []{19992}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new State애플몽키소환(context);
                }

                if (context.MonsterDead(spawnIds: new []{1103, 1104})) {
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
                context.CreateMonster(spawnIds: new []{702}, arg2: false);
                context.SetEffect(triggerIds: new []{6603, 6604}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1103, 1104})) {
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
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetTimer(timerId: "3", seconds: 3, display: false);
                context.ShowGuideSummary(entityId: 102, textId: 40011);
                context.SetMesh(triggerIds: new []{19992}, visible: false);
                context.SetMesh(triggerIds: new []{1511, 1512, 1513, 1514, 1515, 1516, 1517, 1518, 1519, 1520}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
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

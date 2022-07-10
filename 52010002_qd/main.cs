namespace Maple2.Trigger._52010002_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10002789}, questStates: new byte[]{1})) {
                    return new StateEvent_01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10002789}, questStates: new byte[]{1})) {
                    return new StateEvent_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Space_PopUp_01");
                context.ShowGuideSummary(entityId: 110, textId: 40010);
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1003, 1004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103})) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 110);
            }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1003, 1004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{111, 112, 113}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "Clearbadman");
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{1003, 1004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
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

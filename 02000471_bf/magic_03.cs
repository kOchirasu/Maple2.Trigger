namespace Maple2.Trigger._02000471_bf {
    public static class _magic_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040315, key: "10002021clear", value: 0);
                context.SetUserValue(triggerId: 2040318, key: "10002021clear", value: 0);
                context.SetUserValue(triggerId: 2040322, key: "10002021clear", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002021}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7003}, visible: false);
                context.SetMesh(triggerIds: new []{1103}, visible: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{1203}, visible: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(spawnIds: new []{203}, arg2: false);
                context.AddBuff(boxIds: new []{203}, skillId: 70002021, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{203})) {
                    return new StateEvent_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040315, key: "10002021clear", value: 1);
                context.SetUserValue(triggerId: 2040318, key: "10002021clear", value: 1);
                context.SetUserValue(triggerId: 2040322, key: "10002021clear", value: 1);
                context.SetAchievement(triggerId: 713, type: "trigger", code: "Hauntedmansion");
                context.CreateMonster(spawnIds: new []{165, 166, 167, 168, 169}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 165, sequenceName: "Down_Idle_A", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_03_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03_b : TriggerState {
            internal StateEvent_03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 168, patrolName: "MS2PatrolData_2138");
                context.SetNpcEmotionLoop(spawnId: 165, sequenceName: "Down_Idle_A", duration: 600000f);
                context.SetConversation(type: 1, spawnId: 165, script: "$02000471_BF__MAGIC_03__0$", arg4: 3, arg5: 0);
                context.SetConversation(type: 1, spawnId: 169, script: "$02000471_BF__MAGIC_03__1$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 168, script: "$02000471_BF__MAGIC_03__2$", arg4: 3, arg5: 1);
                context.SetConversation(type: 1, spawnId: 168, script: "$02000471_BF__MAGIC_03__3$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateEvent_03_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_03_c : TriggerState {
            internal StateEvent_03_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{165, 166, 167, 168, 169});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

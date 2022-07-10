namespace Maple2.Trigger._02000471_bf {
    public static class _magic_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040315, key: "10002019clear", value: 0);
                context.SetUserValue(triggerId: 2040316, key: "10002019clear", value: 0);
                context.SetUserValue(triggerId: 2040317, key: "10002019clear", value: 0);
                context.SetUserValue(triggerId: 2040322, key: "10002019clear", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10002019}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.SetMesh(triggerIds: new []{1101}, visible: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(triggerIds: new []{1201}, visible: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.AddBuff(boxIds: new []{201}, skillId: 70002001, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040315, key: "10002019clear", value: 1);
                context.SetUserValue(triggerId: 2040316, key: "10002019clear", value: 1);
                context.SetUserValue(triggerId: 2040317, key: "10002019clear", value: 1);
                context.SetUserValue(triggerId: 2040322, key: "10002019clear", value: 1);
                context.SetAchievement(triggerId: 711, type: "trigger", code: "Hauntedmansion");
                context.CreateMonster(spawnIds: new []{161, 162, 163}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_01_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_b : TriggerState {
            internal StateEvent_01_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 161, sequenceName: "Bore_A");
                context.SetNpcEmotionSequence(spawnId: 162, sequenceName: "Bore_A");
                context.SetNpcEmotionSequence(spawnId: 163, sequenceName: "Bore_A");
                context.SetConversation(type: 1, spawnId: 161, script: "$02000471_BF__MAGIC_01__0$", arg4: 3, arg5: 2);
                context.SetConversation(type: 1, spawnId: 162, script: "$02000471_BF__MAGIC_01__1$", arg4: 3, arg5: 4);
                context.SetConversation(type: 1, spawnId: 163, script: "$02000471_BF__MAGIC_01__2$", arg4: 3, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateEvent_01_c(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01_c : TriggerState {
            internal StateEvent_01_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{161, 162, 163});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

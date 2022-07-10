namespace Maple2.Trigger._02000461_bf {
    public static class _cannon_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{693, 793}, visible: false);
                context.SetMesh(triggerIds: new []{3903}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "cannon03") == 1) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2903}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2903})) {
                    context.SetEffect(triggerIds: new []{693}, visible: true);
                    context.SetMesh(triggerIds: new []{3903}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new StateBoss_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Wait : TriggerState {
            internal StateBoss_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Bosscannon03") == 1) {
                    return new StateBossOnly_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossOnly_Creation : TriggerState {
            internal StateBossOnly_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{693}, visible: false);
                context.SetEffect(triggerIds: new []{793}, visible: true);
                context.SetMesh(triggerIds: new []{3903}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(spawnIds: new []{2903}, arg2: true);
                context.AddBuff(boxIds: new []{2099}, skillId: 70002081, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2903})) {
                    context.SetEffect(triggerIds: new []{693}, visible: true);
                    context.SetEffect(triggerIds: new []{793}, visible: false);
                    context.SetMesh(triggerIds: new []{3903}, visible: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.AddBuff(boxIds: new []{2099}, skillId: 70002082, level: 1, arg4: true, arg5: false);
                    context.AddBuff(boxIds: new []{2903}, skillId: 40444001, level: 1, arg4: true, arg5: false);
                    return new StateBossOnly_ResetCreation(context);
                }

                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossOnly_ResetCreation : TriggerState {
            internal StateBossOnly_ResetCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 90000)) {
                    return new StateBossOnly_Creation(context);
                }

                if (context.GetUserValue(key: "DungeonClear") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{693, 793}, visible: false);
                context.SetMesh(triggerIds: new []{3903}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(spawnIds: new []{2903});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

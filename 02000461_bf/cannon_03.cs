namespace Maple2.Trigger._02000461_bf {
    public static class _cannon_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {693, 793}, arg2: false);
                context.SetMesh(arg1: new[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {2903}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2903})) {
                    context.SetEffect(arg1: new[] {693}, arg2: true);
                    context.SetMesh(arg1: new[] {3903}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new StateBoss_대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_대기 : TriggerState {
            internal StateBoss_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {693}, arg2: false);
                context.SetEffect(arg1: new[] {793}, arg2: true);
                context.SetMesh(arg1: new[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {2903}, arg2: true);
                context.AddBuff(arg1: new[] {2099}, arg2: 70002081, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2903})) {
                    context.SetEffect(arg1: new[] {693}, arg2: true);
                    context.SetEffect(arg1: new[] {793}, arg2: false);
                    context.SetMesh(arg1: new[] {3903}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.AddBuff(arg1: new[] {2099}, arg2: 70002082, arg3: 1, arg4: true, arg5: false);
                    context.AddBuff(arg1: new[] {2903}, arg2: 40444001, arg3: 1, arg4: true, arg5: false);
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

            public override TriggerState Execute() {
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
                context.SetEffect(arg1: new[] {693, 793}, arg2: false);
                context.SetMesh(arg1: new[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {2903});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
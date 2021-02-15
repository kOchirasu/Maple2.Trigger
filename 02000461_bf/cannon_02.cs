namespace Maple2.Trigger._02000461_bf {
    public static class _cannon_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {692, 792}, arg2: false);
                context.SetMesh(arg1: new[] {3903}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "cannon02") == 1) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {2902}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2902})) {
                    context.SetEffect(arg1: new[] {692}, arg2: true);
                    context.SetMesh(arg1: new[] {3902}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    return new StateBoss_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss_Wait : TriggerState {
            internal StateBoss_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Bosscannon02") == 1) {
                    return new StateBossOnly_Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossOnly_Creation : TriggerState {
            internal StateBossOnly_Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {692}, arg2: false);
                context.SetEffect(arg1: new[] {792}, arg2: true);
                context.SetMesh(arg1: new[] {3902}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.CreateMonster(arg1: new[] {2902}, arg2: true);
                context.AddBuff(arg1: new[] {2099}, arg2: 70002071, arg3: 1, arg4: true, arg5: false);
                context.AddBuff(arg1: new[] {2902}, arg2: 40444001, arg3: 1, arg4: true, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {2902})) {
                    context.SetEffect(arg1: new[] {692}, arg2: true);
                    context.SetEffect(arg1: new[] {792}, arg2: false);
                    context.SetMesh(arg1: new[] {3902}, arg2: false, arg3: 0, arg4: 0, arg5: 5f);
                    context.AddBuff(arg1: new[] {2099}, arg2: 70002072, arg3: 1, arg4: true, arg5: false);
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
                context.SetEffect(arg1: new[] {692, 792}, arg2: false);
                context.SetMesh(arg1: new[] {3902}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new[] {2902});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
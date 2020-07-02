namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7542}, arg2: false);
                context.SetMesh(arg1: new[] {6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 708) == 1) {
                    return new StateFreeze(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFreeze : TriggerState {
            internal StateFreeze(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7542}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 994, arg3: "$02010052_BF__TORCHLIGHT_05__0$", arg4: 3);
                context.SetMesh(arg1: new[] {6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082}, arg2: true, arg3: 80, arg4: 100, arg5: 8f);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateIdle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle_02 : TriggerState {
            internal StateIdle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 200, textId: 20105201);
                context.CreateMonster(arg1: new[] {105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {105})) {
                    return new StateBurn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBurn_state : TriggerState {
            internal StateBurn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7505}, arg2: true);
                context.SetMesh(arg1: new[] {6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082}, arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetMesh(arg1: new[] {600001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__TORCHLIGHT_05__1$", arg3: 3000);
                context.SetEffect(arg1: new[] {7005}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateSpawn_state(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn_state : TriggerState {
            internal StateSpawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 205, textId: 20105202);
                context.SetConversation(arg1: 1, arg2: 994, arg3: "$02010052_BF__TORCHLIGHT_05__2$", arg4: 3);
                context.MoveNpc(arg1: 994, arg2: "MS2PatrolData_1007");
                context.CreateMonster(arg1: new[] {510, 511, 512, 513, 514, 515}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateBlock_spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_spawn : TriggerState {
            internal StateBlock_spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090}, arg2: true, arg3: 80, arg4: 500, arg5: 8f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
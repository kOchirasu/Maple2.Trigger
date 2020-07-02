namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 20499, arg2: false, arg3: "Closed");
                context.SetActor(arg1: 20501, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new[] {20500}, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetEffect(arg1: new[] {7002, 7003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    return new StateBurn_state_01(context);
                }

                if (context.MonsterDead(arg1: new[] {103})) {
                    return new StateBurn_state_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {71001, 71002, 71003, 71004, 71005}, arg2: true);
                context.SetActor(arg1: 8001, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8002, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8003, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8004, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8005, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new[] {301, 302, 303, 304, 305}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 993, arg3: "$02010052_BF__TORCHLIGHT_03__0$", arg4: 3);
            }
        }

        private class StateBurn_state_01 : TriggerState {
            internal StateBurn_state_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {103})) {
                    return new StateBurn_state_complete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7003}, arg2: true);
            }
        }

        private class StateBurn_state_02 : TriggerState {
            internal StateBurn_state_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7003}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {102})) {
                    return new StateBurn_state_complete(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }
        }

        private class StateBurn_state_complete : TriggerState {
            internal StateBurn_state_complete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7503}, arg2: true);
                context.SetMesh(arg1: new[] {6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032}, arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetConversation(arg1: 1, arg2: 9999, arg3: "$02010052_BF__TORCHLIGHT_03__1$", arg4: 3);
                context.HideGuideSummary(entityId: 200);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__TORCHLIGHT_03__2$", arg3: 3000);
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
                context.ShowGuideSummary(entityId: 299, textId: 20105203);
                context.SetMesh(arg1: new[] {5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110}, arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEffect(arg1: new[] {7902}, arg2: true);
                context.DestroyMonster(arg1: new[] {9999});
                context.SetActor(arg1: 8100, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8006, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8007, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8008, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8009, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8010, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new[] {199, 321, 322, 323, 324, 325}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {199})) {
                    return new StateMonsterkill(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 299);
            }
        }

        private class StateMonsterkill : TriggerState {
            internal StateMonsterkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 20499, arg2: true, arg3: "Opening");
                context.SetActor(arg1: 20501, arg2: false, arg3: "Closed");
                context.SetMesh(arg1: new[] {20500}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
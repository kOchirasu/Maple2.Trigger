using System;

namespace Maple2.Trigger._02010052_bf {
    public static class _torchlight_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 20499, arg2: false, arg3: "Closed");
                context.SetActor(arg1: 20501, arg2: true, arg3: "Closed");
                context.SetMesh(arg1: new int[] {20500}, arg2: true, arg3: 1, arg4: 1, arg5: 1f);
                context.SetEffect(arg1: new int[] {7002}, arg2: false);
                context.SetEffect(arg1: new int[] {7003}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new Stateburn_state_01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {103})) {
                    context.State = new Stateburn_state_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {71001}, arg2: true);
                context.SetEffect(arg1: new int[] {71002}, arg2: true);
                context.SetEffect(arg1: new int[] {71003}, arg2: true);
                context.SetEffect(arg1: new int[] {71004}, arg2: true);
                context.SetEffect(arg1: new int[] {71005}, arg2: true);
                context.SetActor(arg1: 8001, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8002, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8003, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8004, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8005, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new int[] {301, 302, 303, 304, 305}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 993, arg3: "$02010052_BF__TORCHLIGHT_03__0$", arg4: 3);
            }
        }

        private class Stateburn_state_01 : TriggerState {
            internal Stateburn_state_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {103})) {
                    context.State = new Stateburn_state_complete(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
            }
        }

        private class Stateburn_state_02 : TriggerState {
            internal Stateburn_state_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7003}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {102})) {
                    context.State = new Stateburn_state_complete(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {7002}, arg2: true);
            }
        }

        private class Stateburn_state_complete : TriggerState {
            internal Stateburn_state_complete(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7503}, arg2: true);
                context.SetMesh(
                    arg1: new int[] {6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032},
                    arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetConversation(arg1: 1, arg2: 9999, arg3: "$02010052_BF__TORCHLIGHT_03__1$", arg4: 3);
                context.HideGuideSummary(entityID: 200);
                context.SetEventUI(arg1: 1, arg2: "$02010052_BF__TORCHLIGHT_03__2$", arg3: new int[] {3000});
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new Statespawn_state(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statespawn_state : TriggerState {
            internal Statespawn_state(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 299, textID: 20105203);
                context.SetMesh(arg1: new int[] {5100, 5101, 5102, 5103, 5104, 5105, 5106, 5107, 5108, 5109, 5110},
                    arg2: false, arg3: 800, arg4: 100, arg5: 8f);
                context.SetEffect(arg1: new int[] {7902}, arg2: true);
                context.DestroyMonster(arg1: new int[] {9999});
                context.SetActor(arg1: 8100, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8006, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8007, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8008, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8009, arg2: false, arg3: "Dmg_A");
                context.SetActor(arg1: 8010, arg2: false, arg3: "Dmg_A");
                context.CreateMonster(arg1: new int[] {199}, arg2: true);
                context.CreateMonster(arg1: new int[] {321, 322, 323, 324, 325}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {199})) {
                    context.State = new Statemonsterkill(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 299);
            }
        }

        private class Statemonsterkill : TriggerState {
            internal Statemonsterkill(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 20499, arg2: true, arg3: "Opening");
                context.SetActor(arg1: 20501, arg2: false, arg3: "Closed");
                context.SetMesh(arg1: new int[] {20500}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
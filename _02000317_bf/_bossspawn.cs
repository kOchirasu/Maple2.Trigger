using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000317_bf {
    public static class _bossspawn {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false, arg5: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false, arg5: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 101) == 1) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false, arg5: false);
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false, arg5: false);
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false, arg5: false);
                context.SetMesh(arg1: new[] {2001, 2002, 2003, 2004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStep_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1 : TriggerState {
            internal StateStep_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new[] {1, 2, 3, 4, 5, 6, 7}, arg2: false);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.CreateMonster(arg1: new[] {202}, arg2: false);
                context.CreateMonster(arg1: new[] {203}, arg2: false);
                context.CreateMonster(arg1: new[] {204}, arg2: false);
                context.CreateMonster(arg1: new[] {205}, arg2: false);
                context.CreateMonster(arg1: new[] {206}, arg2: false);
                context.CreateMonster(arg1: new[] {207}, arg2: false);
                context.CreateMonster(arg1: new[] {208}, arg2: false);
                context.CreateMonster(arg1: new[] {301}, arg2: false);
                context.CreateMonster(arg1: new[] {302}, arg2: false);
                context.CreateMonster(arg1: new[] {303}, arg2: false);
                context.CreateMonster(arg1: new[] {304}, arg2: false);
                context.CreateMonster(arg1: new[] {305}, arg2: false);
                context.CreateMonster(arg1: new[] {306}, arg2: false);
                context.CreateMonster(arg1: new[] {307}, arg2: false);
                context.CreateMonster(arg1: new[] {401}, arg2: false);
                context.CreateMonster(arg1: new[] {402}, arg2: false);
                context.CreateMonster(arg1: new[] {403}, arg2: false);
                context.CreateMonster(arg1: new[] {404}, arg2: false);
                context.CreateMonster(arg1: new[] {405}, arg2: false);
                context.CreateMonster(arg1: new[] {406}, arg2: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new StateStep_1_B_Ready(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1_B_Ready : TriggerState {
            internal StateStep_1_B_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 100, textId: 20031701, duration: 3000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {205, 208})) {
                    context.State = new StateStep_1_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1_B : TriggerState {
            internal StateStep_1_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 3, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    context.State = new StateStep_1_C(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1_C : TriggerState {
            internal StateStep_1_C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 100, textId: 20031701, duration: 3000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {301, 302})) {
                    context.State = new StateStep_1_D_Ready(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1_D_Ready : TriggerState {
            internal StateStep_1_D_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {8, 9, 10, 11}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    context.State = new StateStep_1_D(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1_D : TriggerState {
            internal StateStep_1_D(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 100, textId: 20031701, duration: 3000);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {405})) {
                    context.State = new StateStep_1_E(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_1_E : TriggerState {
            internal StateStep_1_E(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_2 : TriggerState {
            internal StateStep_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.CreateMonster(arg1: new[] {100}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {100})) {
                    context.State = new State종료체크(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {100});
            }
        }

        private class State종료체크 : TriggerState {
            internal State종료체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.DungeonClear();
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
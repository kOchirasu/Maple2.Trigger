namespace Maple2.Trigger._52100041_qd {
    public static class _magic_06 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002077}, arg2: 0)) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7006}, arg2: false);
                context.SetMesh(arg1: new[] {1106}, arg2: false, arg3: 0, arg4: 200, arg5: 15f);
                context.SetMesh(arg1: new[] {1206}, arg2: true, arg3: 0, arg4: 200, arg5: 15f);
                context.CreateMonster(arg1: new[] {206}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {206})) {
                    context.State = new StateEvent_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_06_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_b : TriggerState {
            internal StateEvent_06_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1103, arg3: "$52100041_QD__MAGIC_06__0$", arg4: 3, arg5: 1);
                context.SetNpcEmotionSequence(arg1: 1103, arg2: "Talk_A");
                context.SetConversation(arg1: 1, arg2: 1104, arg3: "$52100041_QD__MAGIC_06__1$", arg4: 3, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 1103, arg3: "$52100041_QD__MAGIC_06__2$", arg4: 3, arg5: 7);
                context.SetConversation(arg1: 1, arg2: 1104, arg3: "$52100041_QD__MAGIC_06__3$", arg4: 3, arg5: 10);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEvent_06_c(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_c : TriggerState {
            internal StateEvent_06_c(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 1104, arg2: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateEvent_06_d(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_d : TriggerState {
            internal StateEvent_06_d(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1103, 1104, 1105, 1101, 1102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateEvent_06_e(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_e : TriggerState {
            internal StateEvent_06_e(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new StateEvent_06_f(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_f : TriggerState {
            internal StateEvent_06_f(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 702, arg2: "trigger", arg3: "Hauntedmansion");
                context.CreateMonster(arg1: new[] {1107, 1108}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEvent_06_g(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_g : TriggerState {
            internal StateEvent_06_g(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1107, arg2: "MS2PatrolData_2140");
                context.MoveNpc(arg1: 1108, arg2: "MS2PatrolData_2141");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new StateEvent_06_h(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_h : TriggerState {
            internal StateEvent_06_h(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1107, arg3: "$52100041_QD__MAGIC_06__4$", arg4: 5, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1108, arg3: "$52100041_QD__MAGIC_06__5$", arg4: 3, arg5: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEvent_06_i(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_i : TriggerState {
            internal StateEvent_06_i(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1107, arg2: "MS2PatrolData_2142");
                context.SetConversation(arg1: 1, arg2: 1107, arg3: "$52100041_QD__MAGIC_06__6$", arg4: 5, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1108, arg3: "$52100041_QD__MAGIC_06__7$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 1107, arg3: "$52100041_QD__MAGIC_06__8$", arg4: 3, arg5: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEvent_06_j(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_j : TriggerState {
            internal StateEvent_06_j(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1108, arg2: "MS2PatrolData_2143");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEvent_06_k(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEvent_06_k : TriggerState {
            internal StateEvent_06_k(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1107, 1108});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
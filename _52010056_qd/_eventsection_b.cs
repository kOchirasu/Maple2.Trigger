namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2004})) {
                    context.State = new State연출준비_A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비_A : TriggerState {
            internal State연출준비_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.AddBuff(arg1: new[] {2001}, arg2: 70000085, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {2001}, arg2: 70000085, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State연출준비_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비_B : TriggerState {
            internal State연출준비_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {999}, arg2: false);
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State경비병_스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경비병_스폰 : TriggerState {
            internal State경비병_스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 121, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003816, msg: "$52010056_QD__EventSection_B__0$", duration: 2800);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State경비병_이동시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경비병_이동시작 : TriggerState {
            internal State경비병_이동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 999, arg2: "MS2PatrolData_3008");
                context.CameraSelectPath(arg1: new[] {4005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State조작_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조작_시작 : TriggerState {
            internal State조작_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.RemoveBuff(arg1: 2001, arg2: 70000107);
                context.SetEventUI(arg1: 1, arg2: "$52010056_QD__EventSection_B__1$", arg3: 3000, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetSound(arg1: 7001, arg2: false);
            }
        }
    }
}
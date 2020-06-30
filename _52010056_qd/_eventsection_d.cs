using System;

namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_d {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
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
                if (context.NpcDetected(arg1: 2005, arg2: new int[] {999})) {
                    context.State = new State연출준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출준비 : TriggerState {
            internal State연출준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State경비병_외침(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경비병_외침 : TriggerState {
            internal State경비병_외침(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 999, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcID: 11003816, msg: "$52010056_QD__EventSection_D__0$", duration: 3727);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3727)) {
                    context.State = new State크림슨스피어_출동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {901}, arg2: true);
                context.CreateMonster(arg1: new int[] {902}, arg2: true);
                context.CreateMonster(arg1: new int[] {903}, arg2: true);
                context.CreateMonster(arg1: new int[] {904}, arg2: true);
                context.CreateMonster(arg1: new int[] {905}, arg2: true);
                context.CreateMonster(arg1: new int[] {906}, arg2: true);
                context.CreateMonster(arg1: new int[] {907}, arg2: true);
                context.CreateMonster(arg1: new int[] {908}, arg2: true);
                context.CreateMonster(arg1: new int[] {909}, arg2: true);
                context.CreateMonster(arg1: new int[] {910}, arg2: true);
                context.CreateMonster(arg1: new int[] {911}, arg2: true);
                context.CreateMonster(arg1: new int[] {912}, arg2: true);
                context.CreateMonster(arg1: new int[] {913}, arg2: true);
                context.CreateMonster(arg1: new int[] {914}, arg2: true);
                context.CreateMonster(arg1: new int[] {915}, arg2: true);
                context.ChangeMonster(arg1: 999, arg2: 901);
            }
        }

        private class State크림슨스피어_출동 : TriggerState {
            internal State크림슨스피어_출동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4007}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.RemoveBuff(arg1: 2001, arg2: 70000107);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
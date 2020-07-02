namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_d {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateReady(context);
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 2005, arg2: new[] {999})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetCinematicUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {4006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State경비병_외침(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경비병_외침 : TriggerState {
            internal State경비병_외침(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.SetCinematicUI(arg1: 3);
                context.SetNpcEmotionSequence(arg1: 999, arg2: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003816, msg: "$52010056_QD__EventSection_D__0$", duration: 3727);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3727)) {
                    return new State크림슨스피어_출동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915}, arg2: true);
                context.ChangeMonster(arg1: 999, arg2: 901);
            }
        }

        private class State크림슨스피어_출동 : TriggerState {
            internal State크림슨스피어_출동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.RemoveBuff(arg1: 2001, arg2: 70000107);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
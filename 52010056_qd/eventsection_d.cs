namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_d {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateReady(context);
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 2005, spawnIds: new []{999})) {
                    return new StateSetupCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic : TriggerState {
            internal StateSetupCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 999, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003816, script: "$52010056_QD__EventSection_D__0$", duration: 3727);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3727)) {
                    return new State크림슨스피어_출동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{901, 902, 903, 904, 905, 906, 907, 908, 909, 910, 911, 912, 913, 914, 915}, arg2: true);
                context.ChangeMonster(removeSpawnId: 999, addSpawnId: 901);
            }
        }

        private class State크림슨스피어_출동 : TriggerState {
            internal State크림슨스피어_출동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4007}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.RemoveBuff(boxId: 2001, skillId: 70000107);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

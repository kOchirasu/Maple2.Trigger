namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_b {
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
                if (context.UserDetected(boxIds: new []{2004})) {
                    return new StateSetupCinematic_A(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic_A : TriggerState {
            internal StateSetupCinematic_A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.AddBuff(boxIds: new []{2001}, skillId: 70000085, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{2001}, skillId: 70000085, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSetupCinematic_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupCinematic_B : TriggerState {
            internal StateSetupCinematic_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{999}, arg2: false);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State경비병_Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경비병_Spawn : TriggerState {
            internal State경비병_Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 121, sequenceName: "Attack_01_B");
                context.AddCinematicTalk(npcId: 11003816, script: "$52010056_QD__EventSection_B__0$", duration: 2800);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State경비병_이동시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경비병_이동시작 : TriggerState {
            internal State경비병_이동시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 999, patrolName: "MS2PatrolData_3008");
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State조작_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조작_시작 : TriggerState {
            internal State조작_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.RemoveBuff(boxId: 2001, skillId: 70000107);
                context.SetEventUI(arg1: 1, script: "$52010056_QD__EventSection_B__1$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetSound(triggerId: 7001, enabled: false);
            }
        }
    }
}

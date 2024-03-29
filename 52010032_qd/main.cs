using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010032_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003090}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.MoveUser(mapId: 52010032, portalId: 7001);
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State치유의식_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_01 : TriggerState {
            internal State치유의식_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN__0$", duration: 3000, illustId: "0", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State치유의식_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_02 : TriggerState {
            internal State치유의식_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_3001");
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN__1$", duration: 3000, illustId: "0", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State치유의식_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_03 : TriggerState {
            internal State치유의식_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_B");
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Cry_A"});
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN__2$", duration: 3000, illustId: "0", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State치유의식_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_04 : TriggerState {
            internal State치유의식_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State치유의식_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_05 : TriggerState {
            internal State치유의식_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003390, script: "$52010032_QD__MAIN__3$", duration: 3000, illustId: "0", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    // return new State의식종료_01(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의식종료01 : TriggerState {
            internal State의식종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State의식종료_02(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의식종료02 : TriggerState {
            internal State의식종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{201});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

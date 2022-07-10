using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000026_in {
    public static class _main {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001568}, questStates: new byte[]{3})) {
                    return new State조건체크01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001568}, questStates: new byte[]{2})) {
                    return new State아노스Exists01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001568}, questStates: new byte[]{1})) {
                    return new State아노스만남CinematicWait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001567}, questStates: new byte[]{3})) {
                    return new StateWait조건01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001567}, questStates: new byte[]{2})) {
                    return new StateWait조건01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001567}, questStates: new byte[]{1})) {
                    return new StateBasic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait조건01 : TriggerState {
            internal StateWait조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001568}, questStates: new byte[]{1})) {
                    return new State아노스만남StartCinematic(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001568}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크01 : TriggerState {
            internal State조건체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001569}, questStates: new byte[]{1})) {
                    return new State아노스Exists01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001569}, questStates: new byte[]{1})) {
                    return new State조건체크02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조건체크02 : TriggerState {
            internal State조건체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001573}, questStates: new byte[]{3})) {
                    return new StateBasic(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{50001568, 50001569, 50001570, 50001571, 50001572, 50001573}, questStates: new byte[]{2})) {
                    return new State아노스Exists01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBasic : TriggerState {
            internal StateBasic(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Exists01 : TriggerState {
            internal State아노스Exists01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스만남CinematicWait : TriggerState {
            internal State아노스만남CinematicWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002}, visible: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.MoveUserPath(patrolName: "MS2PatrolData_PC_00");
                    return new State아노스만남StartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스만남StartCinematic : TriggerState {
            internal State아노스만남StartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8000}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State아노스Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Spawn : TriggerState {
            internal State아노스Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Anos_00");
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__0$", arg4: 4, arg5: 0);
                context.SetSceneSkip(state: new State아노스만남_스킵완료(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스이동01 : TriggerState {
            internal State아노스이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Anos_01");
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3239)) {
                    return new State아노스이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스이동02 : TriggerState {
            internal State아노스이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Anos_02");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스이동03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스이동03 : TriggerState {
            internal State아노스이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__2$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 101, sequenceName: "ChatUp_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    return new State아노스Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01 : TriggerState {
            internal State아노스Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Talk_A", duration: 4000f);
                context.SetSkip(state: new State아노스Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCamera이동_라딘01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script01_skip : TriggerState {
            internal State아노스Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCamera이동_라딘01(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_라딘01 : TriggerState {
            internal StateCamera이동_라딘01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State라딘Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script01 : TriggerState {
            internal State라딘Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000264, script: "$02000026_IN__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Bore_A");
                context.SetSkip(state: new State라딘Script01_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    return new State아노스Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script01_skip : TriggerState {
            internal State라딘Script01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아노스Script02(context);
            }

            public override void OnExit() { }
        }

        private class State아노스Script02 : TriggerState {
            internal State아노스Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 4000f);
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__5$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State아노스Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4519)) {
                    return new State라딘Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script02_skip : TriggerState {
            internal State아노스Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State라딘Script02(context);
            }

            public override void OnExit() { }
        }

        private class State라딘Script02 : TriggerState {
            internal State라딘Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "ChatUP_A");
                context.SetConversation(type: 2, spawnId: 11000264, script: "$02000026_IN__MAIN__6$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State라딘Script02_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    return new StateCamera이동_아노스01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script02_skip : TriggerState {
            internal State라딘Script02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCamera이동_아노스01(context);
            }

            public override void OnExit() { }
        }

        private class StateCamera이동_아노스01 : TriggerState {
            internal StateCamera이동_아노스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script03 : TriggerState {
            internal State아노스Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "ChatUp_A");
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__7$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아노스Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6817)) {
                    return new State아노스Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script03_skip : TriggerState {
            internal State아노스Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아노스Script04(context);
            }

            public override void OnExit() { }
        }

        private class State아노스Script04 : TriggerState {
            internal State아노스Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__8$", arg4: 3, arg5: 0);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_01");
                context.SetSkip(state: new State아노스Script04_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State라딘Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script04_skip : TriggerState {
            internal State아노스Script04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State라딘Script03(context);
            }

            public override void OnExit() { }
        }

        private class State라딘Script03 : TriggerState {
            internal State라딘Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 103, sequenceName: "Talk_A", duration: 4000f);
                context.SetConversation(type: 2, spawnId: 11000264, script: "$02000026_IN__MAIN__9$", arg4: 4, arg5: 0);
                context.SetSkip(state: new State라딘Script03_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StatePC안녕(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라딘Script03_skip : TriggerState {
            internal State라딘Script03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StatePC안녕(context);
            }

            public override void OnExit() { }
        }

        private class StatePC안녕 : TriggerState {
            internal StatePC안녕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Hello_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script05 : TriggerState {
            internal State아노스Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Talk_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__10$", arg4: 3, arg5: 0);
                context.SetSkip(state: new State아노스Script05_skip(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3343)) {
                    return new State아노스Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스Script05_skip : TriggerState {
            internal State아노스Script05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new State아노스Script06(context);
            }

            public override void OnExit() { }
        }

        private class State아노스Script06 : TriggerState {
            internal State아노스Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Idle_A", duration: 3000f);
                context.SetConversation(type: 2, spawnId: 11003313, script: "$02000026_IN__MAIN__11$", arg4: 3, arg5: 0);
                context.ShowCaption(type: CaptionType.Name, title: "$02000026_IN__MAIN__12$", script: "$02000026_IN__MAIN__13$", align: Align.Center | Align.Left, offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 5000, scale: 2.0f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스만남_스킵완료 : TriggerState {
            internal State아노스만남_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStopCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStopCinematic : TriggerState {
            internal StateStopCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(triggerId: 9000, type: "trigger", code: "MeetAnos");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

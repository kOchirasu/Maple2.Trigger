using System;

namespace Maple2.Trigger._02000026_in {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101, 102});
                context.SetMesh(arg1: new int[] {4001, 4002}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001568},
                    arg3: new byte[] {3})) {
                    context.State = new State조건체크01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001568},
                    arg3: new byte[] {2})) {
                    context.State = new State아노스있음01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001568},
                    arg3: new byte[] {1})) {
                    context.State = new State아노스만남연출대기(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001567},
                    arg3: new byte[] {3})) {
                    context.State = new State대기조건01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001567},
                    arg3: new byte[] {2})) {
                    context.State = new State대기조건01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001567},
                    arg3: new byte[] {1})) {
                    context.State = new State기본상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기조건01 : TriggerState {
            internal State대기조건01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001568},
                    arg3: new byte[] {1})) {
                    context.State = new State아노스만남연출시작(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001568},
                    arg3: new byte[] {1})) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건체크01 : TriggerState {
            internal State조건체크01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001569},
                    arg3: new byte[] {1})) {
                    context.State = new State아노스있음01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001569},
                    arg3: new byte[] {1})) {
                    context.State = new State조건체크02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조건체크02 : TriggerState {
            internal State조건체크02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {50001573},
                    arg3: new byte[] {3})) {
                    context.State = new State기본상태(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000},
                    arg2: new int[] {50001568, 50001569, 50001570, 50001571, 50001572, 50001573},
                    arg3: new byte[] {2})) {
                    context.State = new State아노스있음01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State기본상태 : TriggerState {
            internal State기본상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스있음01 : TriggerState {
            internal State아노스있음01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetMesh(arg1: new int[] {4001, 4002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스만남연출대기 : TriggerState {
            internal State아노스만남연출대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetMesh(arg1: new int[] {4001, 4002}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_PC_00");
                    context.State = new State아노스만남연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스만남연출시작 : TriggerState {
            internal State아노스만남연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8000}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State아노스등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스등장 : TriggerState {
            internal State아노스등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_00");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__0$", arg4: 4, arg5: 0);
                context.SetSceneSkip(arg1: "아노스만남_스킵완료", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State아노스이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스이동01 : TriggerState {
            internal State아노스이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_01");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__1$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3239)) {
                    context.State = new State아노스이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스이동02 : TriggerState {
            internal State아노스이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Anos_02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State아노스이동03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스이동03 : TriggerState {
            internal State아노스이동03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__2$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 101, arg2: "ChatUp_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    context.State = new State아노스대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사01 : TriggerState {
            internal State아노스대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__3$", arg4: 4, arg5: 0);
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.SetSkip(arg1: "아노스대사01_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State카메라이동_라딘01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사01_skip : TriggerState {
            internal State아노스대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State카메라이동_라딘01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동_라딘01 : TriggerState {
            internal State카메라이동_라딘01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8003}, arg2: 0);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라딘대사01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대사01 : TriggerState {
            internal State라딘대사01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__4$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Bore_A");
                context.SetSkip(arg1: "라딘대사01_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4623)) {
                    context.State = new State아노스대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대사01_skip : TriggerState {
            internal State라딘대사01_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State아노스대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사02 : TriggerState {
            internal State아노스대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__5$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "아노스대사02_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4519)) {
                    context.State = new State라딘대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사02_skip : TriggerState {
            internal State아노스대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State라딘대사02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대사02 : TriggerState {
            internal State라딘대사02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "ChatUP_A");
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__6$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "라딘대사02_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4780)) {
                    context.State = new State카메라이동_아노스01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대사02_skip : TriggerState {
            internal State라딘대사02_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State카메라이동_아노스01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카메라이동_아노스01 : TriggerState {
            internal State카메라이동_아노스01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State아노스대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사03 : TriggerState {
            internal State아노스대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "ChatUp_A");
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__7$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "아노스대사03_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6817)) {
                    context.State = new State아노스대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사03_skip : TriggerState {
            internal State아노스대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State아노스대사04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사04 : TriggerState {
            internal State아노스대사04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__8$", arg4: 3, arg5: 0);
                context.MoveUserPath(arg1: "MS2PatrolData_PC_01");
                context.SetSkip(arg1: "아노스대사04_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State라딘대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사04_skip : TriggerState {
            internal State아노스대사04_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State라딘대사03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대사03 : TriggerState {
            internal State라딘대사03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8004}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.SetConversation(arg1: 2, arg2: 11000264, arg3: "$02000026_IN__MAIN__9$", arg4: 4, arg5: 0);
                context.SetSkip(arg1: "라딘대사03_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StatePC안녕(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라딘대사03_skip : TriggerState {
            internal State라딘대사03_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StatePC안녕(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC안녕 : TriggerState {
            internal StatePC안녕(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Emotion_Hello_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State아노스대사05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사05 : TriggerState {
            internal State아노스대사05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8001}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__10$", arg4: 3, arg5: 0);
                context.SetSkip(arg1: "아노스대사05_skip");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3343)) {
                    context.State = new State아노스대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사05_skip : TriggerState {
            internal State아노스대사05_skip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new State아노스대사06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스대사06 : TriggerState {
            internal State아노스대사06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Idle_A", arg3: 3000f);
                context.SetConversation(arg1: 2, arg2: 11003313, arg3: "$02000026_IN__MAIN__11$", arg4: 3, arg5: 0);
                context.ShowCaption(type: "NameCaption", title: "$02000026_IN__MAIN__12$",
                    desc: "$02000026_IN__MAIN__13$", align: "centerLeft", offsetRateX: 0.05f, offsetRateY: 0.15f,
                    duration: 5000, scale: 2.0f);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State아노스만남_스킵완료 : TriggerState {
            internal State아노스만남_스킵완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 4);
                context.DestroyMonster(arg1: new int[] {101, 102});
                context.CreateMonster(arg1: new int[] {102});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료 : TriggerState {
            internal State연출종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(arg1: 9000, arg2: "trigger", arg3: "MeetAnos");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
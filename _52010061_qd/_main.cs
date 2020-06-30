using System;

namespace Maple2.Trigger._52010061_qd {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {6001}, arg2: new int[] {91000076},
                    arg3: new byte[] {3})) {
                    context.State = new State칼리브해안전경(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {6001}, arg2: new int[] {91000076},
                    arg3: new byte[] {3})) {
                    context.State = new State맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼리브해안전경 : TriggerState {
            internal State칼리브해안전경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State칼리브해안전경_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼리브해안전경_02 : TriggerState {
            internal State칼리브해안전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "종료_02", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State칼리브해안전경_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State칼리브해안전경_03 : TriggerState {
            internal State칼리브해안전경_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52010061_QD__main__0$", align: "centerLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 2800, scale: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1800)) {
                    context.State = new State교역선비추기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교역선비추기 : TriggerState {
            internal State교역선비추기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State스폰조절(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰조절 : TriggerState {
            internal State스폰조절(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new int[] {102}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new int[] {103}, arg2: false, arg3: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State교역선비추기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State교역선비추기_02 : TriggerState {
            internal State교역선비추기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new int[] {4003, 4005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State레잔대사_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레잔대사_01 : TriggerState {
            internal State레잔대사_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4008}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 103, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcID: 11003846, msg: "$52010061_QD__main__1$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State레잔대사_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State레잔대사_02 : TriggerState {
            internal State레잔대사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: false);
                context.AddCinematicTalk(npcID: 11003846, msg: "$52010061_QD__main__2$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State유페리아대사_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아대사_01 : TriggerState {
            internal State유페리아대사_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 6000f);
                context.AddCinematicTalk(npcID: 11003844, illustID: "Yuperia_normal", msg: "$52010061_QD__main__3$",
                    duration: 4800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State랜듀비앙대사_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜듀비앙대사_01 : TriggerState {
            internal State랜듀비앙대사_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 5000f);
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: false);
                context.AddCinematicTalk(npcID: 11001567, illustID: "Renduebian_normal", msg: "$52010061_QD__main__4$",
                    duration: 4800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State랜듀비앙대사_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜듀비앙대사_02 : TriggerState {
            internal State랜듀비앙대사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: false);
                context.AddCinematicTalk(npcID: 11001567, illustID: "Renduebian_normal", msg: "$52010061_QD__main__5$",
                    duration: 3800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State유페리아대사_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아대사_02 : TriggerState {
            internal State유페리아대사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4009}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 102, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcID: 11003844, illustID: "Yuperia_normal", msg: "$52010061_QD__main__6$",
                    duration: 3800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State랜듀비앙대사_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜듀비앙대사_03 : TriggerState {
            internal State랜듀비앙대사_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 101, arg2: "Talk_A", arg3: 4000f);
                context.CameraSelectPath(arg1: new int[] {4010}, arg2: false);
                context.AddCinematicTalk(npcID: 11001567, illustID: "Renduebian_normal", msg: "$52010061_QD__main__7$",
                    duration: 3800, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State이슈라등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라등장 : TriggerState {
            internal State이슈라등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State이슈라등장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라등장_02 : TriggerState {
            internal State이슈라등장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11001975, msg: "$52010061_QD__main__8$", duration: 4000);
                context.CreateMonster(arg1: new int[] {104}, arg2: false, arg3: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State이슈라등장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라등장_03 : TriggerState {
            internal State이슈라등장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006, 4007}, arg2: false);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State이슈라대사(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라대사 : TriggerState {
            internal State이슈라대사(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 104, arg2: "Talk_A", arg3: 4000f);
                context.AddCinematicTalk(npcID: 11003845, illustID: "Ishura_normal", msg: "$52010061_QD__main__9$",
                    duration: 3000, align: "left");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State이슈라모션(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라모션 : TriggerState {
            internal State이슈라모션(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 104, arg2: "RuneBlader_Bore_A");
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

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료_02 : TriggerState {
            internal State종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 300, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateUI초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUI초기화 : TriggerState {
            internal StateUI초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(isVisible: true);
                context.DestroyMonster(arg1: new int[] {101});
                context.DestroyMonster(arg1: new int[] {102});
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
                context.CameraReset(interpolationTime: 2.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State맵이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State맵이동 : TriggerState {
            internal State맵이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000422);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State : TriggerState {
            internal State(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
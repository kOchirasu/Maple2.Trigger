using System;

namespace Maple2.Trigger._52020030_qd {
    public static class _main30000336 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State체크(context);

        private class State체크 : TriggerState {
            internal State체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2003}, arg2: new int[] {30000336},
                    arg3: new byte[] {2})) {
                    context.State = new State체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State체크2 : TriggerState {
            internal State체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
                context.CreateMonster(arg1: new int[] {107}, arg2: false);
                context.CreateMonster(arg1: new int[] {108}, arg2: false);
                context.SetSceneSkip(arg1: "세번째연출대화진행05", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세번째연출대화진행_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행_01 : TriggerState {
            internal State세번째연출대화진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003756, msg: "...계획이 틀어졌군.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세번째연출대화진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행 : TriggerState {
            internal State세번째연출대화진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcID: 11003753, msg: @"... 왔나.\n바보같은 행동을 했더군.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세번째연출대화진행02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행02 : TriggerState {
            internal State세번째연출대화진행02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4022}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 108, arg2: "Bore_A");
                context.AddCinematicTalk(npcID: 11003756, msg: @"... 할말 없어.\n그래서, 이제 어쩔 셈이지?", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State세번째연출대화진행03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행03 : TriggerState {
            internal State세번째연출대화진행03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4017}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003753, msg: @"훗. 바보같이.\n이제 흑성회가 움직이긴 어렵겠군.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세번째연출대화진행03_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행03_01 : TriggerState {
            internal State세번째연출대화진행03_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4040}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003753, msg: "또 다른 계획을 준비해야겠어.", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State세번째연출대화진행04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행04 : TriggerState {
            internal State세번째연출대화진행04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4022}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 108, arg2: "Talk_A");
                context.AddCinematicTalk(npcID: 11003753, msg: @"그 새로운 계획, 흑성회에도 당연히 전달해 주겠지?\n기대할께.", duration: 5000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State세번째연출대화진행05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행05 : TriggerState {
            internal State세번째연출대화진행05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State세번째연출대화진행06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State세번째연출대화진행06 : TriggerState {
            internal State세번째연출대화진행06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 02020017, arg2: 4);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
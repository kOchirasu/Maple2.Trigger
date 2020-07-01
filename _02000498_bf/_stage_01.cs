using System.Numerics;

namespace Maple2.Trigger._02000498_bf {
    public static class _stage_01 {
        public class State시작연출_6 : TriggerState {
            internal State시작연출_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    context.State = new State페이드아웃(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃 : TriggerState {
            internal State페이드아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State페이드아웃_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_2 : TriggerState {
            internal State페이드아웃_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "곧 새로운 차원으로 당신을 안내 합니다.", arg3: 3000);
                context.SetEffect(arg1: new[] {500}, arg2: true);
                context.SetEffect(arg1: new[] {501}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_3sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작대기_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기_1 : TriggerState {
            internal State시작대기_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserToPos(pos: new Vector3(433f, -6777f, 8701f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State페이드인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드인 : TriggerState {
            internal State페이드인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.ChangeBackground(dds: "BG_Lith_C.dds");
                context.SetAmbientLight(arg1: new Vector3(199f, 207f, 214f));
                context.SetDirectionalLight(arg1: new Vector3(255f, 255f, 255f), arg2: new Vector3(255f, 255f, 255f));
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시작대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작대기 : TriggerState {
            internal State시작대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {100010}, arg2: 70000103, arg3: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    // context.State = new State안내02(context);
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
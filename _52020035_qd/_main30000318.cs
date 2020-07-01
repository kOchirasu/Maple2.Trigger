namespace Maple2.Trigger._52020035_qd {
    public static class _main30000318 {
        public class Stateidle3 : TriggerState {
            internal Stateidle3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {703}, arg2: new[] {30000318}, arg3: new byte[] {2})) {
                    return new State연출시작3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출시작3 : TriggerState {
            internal State연출시작3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 8, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State연출시작3_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연출시작3_1 : TriggerState {
            internal State연출시작3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.VisibleMyPc(isVisible: false);
                context.DestroyMonster(arg1: new[] {117, 118, 119, 120, 121});
                context.CreateMonster(arg1: new[] {110}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {117}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {118}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {119}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {120}, arg2: false, arg3: 0);
                context.CreateMonster(arg1: new[] {121}, arg2: false, arg3: 0);
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State뒷이야기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기 : TriggerState {
            internal State뒷이야기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 8, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003754, msg: "크크큭... 착한 연기 잘 하는군. 라딘.", duration: 3000);
                context.SetSceneSkip(arg1: "끝", arg2: "exit");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State뒷이야기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기_02 : TriggerState {
            internal State뒷이야기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4028}, arg2: false);
                context.AddCinematicTalk(npcId: 11003753, msg: "...", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State뒷이야기01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기01 : TriggerState {
            internal State뒷이야기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4030}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 119, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003756, msg: "훗. 생각보다 잘 넘어간 것 같군요.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003759, msg: "쳇, 복잡하게 만들지 말고 그냥 죽어버리면 되잖아?", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State뒷이야기02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기02 : TriggerState {
            internal State뒷이야기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4026}, arg2: false);
                context.AddCinematicTalk(npcId: 11003754, msg: "하렌. 그럼 우리도 다음 작전을 이야기 해 볼까.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State뒷이야기02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State뒷이야기02_1 : TriggerState {
            internal State뒷이야기02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4031}, arg2: false);
                context.MoveNpc(arg1: 119, arg2: "MS2PatrolData_3008");
                context.AddCinematicTalk(npcId: 11003756, msg: "...후훗.", duration: 3000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 9, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State초기화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초기화 : TriggerState {
            internal State초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 9, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
                context.VisibleMyPc(isVisible: true);
                context.MoveUser(arg1: 02020012, arg2: 1);
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
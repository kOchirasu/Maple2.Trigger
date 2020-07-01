namespace Maple2.Trigger._52020029_qd {
    public static class _main30000329 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {30000329}, arg3: new byte[] {2})) {
                    context.State = new State연출시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작 : TriggerState {
            internal State연출시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State연출시작_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출시작_02 : TriggerState {
            internal State연출시작_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4002, 4003}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52020029, arg2: 6001);
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State진리의문입장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진리의문입장 : TriggerState {
            internal State진리의문입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3003");
                context.AddCinematicTalk(npcId: 11003755, msg: "후. 이제서야 이곳에 들어오게 되는 군요.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State진리의문입장_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진리의문입장_02 : TriggerState {
            internal State진리의문입장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
                context.AddCinematicTalk(npcId: 11003755, msg: "덕분에 정말 큰 도움 받았습니다.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State진리의문입장_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진리의문입장_03 : TriggerState {
            internal State진리의문입장_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointId: 0, emotionName: "defaultBattle");
                context.AddCinematicTalk(npcId: 0, msg: "저건...", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State진리의문유례(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진리의문유례 : TriggerState {
            internal State진리의문유례(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003}, arg2: false);
                context.AddCinematicTalk(npcId: 11003755, msg: "아아. 저 두개의 큰 화면. 저것이 바로 진리의 문입니다.", duration: 3000);
                context.AddCinematicTalk(npcId: 11003755, msg: "듣기론 세상의 모든 정보를 찾을 수 있는 기계라더군요.", duration: 3000);
                context.SetSceneSkip(arg1: "마무리", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State감탄(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State감탄 : TriggerState {
            internal State감탄(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_B");
                context.AddCinematicTalk(npcId: 11003717, msg: "아아... 저것을 직접 만져볼 수 있다니 황홀하군!", duration: 3000);
                context.AddCinematicTalk(npcId: 11003755, msg: "자, 시간이 없으니 빨리 원하는 정보를 검색해 보죠.", duration: 3000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State마무리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마무리2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리2 : TriggerState {
            internal State마무리2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020029, arg2: 6002);
                context.DestroyMonster(arg1: new[] {101, 102});
                context.CreateMonster(arg1: new[] {104, 105}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마무리3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마무리3 : TriggerState {
            internal State마무리3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
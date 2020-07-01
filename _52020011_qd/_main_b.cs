namespace Maple2.Trigger._52020011_qd {
    public static class _main_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetActor(arg1: 8001, arg2: false, arg3: "Attack_Idle_A");
                context.SetEffect(arg1: new[] {5001}, arg2: false);
                context.SetEffect(arg1: new[] {5002}, arg2: false);
                context.SetEffect(arg1: new[] {5003}, arg2: false);
                context.SetEffect(arg1: new[] {5004}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200130},
                    arg3: new byte[] {2})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSet(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSet : TriggerState {
            internal StateSet(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020011, arg2: 6001);
                context.CameraSelectPath(arg1: new[] {4009}, arg2: false);
                context.SetActor(arg1: 8001, arg2: true, arg3: "Attack_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGo(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGo : TriggerState {
            internal StateGo(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11003599, msg: "나 $npcName:11003599$의 이름으로 명한다.", duration: 2800);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateScene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_01 : TriggerState {
            internal StateScene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003599, msg: "이 땅의 모든 저주받은 존재여! 깊고 어두운 곳으로 떨어져라!", duration: 2800);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateScene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_02 : TriggerState {
            internal StateScene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001}, arg2: true);
                context.SetEffect(arg1: new[] {5002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateScene_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_03 : TriggerState {
            internal StateScene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5003}, arg2: true);
                context.SetEffect(arg1: new[] {5004}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.AddBalloonTalk(spawnPointId: 0, msg: "!", duration: 2000, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    context.State = new StateScene_Exit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateScene_Exit : TriggerState {
            internal StateScene_Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52020020, arg2: 6001);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
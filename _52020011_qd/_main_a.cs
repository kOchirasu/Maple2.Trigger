namespace Maple2.Trigger._52020011_qd {
    public static class _main_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {60200015}, arg3: new byte[] {2})) {
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
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSetting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
                context.MoveUser(arg1: 52020011, arg2: 6001);
                context.SetSceneSkip(arg1: "Exit", arg2: "Exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statescene_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_01 : TriggerState {
            internal Statescene_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {4002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$map:52020011$", desc: "$NpcName:11003599$의 임시 거처", align: "centerLeft", offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 3000, scale: 1.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new Statescene_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_02 : TriggerState {
            internal Statescene_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003, 4004, 4005, 4006}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new Statescene_03(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetPcEmotionSequence(arg1: "Emotion_Chin_Chin_A");
            }
        }

        private class Statescene_03 : TriggerState {
            internal Statescene_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4007, 4008}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new Statescene_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statescene_04 : TriggerState {
            internal Statescene_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", title: "$NpcName:11003599$", desc: "크리티아스 왕녀", align: "centerLeft", offsetRateX: 0.05f, offsetRateY: 0.15f, duration: 3000, scale: 2.0f);
                context.AddCinematicTalk(npcId: 11003599, msg: "그래, 반갑구나.", duration: 2800);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateExit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateExit : TriggerState {
            internal StateExit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}
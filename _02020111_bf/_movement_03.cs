using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _movement_03 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    context.State = new State환경변화_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State환경변화_3 : TriggerState {
            internal State환경변화_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.GetUserValue(key: "dark") == 5) {
                    context.State = new State페이드아웃_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드아웃_3 : TriggerState {
            internal State페이드아웃_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 6, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조명변경_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조명변경_3 : TriggerState {
            internal State조명변경_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 62100014, arg3: 1, arg4: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
                context.AddBuff(arg1: new[] {1001}, arg2: 75000001, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new State페이드인_3(context);
                    return;
                }

                if (context.GetUserValue(key: "Movement") == 0) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State페이드인_3 : TriggerState {
            internal State페이드인_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State유저이동_3(context);
                    return;
                }

                if (context.GetUserValue(key: "Movement") == 0) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유저이동_3 : TriggerState {
            internal State유저이동_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조명리셋_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조명리셋_3 : TriggerState {
            internal State조명리셋_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02020111_BF__MOVEMENT_01__2$", arg4: 3, arg5: 0);
                context.MoveNpcToPos(spawnPointId: 101, pos: new Vector3(-8f, -3318f, 1651f),
                    rot: new Vector3(0f, 0f, 45f));
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1005}, arg2: 75000002, arg3: 1);
                context.SetEffect(arg1: new[] {200021, 200022, 200023, 200024, 200025}, arg2: true);
                context.SetPortal(arg1: 11, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: false, arg3: false, arg4: false);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.GetUserValue(key: "dark") == 6) {
                    context.State = new State중앙지역이동_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중앙지역이동_3 : TriggerState {
            internal State중앙지역이동_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200021, 200022, 200023, 200024, 200025}, arg2: false);
                context.MoveNpcToPos(spawnPointId: 101, pos: new Vector3(-13f, 288f, 1951f),
                    rot: new Vector3(0f, 0f, 45f));
                context.SetPortal(arg1: 11, arg2: false, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State중앙지역이동_3_페이드인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State중앙지역이동_3_페이드인 : TriggerState {
            internal State중앙지역이동_3_페이드인(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State포탈설정_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State포탈설정_3 : TriggerState {
            internal State포탈설정_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 6, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 7, arg2: true, arg3: true, arg4: true);
                context.SetPortal(arg1: 8, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}
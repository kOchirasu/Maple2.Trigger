using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _movement_01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new State환경변화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State환경변화 : TriggerState {
            internal State환경변화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "dark") == 1) {
                    return new StateFadeOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut : TriggerState {
            internal StateFadeOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조명변경(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명변경 : TriggerState {
            internal State조명변경(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 62100014, arg3: 1, arg4: true);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEventUI(arg1: 1, script: "$02020111_BF__MOVEMENT_01__0$", arg3: 3000);
                context.SetAmbientLight(arg1: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(arg1: new Vector3(0f, 0f, 0f), arg2: new Vector3(206f, 174f, 84f));
                context.AddBuff(arg1: new[] {1001}, arg2: 75000001, arg3: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateFadeIn(context);
                }

                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn : TriggerState {
            internal StateFadeIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020111_BF__MOVEMENT_01__2$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조명리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명리셋 : TriggerState {
            internal State조명리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$02020111_BF__MOVEMENT_01__1$", arg4: 3, arg5: 0);
                context.MoveNpcToPos(spawnPointId: 101, pos: new Vector3(-3743f, 294f, 1651f), rot: new Vector3(0f, 0f, 45f));
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(arg1: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(arg1: new Vector3(192f, 210f, 211f), arg2: new Vector3(170f, 170f, 170f));
                context.AddBuff(arg1: new[] {1001}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1002}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1003}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1004}, arg2: 75000002, arg3: 1);
                context.AddBuff(arg1: new[] {1005}, arg2: 75000002, arg3: 1);
                context.SetEffect(arg1: new[] {200031, 200032, 200033, 200034, 200035}, arg2: true);
                context.SetPortal(portalId: 9, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "dark") == 2) {
                    return new State중앙지역이동_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중앙지역이동_1 : TriggerState {
            internal State중앙지역이동_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {200031, 200032, 200033, 200034, 200035}, arg2: false);
                context.MoveNpcToPos(spawnPointId: 101, pos: new Vector3(-13f, 288f, 1951f), rot: new Vector3(0f, 0f, 45f));
                context.SetPortal(portalId: 9, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State중앙지역이동_1_FadeIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중앙지역이동_1_FadeIn : TriggerState {
            internal State중앙지역이동_1_FadeIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StatePortal설정_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal설정_1 : TriggerState {
            internal StatePortal설정_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
using System.Numerics;

namespace Maple2.Trigger._02020111_bf {
    public static class _movement_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new State환경변화_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State환경변화_4 : TriggerState {
            internal State환경변화_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "dark") == 7) {
                    return new StateFadeOut_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeOut_4 : TriggerState {
            internal StateFadeOut_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 6, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 7, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조명변경_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명변경_4 : TriggerState {
            internal State조명변경_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{101}, skillId: 62100014, level: 1, arg4: true);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(color: new Vector3(52f, 48f, 38f));
                context.SetDirectionalLight(diffuseColor: default, specularColor: new Vector3(206f, 174f, 84f));
                context.AddBuff(boxIds: new []{1001}, skillId: 75000001, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateFadeIn_4(context);
                }

                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFadeIn_4 : TriggerState {
            internal StateFadeIn_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State유저이동_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동_4 : TriggerState {
            internal State유저이동_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State조명리셋_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State조명리셋_4 : TriggerState {
            internal State조명리셋_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$02020111_BF__MOVEMENT_01__2$", arg4: 3, arg5: 0);
                context.MoveNpcToPos(spawnId: 101, position: new Vector3(3598f, 284f, 2551f), rotation: new Vector3(0f, 0f, 45f));
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetAmbientLight(color: new Vector3(183f, 189f, 201f));
                context.SetDirectionalLight(diffuseColor: new Vector3(192f, 210f, 211f), specularColor: new Vector3(170f, 170f, 170f));
                context.AddBuff(boxIds: new []{1001}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1002}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1003}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1004}, skillId: 75000002, level: 1);
                context.AddBuff(boxIds: new []{1005}, skillId: 75000002, level: 1);
                context.SetEffect(triggerIds: new []{200011, 200012, 200013, 200014, 200015}, visible: true);
                context.SetPortal(portalId: 12, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "dark") == 8) {
                    return new State중앙지역이동_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중앙지역이동_4 : TriggerState {
            internal State중앙지역이동_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{200011, 200012, 200013, 200014, 200015}, visible: false);
                context.MoveNpcToPos(spawnId: 101, position: new Vector3(-13f, 288f, 1951f), rotation: new Vector3(0f, 0f, 45f));
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State중앙지역이동_4_FadeIn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State중앙지역이동_4_FadeIn : TriggerState {
            internal State중앙지역이동_4_FadeIn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StatePortal설정_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortal설정_4 : TriggerState {
            internal StatePortal설정_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 6, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 7, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 8, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Movement") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

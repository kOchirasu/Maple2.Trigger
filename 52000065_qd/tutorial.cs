using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000065_qd {
    public static class _tutorial {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1000, 2000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 20, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 30, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 40, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 60, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 70, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 80, visible: false, enabled: false, minimapVisible: false);
                context.CreateWidget(type: WidgetType.Guide);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new State영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare_01 : TriggerState {
            internal State영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State영상완료_01(context);
                }

                if (context.WaitTick(waitTick: 190000)) {
                    return new State영상완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상완료_01 : TriggerState {
            internal State영상완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Guide, condition: "IsTriggerEvent", value: "251")) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new State해제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해제 : TriggerState {
            internal State해제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1000, 2000}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.GuideEvent(eventId: 260);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001}, jobCode: 90)) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 110)) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 100)) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 1)) {
                    context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                    context.StartTutorial();
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 10)) {
                    context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 20)) {
                    context.SetPortal(portalId: 20, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 30)) {
                    context.SetPortal(portalId: 30, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 40)) {
                    context.SetPortal(portalId: 40, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 50)) {
                    context.SetPortal(portalId: 50, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 60)) {
                    context.SetPortal(portalId: 60, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 70)) {
                    context.SetPortal(portalId: 70, visible: true, enabled: true, minimapVisible: true);
                }

                if (context.UserDetected(boxIds: new []{9001}, jobCode: 80)) {
                    context.SetPortal(portalId: 80, visible: true, enabled: true, minimapVisible: true);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000369_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001}, visible: false);
                context.SetEffect(triggerIds: new []{6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, visible: true);
                context.SetSkill(triggerIds: new []{7001, 7002, 7003}, enabled: false);
                context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(triggerIds: new []{3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067, 3070, 3071}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetLadder(triggerId: 3101, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3102, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3103, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3104, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3105, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3106, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3107, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3108, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3109, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3110, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3111, visible: true, animationEffect: true, animationDelay: 0);
                context.SetLadder(triggerId: 3112, visible: true, animationEffect: true, animationDelay: 0);
                context.SetInteractObject(interactIds: new []{10000978, 10000979, 10000980, 10000981, 10000982}, state: 2);
                context.SetPortal(portalId: 32, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new StateStartCinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCinematic : TriggerState {
            internal StateStartCinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 111, 112, 113, 114, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 129}, arg2: false);
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "Nutaman_intro.swf", movieId: 1);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State전투01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 111, 112, 113, 114, 115, 116, 117, 118, 119, 121, 122, 123, 124, 125, 126, 127, 128, 129})) {
                    return new State전투02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000978, 10000979, 10000980}, state: 1);
                context.CreateMonster(spawnIds: new []{201, 202, 203, 204, 205, 211, 212, 213, 214, 215, 216, 217, 218, 221, 222, 223, 224, 225, 226, 227, 228}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204, 205, 211, 212, 213, 214, 215, 216, 217, 218, 221, 222, 223, 224, 225, 226, 227, 228})) {
                    return new State전투03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투03 : TriggerState {
            internal State전투03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000981, 10000982}, state: 1);
                context.CreateMonster(spawnIds: new []{301, 302, 303}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302, 303})) {
                    context.SetMesh(triggerIds: new []{3060, 3061, 3062, 3063, 3064, 3065, 3066, 3067}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMesh(triggerIds: new []{3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028, 3029, 3030, 3031, 3032, 3033, 3034, 3035, 3036, 3037, 3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046, 3047, 3048, 3049, 3050, 3051, 3052, 3053, 3054, 3055, 3056}, visible: true, arg3: 0, arg4: 50, arg5: 1f);
                    return new State전투04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투04 : TriggerState {
            internal State전투04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{411, 412, 413, 414, 421, 422, 423, 424}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{411, 412, 413, 414, 421, 422, 423, 424})) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010}, visible: false);
                context.SetMesh(triggerIds: new []{3070, 3071}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
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

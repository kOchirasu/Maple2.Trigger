using Maple2.Trigger.Enum;

namespace Maple2.Trigger._99999942 {
    public static class _main {
        public class StateNone : TriggerState {
            internal StateNone(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: FieldGame.WaterGunBattle, reset: true);
                context.FieldGameConstant(key: "WaitUserTick", value: "15000");
                context.FieldGameConstant(key: "WaitPlayTick", value: "5000");
                context.FieldGameConstant(key: "ResizeWaitTick", value: "15000,15000,15000,15000");
                context.FieldGameConstant(key: "ResizeWarningTick", value: "5000,5000,5000,5000");
                context.FieldGameConstant(key: "SkillSetId", value: "99930047");
                context.FieldGameConstant(key: "MinPlayer", value: "2");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "WaitUser") == 1) {
                    return new State유저Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저Waiting : TriggerState {
            internal State유저Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15, autoRemove: false, display: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MoveUser") == 1) {
                    return new State유저이동(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유저이동 : TriggerState {
            internal State유저이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5, autoRemove: false, display: true);
                context.MoveUser(mapId: 99999942, portalId: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Play") == 1) {
                    return new State게임시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임시작 : TriggerState {
            internal State게임시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PlayRound1") == 1) {
                    return new State라운드1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드1 : TriggerState {
            internal State라운드1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PlayRound2") == 1) {
                    return new State라운드2(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드2 : TriggerState {
            internal State라운드2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28}, visible: false, arg3: 2, arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PlayRound3") == 1) {
                    return new State라운드3(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드3 : TriggerState {
            internal State라운드3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48}, visible: false, arg3: 2, arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PlayRound4") == 1) {
                    return new State라운드4(context);
                }

                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드4 : TriggerState {
            internal State라운드4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60}, visible: false, arg3: 2, arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "End") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20, 21, 22, 23, 24, 25, 26, 27, 28, 29, 30, 31, 32, 33, 34, 35, 36, 37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64}, visible: true, arg3: 0, arg4: 0);
                context.MoveUser(mapId: 99999942, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}

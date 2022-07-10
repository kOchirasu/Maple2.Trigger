namespace Maple2.Trigger._52000064_qd {
    public static class _90000650 {
        public class StateBeginWait : TriggerState {
            internal StateBeginWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{1001, 1002, 1003, 1101, 1102, 1103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199})) {
                    return new State아이템Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이템Creation : TriggerState {
            internal State아이템Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{9000, 9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State완료Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료Wait : TriggerState {
            internal State완료Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{9011, 9012, 9013, 9014, 9015});
                context.SetEventUI(arg1: 7, duration: 3000, boxId: 0);
                context.SetAchievement(triggerId: 199, type: "trigger", code: "ArrivedFlyBalloon");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{90000650}, questStates: new byte[]{3})) {
                    context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
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

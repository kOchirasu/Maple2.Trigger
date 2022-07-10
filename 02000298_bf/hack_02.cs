namespace Maple2.Trigger._02000298_bf {
    public static class _hack_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000370}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{116})) {
                    return new State스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1032}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000370}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000370}, arg2: 0)) {
                    return new State코드체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드체크 : TriggerState {
            internal State코드체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 197, spawnIds: new []{1279})) {
                    return new State코드_1279(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1238})) {
                    return new State코드_1238(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1358})) {
                    return new State코드_1358(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1489})) {
                    return new State코드_1489(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1567})) {
                    return new State코드_1567(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{1679})) {
                    return new State코드_1679(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2389})) {
                    return new State코드_2389(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2347})) {
                    return new State코드_2347(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2478})) {
                    return new State코드_2478(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2456})) {
                    return new State코드_2456(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2569})) {
                    return new State코드_2569(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{2678})) {
                    return new State코드_2678(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3458})) {
                    return new State코드_3458(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3589})) {
                    return new State코드_3589(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3679})) {
                    return new State코드_3679(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{3789})) {
                    return new State코드_3789(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4567})) {
                    return new State코드_4567(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4578})) {
                    return new State코드_4578(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4689})) {
                    return new State코드_4689(context);
                }

                if (context.NpcDetected(boxId: 197, spawnIds: new []{4789})) {
                    return new State코드_4789(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1279 : TriggerState {
            internal State코드_1279(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__0$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1238 : TriggerState {
            internal State코드_1238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__1$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1358 : TriggerState {
            internal State코드_1358(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__2$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1489 : TriggerState {
            internal State코드_1489(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__3$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1567 : TriggerState {
            internal State코드_1567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__4$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1679 : TriggerState {
            internal State코드_1679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__5$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2389 : TriggerState {
            internal State코드_2389(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__6$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2347 : TriggerState {
            internal State코드_2347(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__7$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2478 : TriggerState {
            internal State코드_2478(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__8$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2456 : TriggerState {
            internal State코드_2456(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__9$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2569 : TriggerState {
            internal State코드_2569(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__10$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2678 : TriggerState {
            internal State코드_2678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__11$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3458 : TriggerState {
            internal State코드_3458(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__12$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3589 : TriggerState {
            internal State코드_3589(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__13$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3679 : TriggerState {
            internal State코드_3679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__14$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3789 : TriggerState {
            internal State코드_3789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__15$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4567 : TriggerState {
            internal State코드_4567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__16$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4578 : TriggerState {
            internal State코드_4578(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__17$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4689 : TriggerState {
            internal State코드_4689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__18$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4789 : TriggerState {
            internal State코드_4789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_02__19$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1800000", seconds: 1800000);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}

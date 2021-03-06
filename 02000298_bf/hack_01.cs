namespace Maple2.Trigger._02000298_bf {
    public static class _hack_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000369}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {106})) {
                    return new State스폰(context);
                }

                if (context.UserDetected(arg1: new[] {107})) {
                    return new State스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1030}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000369}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000369}, arg2: 0)) {
                    return new State코드체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드체크 : TriggerState {
            internal State코드체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 197, arg2: new[] {1279})) {
                    return new State코드_1279(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {1238})) {
                    return new State코드_1238(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {1358})) {
                    return new State코드_1358(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {1489})) {
                    return new State코드_1489(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {1567})) {
                    return new State코드_1567(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {1679})) {
                    return new State코드_1679(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {2389})) {
                    return new State코드_2389(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {2347})) {
                    return new State코드_2347(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {2478})) {
                    return new State코드_2478(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {2456})) {
                    return new State코드_2456(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {2569})) {
                    return new State코드_2569(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {2678})) {
                    return new State코드_2678(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {3458})) {
                    return new State코드_3458(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {3589})) {
                    return new State코드_3589(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {3679})) {
                    return new State코드_3679(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {3789})) {
                    return new State코드_3789(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {4567})) {
                    return new State코드_4567(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {4578})) {
                    return new State코드_4578(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {4689})) {
                    return new State코드_4689(context);
                }

                if (context.NpcDetected(arg1: 197, arg2: new[] {4789})) {
                    return new State코드_4789(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1279 : TriggerState {
            internal State코드_1279(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__0$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1238 : TriggerState {
            internal State코드_1238(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__1$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1358 : TriggerState {
            internal State코드_1358(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__2$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1489 : TriggerState {
            internal State코드_1489(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__3$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1567 : TriggerState {
            internal State코드_1567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__4$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_1679 : TriggerState {
            internal State코드_1679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__5$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2389 : TriggerState {
            internal State코드_2389(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__6$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2347 : TriggerState {
            internal State코드_2347(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__7$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2478 : TriggerState {
            internal State코드_2478(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__8$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2456 : TriggerState {
            internal State코드_2456(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__9$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2569 : TriggerState {
            internal State코드_2569(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__10$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_2678 : TriggerState {
            internal State코드_2678(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__11$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3458 : TriggerState {
            internal State코드_3458(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__12$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3589 : TriggerState {
            internal State코드_3589(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__13$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3679 : TriggerState {
            internal State코드_3679(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__14$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_3789 : TriggerState {
            internal State코드_3789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__15$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4567 : TriggerState {
            internal State코드_4567(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__16$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4578 : TriggerState {
            internal State코드_4578(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__17$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4689 : TriggerState {
            internal State코드_4689(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__18$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State코드_4789 : TriggerState {
            internal State코드_4789(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "5", arg2: 5);
                context.SetEventUI(arg1: 1, script: "$02000298_BF__HACK_01__19$", arg3: 2000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1800000", arg2: 1800000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // return new StateEnd2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
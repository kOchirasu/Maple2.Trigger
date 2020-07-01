namespace Maple2.Trigger._02020141_bf {
    public static class _interactmesh10014100 {
        public class State최초시작 : TriggerState {
            internal State최초시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003154}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount() > 0) {
                    return new State탈것_등장대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_등장대기 : TriggerState {
            internal State탈것_등장대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 3f)) {
                    return new StateWaitTick후에결정01(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateWaitTick후에결정02(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new StateWaitTick후에결정03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTick후에결정01 : TriggerState {
            internal StateWaitTick후에결정01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 110000)) {
                    return new State탈것_확률결정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTick후에결정02 : TriggerState {
            internal StateWaitTick후에결정02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 135000)) {
                    return new State탈것_확률결정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTick후에결정03 : TriggerState {
            internal StateWaitTick후에결정03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 150000)) {
                    return new State탈것_확률결정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_확률결정 : TriggerState {
            internal State탈것_확률결정(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 85f)) {
                    return new State탈것등장_실패(context);
                }

                if (context.RandomCondition(arg1: 15f)) {
                    return new State탈것등장_성공(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것등장_성공 : TriggerState {
            internal State탈것등장_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {914100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State탈것_등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것_등장 : TriggerState {
            internal State탈것_등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020141_BF__INTERACTMESH_PHASE_3_INTERECT_01__0$", arg3: 5000);
                context.SetInteractObject(arg1: new[] {10003154}, arg2: 1);
                context.DestroyMonster(arg1: new[] {914100});
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10003154}, arg2: 0)) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "RidingBattle") == -1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10003154}, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것등장_실패 : TriggerState {
            internal State탈것등장_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {914100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State탈것등장_실패_최종종료처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State탈것등장_실패_최종종료처리 : TriggerState {
            internal State탈것등장_실패_최종종료처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {914100});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}